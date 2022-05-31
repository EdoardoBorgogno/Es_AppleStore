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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Screens.Edit_Screens
{
    //
    // Edit_Screen_Product
    //
    public partial class EditProduct : UserControl
    {
        int idProduct;
        
        //Constructor
        public EditProduct(int id)
        {
            InitializeComponent();

            idProduct = id;

            Product product = new Product();
            product.GetProductFromId(id);

            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtRich.Text = product.Description;

            //load image
            try
            {
                imageBox.ImageLocation = @"..\..\Images\" + product.Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento dell'immagine");
            }

            //load category combobox
            Categories category = new Categories();

            //
            // value member and display member
            //

            DataTable dt = category.GetCategoriesForDataGrid();
            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Nome";

            //Set selected category
            cmbCategory.SelectedValue = product.Category;
        }

        //Open file dialog
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //Variables for path
            string pathImg = string.Empty;
            string pathDestination = string.Empty;

            //If Open file dialog ended
            if (fileDialogImage.ShowDialog() == DialogResult.OK)
            {
                //Get path
                pathImg = fileDialogImage.FileName;
                
                //Set file path
                string workingDirectory = Environment.CurrentDirectory;
                pathDestination = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\AppleStore\Images\" + pathImg.Split('\\').Last();

                //Copy file
                if (pathDestination != pathImg)
                    File.Copy(pathImg, pathDestination, true);

                //Set image box
                imageBox.ImageLocation = @"..\..\Images\" + pathDestination.Split('\\').Last();
            }
        }

        //On btn click edit product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if all fields are filled
            if (txtName.Text != "" && txtPrice.Text != "" && txtRich.Text != "" && cmbCategory.SelectedIndex != -1 && imageBox.ImageLocation != "")
            {
                //New product
                Product product = new Product();

                //set name
                product.Name = txtName.Text;

                //set price
                try
                {
                    CultureInfo usCulture = new CultureInfo("en-US");
                    NumberFormatInfo dbNumberFormat = usCulture.NumberFormat;

                    product.Price = decimal.Parse(txtPrice.Text.Replace(',', '.'), dbNumberFormat); //=> Manage user input (',' or '.')
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

                //update product
                product.EditProduct(idProduct);

                //go to registry
                this.Controls.Clear();
                this.Controls.Add(new RegistryScreen());
            }
            else
            {
                MessageBox.Show("Compilare tutti i campi");
            }
        }
    }
}
