using AppleStore.Screens.Add_Screens;
using AppleStore.Screens.View_Order;
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

namespace AppleStore.Screens.Orders
{
    //
    // Orders panel
    //
    public partial class Orders : UserControl
    {
        //Constructor
        public Orders()
        {
            InitializeComponent();

            //Disable horizontal scroll
            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        //On cell clik
        private void dataGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int row = e.RowIndex;

                //Get the id of the selected row
                int id = Convert.ToInt32(dataGrid.Rows[row].Cells[0].Value);

                this.AutoScroll = false;
                this.Controls.Clear();
                this.Controls.Add(new ViewOrder(id));
            }
        }

        //On load
        private void Orders_Load(object sender, EventArgs e)
        {
            //Load top panel
            loadTopPanel();

            //Load datagrid
            loadDataGrid();
        }

        //Load datagrid
        private void loadDataGrid()
        {
            //set connection DB
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //
            // Datagrid
            //

            //create query
            string sql = "SELECT Ordini.IdOrdine AS Id, Ordini.DataOrdine AS Data, SUM(Quantita * PrezzoUnitario) AS Totale " +
                          "FROM Ordini INNER JOIN DettagliOrdini On Ordini.IdOrdine = DettagliOrdini.IdOrdine " +
                          "GROUP BY Ordini.IdOrdine, Ordini.DataOrdine";

            //execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set datagrid
            dataGrid.DataSource = dt;

            //add columns
            DataGridViewImageColumn deleteImage = new DataGridViewImageColumn();
            {
                deleteImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                deleteImage.Image = Properties.Resources.view;
                this.dataGrid.Columns.Add(deleteImage);
            }
        }

        //Load top panel
        private void loadTopPanel()
        {
            //set connection DB
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //
            // Panel orders
            //

            //create query
            string sql = "SELECT COUNT(*) FROM Ordini";

            //execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

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

            //
            // Panel avg cost
            //

            //create query
            sql = @"Select AVG(Costo) from (Select SUM(PrezzoUnitario * Quantita) as Costo
                    from Ordini
                    INNER JOIN DettagliOrdini
                    ON DettagliOrdini.IdOrdine = Ordini.IdOrdine
                    GROUP BY Ordini.IdOrdine)
                    as TableAVG";

            //execute query
            dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //set label text
            topPanela_avgOrderCost_numer.Text = Convert.ToInt32(dt.Rows[0][0]).ToString() + "€";
        }

        //On add order button click
        private void button1_Click(object sender, EventArgs e)
        {
            this.AutoScroll = false;
            this.Controls.Clear();
            this.Controls.Add(new AddOrder());
        }

        private void invoicesPanel_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non disponiamo di Office");
        }
    }
}
