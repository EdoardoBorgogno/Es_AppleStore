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
        #endregion
    }
}
