using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Components.Home.Home_Components
{
    //
    // Growth/Decrease of the revenue
    //

    public partial class analyticsMonth : UserControl
    {
        
        // Constructor
        public analyticsMonth()
        {
            InitializeComponent();
        }

        //On load 
        private void analyticsMonth_Load(object sender, EventArgs e)
        {
            //set connection DB
            if (ConfigurationManager.AppSettings["appStartupPath"] != null)
            {
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                //
                //Current month
                //

                //Get dates
                string month = DateTime.Now.ToString("MM");
                string year = DateTime.Now.ToString("yyyy");

                //create query
                string sql = @"SELECT SUM(PrezzoUnitario * Quantita) 
                                   FROM Ordini 
                                   INNER JOIN DettagliOrdini ON DettagliOrdini.IdOrdine = Ordini.IdOrdine
                                   WHERE MONTH(DataOrdine) = " + month + " AND YEAR(DataOrdine) = " + year + ";";

                //execute query
                DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                //Current month revenue
                double revenueCurrentMonth = Convert.ToDouble(dt.Rows[0][0] != DBNull.Value ? Convert.ToDouble(dt.Rows[0][0]) : 0);

                //
                //Previous month
                //

                month = DateTime.Now.AddMonths(-1).ToString("MM");

                //create query
                sql = @"SELECT SUM(PrezzoUnitario * Quantita) 
                                   FROM Ordini 
                                   INNER JOIN DettagliOrdini ON DettagliOrdini.IdOrdine = Ordini.IdOrdine
                                   WHERE MONTH(DataOrdine) = " + month + " AND YEAR(DataOrdine) = " + year + ";";


                //execute query
                dt.Clear();
                dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                //Previous month revenue
                double revenuePreviousMonth = Convert.ToDouble(dt.Rows[0][0] != DBNull.Value ? Convert.ToDouble(dt.Rows[0][0]) : 0);

                //Growth/Decrease
                double growth = 0.0;
                if (revenuePreviousMonth != 0 && revenueCurrentMonth != 0)
                    growth = ((revenueCurrentMonth - revenuePreviousMonth) / revenuePreviousMonth) * 100;
                else if (revenueCurrentMonth != 0)
                    growth = revenueCurrentMonth;
                else if (revenuePreviousMonth != 0)
                    growth = revenuePreviousMonth * -1;

                //Set Panel elements
                string monthName = DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("it"));
                lblPanelDescription.Text = "Andamento " + monthName;

                lblPercentage.Text = growth >= 0 ? "+" + Math.Round(growth, 2).ToString() + "%" : Math.Round(growth, 2).ToString() + "%";
                lblPercentage.ForeColor = growth >= 0 ? Color.LimeGreen : Color.Red;

                chartImage.Image = growth >= 0 ? Properties.Resources.growth : Properties.Resources.degrowth;
            }
        }
    }
}
