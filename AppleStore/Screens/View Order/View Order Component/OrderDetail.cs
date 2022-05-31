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

namespace AppleStore.Screens.View_Order.View_Order_Component
{
    //
    // View_Order_Component_Screen
    //
    public partial class OrderDetail : UserControl
    {
        //Constructor
        public OrderDetail(int detailId)
        {
            InitializeComponent();

            //Set all detail
            loadOrderDetail(detailId);
        }

        //Function for load detail of order
        private void loadOrderDetail(int id)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT NomeProdotto, DettagliOrdini.PrezzoUnitario AS Prezzo, Quantita, ImmagineProdotto " +
                         "FROM DettagliOrdini INNER JOIN Prodotti ON Prodotti.IdProdotto = DettagliOrdini.IdProdotto " +
                         "WHERE IdDettaglio = " + id;

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Set all detail
            detailProductPicture.ImageLocation = @"..\..\Images\" + dt.Rows[0]["ImmagineProdotto"].ToString();
            detailProductName.Text = dt.Rows[0]["NomeProdotto"].ToString();
            detailProductPrice.Text = dt.Rows[0]["Prezzo"].ToString() + "€";
            detailProductQuantity.Text = Convert.ToInt32(dt.Rows[0]["Quantita"]) == 1 ? "" : "X" + dt.Rows[0]["Quantita"].ToString();
        }
    }
}
