using AppleStore.Screens.Add_Screens;
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

namespace AppleStore.Screens.Dashboard
{
    //
    // Dashboard
    //
    public partial class Dashboard : UserControl
    {
        //Constructor
        public Dashboard()
        {
            InitializeComponent();
        }

        //On load
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //
            // Load PANEL AVG
            // 

            //set connection DB
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);
            
            //
            // Panel avg cost
            //

            //create query
            string sql = @"Select AVG(Costo) from (Select SUM(PrezzoUnitario * Quantita) as Costo
                    from Ordini
                    INNER JOIN DettagliOrdini
                    ON DettagliOrdini.IdOrdine = Ordini.IdOrdine
                    GROUP BY Ordini.IdOrdine)
                    as TableAVG";

            //execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            topPanela_avgOrderCost_numer.Text = Convert.ToInt32(dt.Rows[0][0]).ToString() + "€";

            //
            // Panel orders
            //

            //create query
            sql = "SELECT COUNT(*) FROM Ordini";

            //execute query
            dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            topPanel_TotalOrders_number.Text = dt.Rows[0][0].ToString();

            //
            // Panel Saled products
            //

            //create query
            sql = "Select Sum(Quantita) from DettagliOrdini";

            //execute query
            dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            topPanel_TotalProductSales_number.Text = dt.Rows[0][0].ToString();
        }

        //Add new order
        private void button1_Click(object sender, EventArgs e)
        {
            this.AutoScroll = false;
            this.Controls.Clear();
            this.Controls.Add(new AddOrder());
        }
    }
}
