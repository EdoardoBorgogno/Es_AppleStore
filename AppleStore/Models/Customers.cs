using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Customers(string name, string surname, string phone, string email, string sex, DateTime dateBirth, string city, string address, string state)
        {
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

        //Constructor with parameters and id
        public Customers(int idCustomer, string name, string surname, string phone, string email, string sex, DateTime dateBirth, string city, string address, string state)
        {
            IdCustomer = idCustomer;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Sex = sex;
            DateBirth = dateBirth;
            City = city;
            Address = address;
            State = state;
        }

        //Get list of all customers
        public List<Customers> GetAllCustomers()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT * FROM Clienti WHERE Eliminato = 1";

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

        //Add customer
        public void AddCustomer()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = @"INSERT INTO Clienti (nomeCliente, cognomeCliente, telefonoCliente, emailCliente, genereCliente, DataNascitaCliente, CittaCliente, IndirizzoCliente, StatoCliente) " +
                         "VALUES ('" + name + "', '" + surname + "', '" + phone + "', '" + email + "', '" + sex + "', '" + dateBirth.ToString("yyyy/MM/dd") + "', '" + city + "', '" + address + "', '" + state + "')";
            
            try
            {
                adoNetSQL.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'inserimento dati cliente");
            }
        }

        //Delete customer
        public void deleteCustomer(int idCustomer)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = @"UPDATE Clienti SET Eliminato = 1 WHERE IdCliente = " + idCustomer;

            try
            {
                adoNetSQL.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella cancellazione cliente");
            }
        }

        //Get customers from id
        public void getCustomerFromId(int idCustomer)
        {
            // Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = @"SELECT * FROM Clienti WHERE IdCliente = " + idCustomer;

            try
            {
                DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                IdCustomer = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                Name = dt.Rows[0].ItemArray[1].ToString();
                Surname = dt.Rows[0].ItemArray[2].ToString();
                Email = dt.Rows[0].ItemArray[3].ToString();
                Phone = dt.Rows[0].ItemArray[4].ToString();
                Sex = dt.Rows[0].ItemArray[5].ToString();
                DateBirth = Convert.ToDateTime(dt.Rows[0].ItemArray[6]);
                City = dt.Rows[0].ItemArray[7].ToString();
                State = dt.Rows[0].ItemArray[8].ToString();
                Address = dt.Rows[0].ItemArray[9].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore");
            }
        }

        //Get list for datagrid
        public DataTable GetCustomersForDataGrid()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT IdCliente as Id, nomeCliente as Nome, cognomeCliente as Cognome, emailCliente as Email FROM Clienti WHERE Eliminato = 0";

            //Execute query
            DataTable customers = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            return customers;
        }
    
        //Edit customers
        public void editCustomers(int idCustomer)
        {
            // Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = @"UPDATE Clienti 
                         SET nomeCliente = '" + name + "', cognomeCliente = '" + surname + "'," +
                         "telefonoCliente = '" + phone + "', emailCliente = '" + email + "', genereCliente = '" + sex + 
                         "', DataNascitaCliente = '" + dateBirth.ToString("yyyy/MM/dd") + "', CittaCliente = '" + city + "', StatoCliente = '" + state + "', IndirizzoCliente = '" + address + "' " +
                         "WHERE IdCliente = " + idCustomer + ";";

            try
            {
                adoNetSQL.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore");
            }
        }
    }
}
