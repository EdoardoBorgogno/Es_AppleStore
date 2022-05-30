using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Models
{
    //
    // Categories Class
    //

    class Categories
    {
        //Fields
        private int categoryID;
        private string categoryName;
        private string description;
        private string picture;

        // Properties
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        // Constructor
        public Categories(int categoryID, string categoryName, string description, string picture)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.description = description;
            this.picture = picture;
        }

        //Constructor without parameters
        public Categories()
        {
            
        }

        //Get all categories
        public List<Categories> GetAllCustomers()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT * FROM Categorie WHERE Eliminata = 0";

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Create list of products
            List<Categories> categoriesList = new List<Categories>();

            //Add products to list
            foreach (DataRow row in dt.Rows)
            {
                categoriesList.Add(
                    new Categories(
                        Convert.ToInt32(row["IdCategoria"]),
                        row["NomeCategorie"].ToString(),
                        row["DescrizioneCategoria"].ToString(),
                        row["ImmagineCategoria"].ToString()
                    )
                );
            }
            
            return categoriesList;
        }

        //Edit category
        public void EditCategory(int categoryId)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "UPDATE Categorie SET NomeCategoria = '" + CategoryName + "', DescrizioneCategoria = '" + Description + "'WHERE IdCategoria = " + categoryId;

            //Execute query
            adoNetSQL.eseguiNonQuery(sql, CommandType.Text);
        }

        //Get category by ID
        public Categories GetCategoriesFromId(int categoryID)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT NomeCategoria, DescrizioneCategoria FROM Categorie WHERE IdCategoria = " + categoryID;

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Create list of products
            Categories categories = new Categories();

            //Add products to list
            CategoryName = dt.Rows[0][0].ToString();
            Description = dt.Rows[0][1].ToString();

            return categories;
        }

        //Add category
        public void addCategory()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = @"INSERT INTO Categorie (NomeCategoria, DescrizioneCategoria) " +
                         "VALUES ('" + CategoryName + "', '" + Description + "')";

            try
            {
                adoNetSQL.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'inserimento dati categoria");
            }
        }

        //Delete Category
        public void deleteCategory(int idCategory)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "UPDATE Categorie SET Eliminata = 1 WHERE IdCategoria = " + idCategory;

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            sql = "UPDATE Prodotti SET Eliminato = 1 WHERE IdCategoria = " + idCategory;

            adoNetSQL.eseguiQuery(sql, CommandType.Text);
        }

        //Get list for datagrid
        public DataTable GetCategoriesForDataGrid()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT IdCategoria as Id, NomeCategoria as Nome, DescrizioneCategoria as Descrizione FROM Categorie WHERE Eliminata = 0";

            //Execute query
            DataTable customers = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            return customers;
        }
    }
}
