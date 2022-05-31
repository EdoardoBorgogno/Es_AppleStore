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
    //
    // Add Categories screen
    //
    public partial class AddCategories : UserControl
    {
        //Constructor
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
                //create new category
                Categories category = new Categories();

                //set category name
                category.CategoryName = txtName.Text;

                //set category description
                category.Description = txtRich.Text;

                //add category to database
                category.addCategory();

                //return to registry
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
