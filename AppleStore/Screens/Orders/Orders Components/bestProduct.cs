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

namespace AppleStore.Screens.Orders.Orders_Components
{
    //
    // Best product
    //
    public partial class bestProduct : UserControl
    {
        //Constructor
        public bestProduct()
        {
            InitializeComponent();
        }

        //On load
        private void bestProduct_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["appStartupPath"] != null)
            {
                //set connection DB
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                //get total orders
                string query = "SELECT COUNT(*) FROM Ordini";

                //execute query
                DataTable dataTable = adoNetSQL.eseguiQuery(query, CommandType.Text);

                if (dataTable.Rows.Count > 0)
                {
                    query = @"SELECT TOP 1 Prodotti.IdProdotto, Prodotti.NomeProdotto, Prodotti.ImmagineProdotto, COUNT(*) AS NumeroVendite FROM Prodotti
                                            INNER JOIN DettagliOrdini ON DettagliOrdini.IdProdotto = Prodotti.IdProdotto
                                            GROUP BY Prodotti.IdProdotto, Prodotti.NomeProdotto, Prodotti.ImmagineProdotto
                                            ORDER BY COUNT(*) DESC";

                    //execute query
                    dataTable.Clear();
                    dataTable = adoNetSQL.eseguiQuery(query, CommandType.Text);

                    if (dataTable.Rows.Count > 0)
                    {
                        //set data
                        ProductImage.ImageLocation = @"..\..\Images\" + dataTable.Rows[0]["ImmagineProdotto"].ToString();
                        lblNameProduct.Text = dataTable.Rows[0]["NomeProdotto"].ToString();
                        lblOrdersNumber.Text = dataTable.Rows[0]["NumeroVendite"].ToString() + " vendite";
                    }
                    else
                    {
                        MessageBox.Show("Errore");
                    }
                }
                else
                {
                    lblTitle.Text = "Non hai venduto nessun prodotto";
                    lblNameProduct.Text = "";
                    lblOrdersNumber.Text = "";
                }
            }
        }
    }
}
