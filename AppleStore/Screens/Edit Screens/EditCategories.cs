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

namespace AppleStore.Screens.Edit_Screens
{
    public partial class EditCategories : UserControl
    {
        int idCategories;
        public EditCategories(int id)
        {
            InitializeComponent();

            idCategories = id;
            
            Categories categories = new Categories();

            categories.GetCategoriesFromId(id);

            txtName.Text = categories.CategoryName;
            txtRich.Text = categories.Description;
        }

        //On edit button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();

            categories.CategoryName = txtName.Text;
            categories.Description = txtRich.Text;

            categories.EditCategory(idCategories);

            this.Controls.Clear();
            this.Controls.Add(new RegistryScreen());
        }
    }
}
