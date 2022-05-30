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
using AppleStore.Screens.Add_Screens;
using AppleStore.Screens.Edit_Screens;

namespace AppleStore.Screens.Registry
{
    public partial class RegistryScreen : UserControl
    {
        //
        // Registry screen
        //

        //Variable for identify the type of registry
        private string type;

        //UserControls constructor
        public RegistryScreen()
        {
            InitializeComponent();
        }

        //
        // ON PAGE LOAD
        //
        private void Registry_Load(object sender, EventArgs e)
        {
            dataGrid.CellClick += new DataGridViewCellEventHandler(dataGrid_cellClick);
            
            btnCustomers_Click(this, e);
        }

        //On cell clik
        private void dataGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(type == "customers")
            {
                if (e.ColumnIndex == 1)
                {
                    int row = e.RowIndex;

                    //Get the id of the selected row
                    int id = Convert.ToInt32(dataGrid.Rows[row].Cells[2].Value);

                    //delete customer
                    Customers customer = new Customers();
                    customer.deleteCustomer(id);

                    //Refresh the dataGrid
                    this.Controls.Clear();
                    this.Controls.Add(new RegistryScreen());
                }
                else if (e.ColumnIndex == 0)
                {
                    int row = e.RowIndex;

                    //Get the id of the selected row
                    int id = Convert.ToInt32(dataGrid.Rows[row].Cells[2].Value);

                    this.Controls.Clear();
                    this.Controls.Add(new EditCustomer(id));
                }
            }
            else if(type == "categories")
            {
                if (e.ColumnIndex == 4)
                {
                    int row = e.RowIndex;

                    //Get the id of the selected row
                    int id = Convert.ToInt32(dataGrid.Rows[row].Cells[0].Value);

                    //delete customer
                    Categories categories = new Categories();
                    categories.deleteCategory(id);

                    //Refresh the dataGrid
                    this.Controls.Clear();
                    this.Controls.Add(new RegistryScreen());
                }
                else if (e.ColumnIndex == 3)
                {
                    int row = e.RowIndex;

                    //Get the id of the selected row
                    int id = Convert.ToInt32(dataGrid.Rows[row].Cells[0].Value);

                    this.Controls.Clear();
                    this.Controls.Add(new EditCategories(id));
                }
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    int row = e.RowIndex;

                    //Get the id of the selected row
                    int id = Convert.ToInt32(dataGrid.Rows[row].Cells[0].Value);

                    //delete customer
                    Product product = new Product();
                    product.DeleteProduct(id);

                    //Refresh the dataGrid
                    this.Controls.Clear();
                    this.Controls.Add(new RegistryScreen());
                }
                else if (e.ColumnIndex == 4)
                {
                    int row = e.RowIndex;

                    //Get the id of the selected row
                    int id = Convert.ToInt32(dataGrid.Rows[row].Cells[0].Value);

                    this.Controls.Clear();
                    this.Controls.Add(new EditProduct(id));
                }
            }
        }

        #region Buttons

        //Button CLIENTI click event
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            type = "customers";

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
                editImage.Tag = "delete";
                deleteImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                deleteImage.Image = Properties.Resources.delete;
                this.dataGrid.Columns.Add(deleteImage);
            }
        }

        //Button CATEGORIE click event
        private void btnCategories_Click(object sender, EventArgs e)
        {
            type = "categories";
            
            //Manage color Button
            btnCustomers.ForeColor = Color.Black;
            btnCategories.ForeColor = Color.MediumSlateBlue;
            btnProducts.ForeColor = Color.Black;

            dataGrid.DataSource = null;
            dataGrid.Columns.Clear();

            Categories categories = new Categories();

            dataGrid.DataSource = categories.GetCategoriesForDataGrid();

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
        }

        //Button PRODOTTI click event
        private void btnProducts_Click(object sender, EventArgs e)
        {
            type = "products";
            
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
        }

        #endregion

        //On add button click
        private void addItemButton_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "customers":
                    AddCustomers addCustomer = new AddCustomers();
                    this.Controls.Clear();
                    this.Controls.Add(addCustomer);
                    break;
                case "categories":
                    AddCategories addCategories = new AddCategories();
                    this.Controls.Clear();
                    this.Controls.Add(addCategories);
                    break;
                case "products":
                    break;
            }
        }
    }
}
