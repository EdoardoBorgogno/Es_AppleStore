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

namespace AppleStore.Screens.Add_Screens.Add_Screens_Component
{
    //
    // Product order detail
    //
    public partial class ProductOrder : UserControl
    {
        int productID;

        //Property
        public int ProductID { get => productID; set => productID = value; }

        //Product Order Constructor
        public ProductOrder(int productIdparam)
        {
            InitializeComponent();

            ProductID = productIdparam;
        }

        //On load
        private void ProductOrder_Load(object sender, EventArgs e)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT * FROM Prodotti WHERE IdProdotto = " + ProductID;

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Set product name
            detailProductName.Text = dt.Rows[0]["NomeProdotto"].ToString();

            //Set product price
            detailProductPrice.Text = dt.Rows[0]["PrezzoProdotto"].ToString() + " €";

            //Set product image
            detailProductPicture.ImageLocation = @"..\..\Images\" + dt.Rows[0]["ImmagineProdotto"].ToString();

        }

        //On delete Button
        private void delete_Click(object sender, EventArgs e)
        {
            this.Tag = productID;
            this.Dispose();
        }
    }
}
