using AppleStore.Screens.Dashboard;
using AppleStore.Screens.Orders;
using AppleStore.Screens.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore
{
    public partial class MainForm : Form
    {
        //
        // Main Form ==> form with left panel(menu) and top panel(three action buttons)
        //
        
        //Form constructor
        public MainForm()
        {
            // Save StartupPath
            ConfigurationManager.AppSettings["appStartupPath"] = Application.StartupPath;

            // Init components
            InitializeComponent();
        }
        
        //Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            //First screen is HOME
            panelUserControl.Controls.Add(new Home());
            panelUserControl.Controls[0].Name = "Home";
        }

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
        
        #region Manage form clicks
        
        //Close form
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Home btn click
        private void panelLeft_homeButton_Click(object sender, EventArgs e)
        {
            if (panelUserControl.Controls.Find("Home", true) != null)
            {
                panelUserControl.Controls.Clear();
                panelUserControl.Controls.Add(new Home());

                selectionPanel.Location = new Point(0, panelLeft_homeButton.Location.Y);
            }
        }

        //Registry btn click
        public void panelLeft_registryButton_Click(object sender, EventArgs e)
        {
            if (panelUserControl.Controls.Find("Registry", true) != null)
            {
                panelUserControl.Controls.Clear();
                panelUserControl.Controls.Add(new RegistryScreen());
                panelUserControl.Controls[0].Name = "Registry";

                selectionPanel.Location = new Point(0, panelLeft_registryButton.Location.Y);
            }
        }

        //Orders btn click
        public void panelLeft_salesButton_Click(object sender, EventArgs e)
        {
            if (panelUserControl.Controls.Find("Orders", true) != null)
            {
                panelUserControl.Controls.Clear();
                panelUserControl.Controls.Add(new Orders());
                panelUserControl.Controls[0].Name = "Orders";
                panelUserControl.Controls[0].Dock = DockStyle.Fill;

                selectionPanel.Location = new Point(0, panelLeft_salesButton.Location.Y);
            }
        }

        //Go to dashboard
        private void panelLeft_dashboardButton_Click(object sender, EventArgs e)
        {
            if (panelUserControl.Controls.Find("Dashboard", true) != null)
            {
                panelUserControl.Controls.Clear();
                panelUserControl.Controls.Add(new Dashboard());
                panelUserControl.Controls[0].Name = "Dashboard";
                panelUserControl.Controls[0].Dock = DockStyle.Fill;

                selectionPanel.Location = new Point(0, panelLeft_dashboardButton.Location.Y);
            }
        }

        //Go to sales
        private void panelTop_btnProduct_Click(object sender, EventArgs e)
        {
            panelLeft_salesButton_Click(this, e);
        }

        //Open apple site
        private void panelTop_btnConnection_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.apple.com/");
        }

        //Go to dashboard
        private void panelTop_btnReport_Click(object sender, EventArgs e)
        {
            panelLeft_dashboardButton_Click(this, e);
        }

        //Go to dashboard
        private void leftPanel_bottomContainer_button_Click(object sender, EventArgs e)
        {
            panelLeft_dashboardButton_Click(this, e);
        }

        #endregion

        //Open url
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    MessageBox.Show("Errore. Riprova!");
                }
            }
        }
    }
}
