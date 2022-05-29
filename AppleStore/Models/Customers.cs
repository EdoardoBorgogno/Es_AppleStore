using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleStore.Models
{
    //
    // Customer class
    //
    internal class Customers
    {
        //Fiedls
        private int idCustomer;
        private string name;
        private string surname;
        private string phone;
        private string email;
        private string sex;
        private DateTime dateBirth;
        private string city;
        private string address;
        private string state;

        //Properties
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public string State { get => state; set => state = value; }

        //Constructor with parameters
        public Customers(int idCustomer, string name, string surname, string phone, string email, string sex, DateTime dateBirth, string city, string address, string state)
        {
            this.idCustomer = idCustomer;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.email = email;
            this.sex = sex;
            this.dateBirth = dateBirth;
            this.city = city;
            this.address = address;
            this.state = state;
        }

        // Constructor without parameters
        public Customers()
        {
            
        }

        //Get list of all customers
        public List<Customers> GetAllCustomers()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT * FROM Clienti";

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Create list of products
            List<Customers> customersList = new List<Customers>();

            //Add products to list
            foreach (DataRow row in dt.Rows)
            {
                customersList.Add(new Customers(
                    Convert.ToInt32(row["IdCliente"]),
                    row["nomeCliente"].ToString(),
                    row["cognomeCliente"].ToString(),
                    row["telefonoCliente"].ToString(),
                    row["emailCliente"].ToString(),
                    row["genereCliente"].ToString(),
                    Convert.ToDateTime(row["DataNascitaCliente"]),
                    row["CittaCliente"].ToString(),
                    row["IndirizzoCliente"].ToString(),
                    row["StatoCliente"].ToString()
                ));
            }

            return customersList;
        }

        //Get list for datagrid
        public DataTable GetCustomersForDataGrid()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT nomeCliente as Nome, cognomeCliente as Cognome, emailCliente as Email FROM Clienti";

            //Execute query
            DataTable customers = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            return customers;
        }
    }
}
