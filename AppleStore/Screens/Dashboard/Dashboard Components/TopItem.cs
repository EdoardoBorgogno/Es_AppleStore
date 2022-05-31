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
    // Dashboard: First five products for sale
    //
    public partial class TopItem : UserControl
    {
        //Constructor
        public TopItem()
        {
            InitializeComponent();
        }

        //On load
        private void TopItem_Load(object sender, EventArgs e)
        {
            if(ConfigurationManager.AppSettings["appStartupPath"] != null)
            {
                //set connection DB
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                //sql query
                string sql = @"SELECT TOP 5 Prodotti.IdProdotto, Prodotti.NomeProdotto, Prodotti.ImmagineProdotto, COUNT(*) AS NumeroVendite FROM Prodotti
                           INNER JOIN DettagliOrdini ON DettagliOrdini.IdProdotto = Prodotti.IdProdotto
                           GROUP BY Prodotti.IdProdotto, Prodotti.NomeProdotto, Prodotti.ImmagineProdotto
                           ORDER BY COUNT(*) DESC";

                //execute query
                DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                //set data to gridview
                DataTable table = new DataTable();

                table.Columns.Add("Nome", typeof(string));
                table.Columns.Add(" ", typeof(int));

                foreach (DataRow row in dt.Rows)
                {
                    table.Rows.Add(row["NomeProdotto"].ToString(), row["NumeroVendite"].ToString());
                }

                dataGrid.DataSource = table;
            }
        }
    }
}
