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

namespace AppleStore
{
    public partial class Home : UserControl
    {
        //
        // Home control (control for home page)
        //

        //Home control constructor
        public Home()
        {
            InitializeComponent();
        }

        //on Home control load
        private void Home_Load(object sender, EventArgs e)
        {
            //load data in top panels
            if (ConfigurationManager.AppSettings["appStartupPath"] != null)
            {
                LoadTopPanels();
            }
        }

        #region Top panels

        //load data in top panels, make request to db
        private void LoadTopPanels()
        {
            //set connection DB
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";
            
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //
            // Panel customers
            //
            
            //create query
            string sql = "SELECT COUNT(*) FROM Clienti";

            //execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            Home_toPanel_customers_numOfCustomers.Text = dt.Rows[0][0].ToString();

            //
            // Panel orders
            //

            //create query
            sql = "SELECT COUNT(*) FROM Ordini";

            //execute query
            dt.Clear();
            dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            Home_toPanel_orders_numOfOrders.Text = dt.Rows[0][0].ToString();

            //
            // Panel products
            //

            //create query
            sql = "SELECT COUNT(*) FROM Prodotti";

            //execute query
            dt.Clear();
            dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            Home_toPanel_products_numOfProducts.Text = dt.Rows[0][0].ToString();
        }

        #endregion
    }
}
