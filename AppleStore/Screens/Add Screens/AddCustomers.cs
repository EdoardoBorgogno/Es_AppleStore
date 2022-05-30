using AppleStore.Models;
using AppleStore.Screens;
using AppleStore.Screens.Registry;
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

namespace AppleStore.Screens.Add_Screens
{
    //
    // Add customer
    //
    public partial class AddCustomers : UserControl
    {
        //Constructor
        public AddCustomers()
        {
            InitializeComponent();
        }

        // On load
        private void AddCustomers_Load(object sender, EventArgs e)
        {
            
        }

        // On click add customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if all fields are filled
            if (txtName.Text != "" && txtSurname.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" && cmbSex.SelectedIndex != -1 && txtCity.Text != "" && txtIndirizzo.Text != "" && txtcState.Text != "")
            {
                Customers customer = new Customers(txtName.Text, txtSurname.Text, txtTelefono.Text, txtEmail.Text, cmbSex.SelectedItem.ToString(), dateBirth.Value, txtCity.Text, txtIndirizzo.Text, txtcState.Text);

                customer.AddCustomer();
                
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
