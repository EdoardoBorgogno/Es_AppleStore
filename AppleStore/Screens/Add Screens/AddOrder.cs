using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStore.Forms;
using AppleStore.Models;
using AppleStore.Screens.Add_Screens.Add_Screens_Component;
using AppleStore.Screens.Orders;

namespace AppleStore.Screens.Add_Screens
{
    //
    // Add new orders screen
    //
    public partial class AddOrder : UserControl
    {
        //Variable for ProductOrder
        List<int> products = new List<int>();

        //Variable for Order
        private double totalPrice = 0;

        //Constructor
        public AddOrder()
        {
            InitializeComponent();
        }

        //On Control load
        private void AddOrder_Load(object sender, EventArgs e)
        {
            
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //
            //Set id order
            //

            //Create query
            string sql = "Select MAX(IdOrdine) from Ordini";

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            lblIdOrdine.Text = "#" + (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();

            //
            // Set customers combo
            //

            //Create query
            sql = "Select IdCliente, NomeCliente, CognomeCliente from Clienti WHERE Eliminato = 0";

            //Execute query
            dt.Clear();
            dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //
            //Add customers to combo
            //
            
            //Set combo properties
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("IdCliente", typeof(int));
            dataTable.Columns.Add("Cliente", typeof(string));

            //fill dataTable column
            foreach (DataRow row in dt.Rows)
            {
                dataTable.Rows.Add(row["IdCliente"], row["NomeCliente"] + " " + row["CognomeCliente"]);
            }
            
            cmbCustomers.DataSource = dataTable;

            cmbCustomers.DisplayMember = "Cliente";
            cmbCustomers.ValueMember = "IdCliente";
        }
        private void SummaryDetailPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if SummaryDetailPanel_ControlRemoved not called by SummaryDetailPanel.Controls.Clear()
            if (e.Control.Tag != null)
            {
                if(e.Control.Tag != null)
                    SummaryDetailPanel.Controls.Clear();

                //Remove product from list
                products.Remove(Convert.ToInt32(e.Control.Tag));

                //Create detail panel
                totalPrice = 0;
                foreach (var item in products)
                {
                    //Get path of database
                    string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                    //Create adoNetSQL object
                    adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                    //
                    //Set id order
                    //

                    //Create query
                    string sql = "Select PrezzoProdotto from Prodotti WHERE IdProdotto = " + item;

                    //Execute query
                    DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                    totalPrice += dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0][0]);

                    //Add to panel
                    SummaryDetailPanel.Controls.Add(new ProductOrder(item));

                    int numberOfProductPanel = SummaryDetailPanel.Controls.Count - 1;
                    SummaryDetailPanel.Controls[numberOfProductPanel].Location = new Point(5, numberOfProductPanel * 60);
                }

                //load total
                summary_totalPanel_price.Text = totalPrice.ToString() + " €";
            }
        }

        //on add detail click
        private void addItemButton_Click(object sender, EventArgs e)
        {
            //New SelectProductForm
            SelectProductForm selectProductForm = new SelectProductForm();

            //Show form
            var dialogResult = selectProductForm.ShowDialog();

            //
            //If user select a product
            //            

            if (dialogResult == DialogResult.OK)
            {
                //Add to Summary Panel and to dictionary
                int id = selectProductForm.Product;

                //Add to list
                products.Add(id);

                //Get path of database
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                //Create adoNetSQL object
                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                //
                //Set id order
                //

                //Create query
                string sql = "Select PrezzoProdotto from Prodotti WHERE IdProdotto = " + id;

                //Execute query
                DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                totalPrice += dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[0][0]);

                //set total price
                summary_totalPanel_price.Text = totalPrice.ToString() + " €";

                //add to panel
                SummaryDetailPanel.Controls.Add(new ProductOrder(id));

                int numberOfProductPanel = SummaryDetailPanel.Controls.Count - 1;
                SummaryDetailPanel.Controls[numberOfProductPanel].Location = new Point(5, numberOfProductPanel * 60);
            }
        }

        //On add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Order must contain at least 1 product
            if(dateOrder.Value != null && cmbCustomers.SelectedIndex != -1)
            {
                if (products.Count != 0)
                {
                    //Set dictionary with Products and quantities
                    Dictionary<int, int> productQuantity = new Dictionary<int, int>();

                    //Create dictionary
                    foreach (int productId in products)
                    {
                        if (productQuantity.ContainsKey(productId))
                            productQuantity[productId]++;
                        else
                            productQuantity.Add(productId, 1);
                    }

                    //Get path of database
                    string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                    //Create adoNetSQL object
                    adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                    //Sql Orders
                    string sql = "INSERT INTO Ordini (IdCliente, DataOrdine) VALUES ('" + cmbCustomers.SelectedValue + "', '" + dateOrder.Value.ToString("yyyy/MM/dd") + "')";

                    //Execute query
                    adoNetSQL.eseguiNonQuery(sql, CommandType.Text);

                    //Get id order
                    sql = "Select MAX(IdOrdine) from Ordini";

                    //Execute query
                    DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                    int orderId = Convert.ToInt32(dt.Rows[0][0]);

                    //Sql OrderDetails
                    foreach (KeyValuePair<int, int> item in productQuantity)
                    {
                        sql = "Select PrezzoProdotto from Prodotti WHERE IdProdotto = " + item.Key;
                        DataTable dtPrice = adoNetSQL.eseguiQuery(sql, CommandType.Text);


                        sql = "INSERT INTO DettagliOrdini (IdOrdine, IdProdotto, PrezzoUnitario, Quantita) VALUES (" + orderId + ", " + item.Key + ", " + dtPrice.Rows[0][0].ToString().Replace(',', '.') + ", " + item.Value + ")";

                        //Execute query
                        adoNetSQL.eseguiNonQuery(sql, CommandType.Text);
                    }

                    //return to Orders
                    ((MainForm)this.ParentForm).panelLeft_salesButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ordine deve contenere almeno un prodotto");
                }
            }
            else
            {
                MessageBox.Show("Completa tutti i campi");
            }
        }
    }
}
