using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class ChartOrdersForMonth : UserControl
    {
        //
        // Chart for orders during time
        //
        public ChartOrdersForMonth()
        {
            InitializeComponent();
        }

        private void ChartOrdersForMonth_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["appStartupPath"] != null)
            {
                revenueChart.Visible = true;

                //set connection DB
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

                //Save current Year
                int currentYear = DateTime.Now.Year;

                //Set title chart
                lblTitleChart.Text = "Ordini Mensili " + currentYear.ToString();

                //
                // Get Revenue for each month
                //

                ChartValues<double> revenues = new ChartValues<double>();

                for (int i = 1; i <= 12; i++)
                {
                    //Sql string
                    string sqlString = @"SELECT Count(*)
                                       FROM Ordini
                                       WHERE MONTH(DataOrdine) = " + i.ToString() + " AND YEAR(DataOrdine) = " + currentYear.ToString() + ";";

                    //Execute query
                    DataTable dataTable = adoNetSQL.eseguiQuery(sqlString, CommandType.Text);

                    revenues.Add(dataTable.Rows[0][0] != DBNull.Value ? Convert.ToDouble(dataTable.Rows[0][0]) : 0);
                }

                //Call function to create chart
                createChart(revenues);
            }
        }

        // Function for create the chart
        private void createChart(ChartValues<double> revenues)
        {
            // Asix X
            revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            revenueChart.AxisX.First().Separator = new LiveCharts.Wpf.Separator { Step = 2 };

            // Asix y
            revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                MinValue = 0
            });

            //Remove grid
            revenueChart.AxisX[0].Separator.StrokeThickness = 0;
            revenueChart.AxisY[0].Separator.StrokeThickness = 0;

            // Series
            revenueChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = revenues,
                    LineSmoothness = 1,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = System.Windows.Media.Brushes.Tomato,
                    Title = "Numero Ordini: ",
                }
            };

            // Remove Legend
            revenueChart.LegendLocation = LegendLocation.None;
        }
    }
}
