using AppleStore.Models;
using AppleStore.Screens.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Screens.Add_Screens
{
    //
    // Add Product screen
    // 
    public partial class AddProduct : UserControl
    {
        //Constructor
        public AddProduct()
        {
            InitializeComponent();

            //load category combobox
            Categories category = new Categories();

            //
            // value member and display member
            //

            DataTable dt = category.GetCategoriesForDataGrid();
            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Nome";
        }

        //On add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if all fields are filled
            if (txtName.Text != "" && txtRich.Text != "" && txtPrice.Text != "" && cmbCategory.SelectedIndex != -1 && fileDialogImage.FileName != "")
            {
                //Create new product
                Product product = new Product();

                //set name
                product.Name = txtName.Text;

                //set price
                try
                {
                    CultureInfo usCulture = new CultureInfo("en-US");
                    NumberFormatInfo dbNumberFormat = usCulture.NumberFormat;

                    product.Price = decimal.Parse(txtPrice.Text.Replace(',', '.'), dbNumberFormat); //Manage user input (',' or '.')
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inserire un valore numerico");
                }

                //set description
                product.Description = txtRich.Text;

                //set image
                product.Image = imageBox.ImageLocation.ToString().Split('\\').Last();

                //set category
                product.Category = Convert.ToInt32(cmbCategory.SelectedValue);

                //add product
                product.AddProduct();

                //return to registry
                this.Controls.Clear();
                this.Controls.Add(new RegistryScreen());
            }
            else
            {
                MessageBox.Show("Completa tutti i campi");
            }
        }

        //On button open file dialog click
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //two variables for file path
            string pathImg = string.Empty;
            string pathDestination = string.Empty;

            //if file dialog is ended
            if (fileDialogImage.ShowDialog() == DialogResult.OK)
            {
                //get file path from user selection
                pathImg = fileDialogImage.FileName;

                //set destination path
                string workingDirectory = Environment.CurrentDirectory;
                pathDestination = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\AppleStore\Images\" + pathImg.Split('\\').Last();

                //copy file to destination if not exists
                if (pathDestination != pathImg)
                    File.Copy(pathImg, pathDestination, true);

                //Change button text
                btnOpenFile.Text = "Modifica immagine";

                //Set picture box image
                imageBox.ImageLocation = @"..\..\Images\" + pathDestination.Split('\\').Last();
            }
        }
    }
}
