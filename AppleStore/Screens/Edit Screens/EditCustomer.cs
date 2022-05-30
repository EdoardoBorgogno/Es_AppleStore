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
    //
    // Edit customer control
    //
    public partial class EditCustomer : UserControl
    {
        int idCustomers;

        //Constructor
        public EditCustomer(int id)
        {
            InitializeComponent();

            idCustomers = id;

            Customers customers = new Customers();
            customers.getCustomerFromId(id);

            txtName.Text = customers.Name;
            txtSurname.Text = customers.Surname;
            txtEmail.Text = customers.Email;
            txtTelefono.Text = customers.Phone;
            txtIndirizzo.Text = customers.Address;
            txtCity.Text = customers.City;
            txtcState.Text = customers.State;
            dateBirth.Value = customers.DateBirth;
            cmbSex.SelectedItem = customers.Sex;
        }

        //On screen load
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            
        }

        //On edit button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            customers.Name = txtName.Text;
            customers.Surname = txtSurname.Text;
            customers.Email = txtEmail.Text;
            customers.Phone = txtTelefono.Text;
            customers.Address = txtIndirizzo.Text;
            customers.City = txtCity.Text;
            customers.State = txtcState.Text;
            customers.DateBirth = dateBirth.Value;
            customers.Sex = cmbSex.SelectedItem.ToString();

            customers.editCustomers(idCustomers);

            this.Controls.Clear();
            this.Controls.Add(new RegistryScreen());
        }
    }
}
