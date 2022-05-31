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

namespace AppleStore.Forms
{
    //Form with products list
    public partial class SelectProductForm : Form
    {
        //
        // This form allow user to select products from list
        //

        //Variable
        bool completed = false;

        //Propertis
        int product;
        public int Product { get => product; }


        #region Drag Form

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Start drag
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        //Function for set the new form position
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point sub = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(sub));
            }
        }

        //end drag
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        //Constructor
        public SelectProductForm()
        {
            InitializeComponent();
        }

        //on form load => load products list
        private void SelectProductForm_Load(object sender, EventArgs e)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //
            // get all products from database
            //

            //Create query
            string sql = "Select IdProdotto, NomeProdotto From Prodotti WHERE Eliminato = 0";

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Fill list with products
            productList.DataSource = dt;
            productList.DisplayMember = "NomeProdotto";
            productList.ValueMember = "IdProdotto";

            completed = true;
        }

        //On delete button click => close this form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When Selected value change
        private void productList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (completed)
            {
                //Get selected products
                product = Convert.ToInt32(productList.SelectedValue);

                //Return selected product
                this.DialogResult = DialogResult.OK;

                //Close this form
                this.Close();
            }
            
        }
    }
}
