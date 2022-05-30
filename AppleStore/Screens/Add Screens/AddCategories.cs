using AppleStore.Models;
using AppleStore.Screens.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Screens.Add_Screens
{
    public partial class AddCategories : UserControl
    {
        public AddCategories()
        {
            InitializeComponent();
        }

        //On btn add click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if fields are filled
            if (txtName.Text != "" && txtRich.Text != "")
            {
                Categories category = new Categories();
                
                category.CategoryName = txtName.Text;
                category.Description = txtRich.Text;

                category.addCategory();

                this.Controls.Clear();
                this.Controls.Add(new RegistryScreen());
            }
            else
            {
                MessageBox.Show("Compilare tutti i campi");
            }
        }
    }
}
