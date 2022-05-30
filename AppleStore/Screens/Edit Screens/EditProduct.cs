using AppleStore.Models;
using AppleStore.Screens.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Screens.Edit_Screens
{
    public partial class EditProduct : UserControl
    {
        string imagePath;
        int idProduct;
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
                
                MessageBox.Show(imageBox.ImageLocation);
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
        }

        //Open file dialog
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string pathImg = string.Empty;
            string pathDestination = string.Empty;
            
            if (fileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pathImg = fileDialogImage.FileName;
                
                string workingDirectory = Environment.CurrentDirectory;
                pathDestination = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\AppleStore\Images\" + pathImg.Split('\\').Last();

                if (pathDestination != pathImg)
                    File.Copy(pathImg, pathDestination, true);

                imageBox.ImageLocation = @"..\..\Images\" + pathDestination.Split('\\').Last();
            }
        }

        //On btn click edit product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Price = Convert.ToDouble(txtPrice.Text);
            product.Description = txtRich.Text;
            
            product.Image = imageBox.ImageLocation.ToString().Split('\\').Last();
            
            product.Category = Convert.ToInt32(cmbCategory.SelectedValue);

            product.EditProduct(idProduct);

            this.Controls.Clear();
            this.Controls.Add(new RegistryScreen());
        }
    }
}
