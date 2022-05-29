using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStore.Models;

namespace AppleStore.Screens.Registry
{
    public partial class Registry : UserControl
    {
        //
        // Registry screen
        //

        //UserControls constructor
        public Registry()
        {
            InitializeComponent();
        }

        //
        // ON PAGE LOAD
        //
        private void Registry_Load(object sender, EventArgs e)
        {
            btnCustomers_Click(this, e);
        }

        #region Buttons

        //Button CLIENTI click event
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            //Manage color Button
            btnCustomers.ForeColor = Color.MediumSlateBlue;
            btnCategories.ForeColor = Color.Black;
            btnProducts.ForeColor = Color.Black;

            dataGrid.DataSource = null;
            dataGrid.Columns.Clear();
            
            Customers customers = new Customers();

            dataGrid.DataSource = customers.GetCustomersForDataGrid();

            //Add datagrid buttons
            DataGridViewImageColumn editImage = new DataGridViewImageColumn();
            {
                editImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editImage.Image = Properties.Resources.edit;
                this.dataGrid.Columns.Add(editImage);
            }

            DataGridViewImageColumn deleteImage = new DataGridViewImageColumn();
            {
                deleteImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                deleteImage.Image = Properties.Resources.delete;
                this.dataGrid.Columns.Add(deleteImage);
            }

            DataGridViewImageColumn moreImage = new DataGridViewImageColumn();
            {
                moreImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                moreImage.Image = Properties.Resources.more;
                this.dataGrid.Columns.Add(moreImage);
            }
        }

        //Button CATEGORIE click event
        private void btnCategories_Click(object sender, EventArgs e)
        {
            //Manage color Button
            btnCustomers.ForeColor = Color.Black;
            btnCategories.ForeColor = Color.MediumSlateBlue;
            btnProducts.ForeColor = Color.Black;
        }

        //Button PRODOTTI click event
        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Manage color Button
            btnCustomers.ForeColor = Color.Black;
            btnCategories.ForeColor = Color.Black;
            btnProducts.ForeColor = Color.MediumSlateBlue;
            
            dataGrid.DataSource = null;
            dataGrid.Columns.Clear();
            
            Product product = new Product();
            
            dataGrid.DataSource = product.GetProductsForDataGrid();

            //Add datagrid buttons
            DataGridViewImageColumn editImage = new DataGridViewImageColumn();
            {
                editImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editImage.Image = Properties.Resources.edit;
                this.dataGrid.Columns.Add(editImage);
            }

            DataGridViewImageColumn deleteImage = new DataGridViewImageColumn();
            {
                deleteImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                deleteImage.Image = Properties.Resources.delete;
                this.dataGrid.Columns.Add(deleteImage);
            }

            DataGridViewImageColumn moreImage = new DataGridViewImageColumn();
            {
                moreImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                moreImage.Image = Properties.Resources.more;
                this.dataGrid.Columns.Add(moreImage);
            }
        }

        #endregion
    }
}
