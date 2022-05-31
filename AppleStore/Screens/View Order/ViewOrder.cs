using AppleStore.Screens.View_Order.View_Order_Component;
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

namespace AppleStore.Screens.View_Order
{
    //
    // View Order Detail
    //
    public partial class ViewOrder : UserControl
    {
        //Constructor
        public ViewOrder(int orderId)
        {
            InitializeComponent();

            //Load panel
            loadOrder(orderId);

            //Disable horizontal scroll
            SummaryDetailPanel.AutoScroll = false;
            SummaryDetailPanel.HorizontalScroll.Enabled = false;
            SummaryDetailPanel.HorizontalScroll.Visible = false;
            SummaryDetailPanel.HorizontalScroll.Maximum = 0;
            SummaryDetailPanel.AutoScroll = true;
        }

        //load all order detail
        private void loadOrder(int id)
        {
            if(ConfigurationManager.AppSettings["appStartupPath"] != null)
            {
                //Get path of database
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                //Create adoNetSQL object
                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                //Create query
                string sql = "SELECT Ordini.IdOrdine, Clienti.NomeCliente, Clienti.CognomeCliente, Ordini.DataOrdine " +
                             "FROM Ordini INNER JOIN Clienti ON Ordini.IdCliente = Clienti.IdCliente " +
                             "WHERE Ordini.IdOrdine = " + id;

                //Execute query
                DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                //set controls
                lblIdOrdine.Text = "#" + dt.Rows[0]["IdOrdine"].ToString();
                txtCustomer.Text = dt.Rows[0]["NomeCliente"].ToString() + " " + dt.Rows[0]["CognomeCliente"].ToString();

                DateTime date = Convert.ToDateTime(dt.Rows[0]["DataOrdine"]);
                txtDate.Text = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();

                //
                // Load order detail
                //
                
                sql = "SELECT * FROM DettagliOrdini " +
                      "WHERE DettagliOrdini.IdOrdine = " + dt.Rows[0]["IdOrdine"];

                //Execute query
                dt.Clear();
                dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                int i = 0, y = 8;
                foreach (DataRow row in dt.Rows)
                {
                    SummaryDetailPanel.Controls.Add(new OrderDetail(Convert.ToInt32(row["IdDettaglio"])));
                    SummaryDetailPanel.Controls[i].Location = new Point(5, y);
                    
                    i++;
                    y += 60;
                }

                //Load Total price
                sql = "Select SUM(PrezzoUnitario * Quantita) as Costo " + 
                    "from Ordini " +
                    "INNER JOIN DettagliOrdini " + 
                    "ON DettagliOrdini.IdOrdine = Ordini.IdOrdine " +
                    "WHERE Ordini.IdOrdine = " + id + " " +
                    "GROUP BY Ordini.IdOrdine";

                //Execute query
                dt.Clear();
                dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                summary_totalPanel_price.Text = dt.Rows[0]["Costo"].ToString() + " €";
            }
        }

        //On click go to orders
        private void btnBack_Click(object sender, EventArgs e)
        {
            //call panelLeft_ordersButton in mainForm
            ((MainForm)this.ParentForm).panelLeft_salesButton_Click(sender, e);
        }
    }
}
