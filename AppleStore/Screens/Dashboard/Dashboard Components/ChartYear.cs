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

namespace AppleStore.Screens.Dashboard.Dashboard_Components
{
    //
    // Chart for revenue during year
    //
    public partial class ChartYear : UserControl
    {
        public ChartYear()
        {
            InitializeComponent();
        }

        //On Load
        private void ChartYear_Load(object sender, EventArgs e)
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
                lblTitleChart.Text = "Guadagni Mensili " + currentYear.ToString() + " - " + (currentYear - 1).ToString() + " - " + (currentYear - 2).ToString();

                //
                // Get Revenue for each month
                //

                List<ChartValues<double>> arrayRevenue = new List<ChartValues<double>>();

                for (int j = 0; j < 3; j++)
                {
                    ChartValues<double> revenues = new ChartValues<double>();
                    arrayRevenue.Add(revenues);
                    
                    for (int i = 1; i <= 12; i++)
                    {   
                        //Sql string
                        string sqlString = @"SELECT SUM(PrezzoUnitario * Quantita) 
                                       FROM Ordini 
                                       INNER JOIN DettagliOrdini ON DettagliOrdini.IdOrdine = Ordini.IdOrdine
                                       WHERE MONTH(DataOrdine) = " + i.ToString() + " AND YEAR(DataOrdine) = " + (currentYear - j).ToString() + ";";

                        //Execute query
                        DataTable dataTable = adoNetSQL.eseguiQuery(sqlString, CommandType.Text);

                        revenues.Add(dataTable.Rows[0][0] != DBNull.Value ? Convert.ToDouble(dataTable.Rows[0][0]) : 0);
                    }
                }

                //Call function to create chart
                createChart(arrayRevenue);
            }
        }
        
        // Function for create the chart
        private void createChart(List<ChartValues<double>> arrayRevenue)
        {
            int currentYear = DateTime.Now.Year;

            // Asix X
            revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            revenueChart.AxisX.First().Separator = new LiveCharts.Wpf.Separator { Step = 1 };

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
                    Values = arrayRevenue[0],
                    LineSmoothness = 0,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = System.Windows.Media.Brushes.OrangeRed,
                    Title = "Guadagno " + currentYear.ToString() + ": ",
                },
                new LineSeries
                {
                    Values = arrayRevenue[1],
                    LineSmoothness = 0,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = System.Windows.Media.Brushes.MediumSlateBlue,
                    Title = "Guadagno " + (currentYear - 1).ToString() + ": ",
                },
                new LineSeries
                {
                    Values = arrayRevenue[2],
                    LineSmoothness = 0,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    Stroke = System.Windows.Media.Brushes.Gold,
                    Title = "Guadagno " + (currentYear - 2).ToString() + ": ",
                }
            };

            // Remove Legend
            revenueChart.LegendLocation = LegendLocation.None;
        }
    }
}
