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

namespace AppleStore.Screens.Add_Screens
{
    //
    // Add new orders screen
    //
    public partial class AddOrder : UserControl
    {
        //Variable for ProductOrder position
        int i = 0, y = 8;

        //Variable for ProductOrder
        List<int> products = new List<int>();

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

                //add to panel
                SummaryDetailPanel.Controls.Add(new ProductOrder(id));
                SummaryDetailPanel.Controls[i].Location = new Point(5, y);

                i++;
                y += 60;
            }
        }
    }
}
