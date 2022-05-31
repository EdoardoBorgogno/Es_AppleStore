using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleStore.Models
{
    //Product class
    internal class Product
    {
        //Fields
        private int id;
        private int category;
        private string name;
        private string description;
        private string jsonDescription;
        private string image;
        private decimal price;

        //Properties
        public int Id 
        {
            get => id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id must be positive");
                }
                
                id = value;
            }
        }
        public int Category { 
            get => category;
            set
            {
                //Category id must be primary key in Categorie table
                string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

                adoNetSQL adoNetSQL = new adoNetSQL(pathDB);
                
                //create query
                string sql = "SELECT IdCategoria FROM Categorie";

                //execute query
                DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

                List<int> idCategoriesList = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("IdCategoria")).ToList();

                if (!idCategoriesList.Contains(value))
                {
                    throw new ArgumentException("Category id must be primary key in Categorie table");
                }

                category = value;
            }
        }
        public string Name { get => name; set => name = value; }
        public string Description {
            get => description;
            set
            {
                //Description must be less than 450 characters

                if (value.Length > 450)
                {
                    throw new ArgumentException("Description must be less than 450 characters");
                }
                
                description = value;
                
            }
        }
        public string JsonDescription {
            get => jsonDescription;
            set
            {
                //JsonDescription must be less than 50 characters
                
                if (value.Length > 50)
                {
                    throw new ArgumentException("JsonDescription must be less than 50 characters");
                }

                jsonDescription = value;
            }
        }
        public string Image { 
            get => image;
            set 
            {
                //Image must be less than 50 characters

                if (value.Length > 50)
                {
                    throw new ArgumentException("Image must be less than 50 characters");
                }

                image = value;
            }
        }
        public decimal Price { 
            get => price; 
            set
            {
                //Price must be positive
                
                if (value < 0)
                {
                    throw new ArgumentException("Price must be positive");
                }

                price = value;
            }
        }

        // Constructor with parameters
        public Product(int id, int category, string name, string description, string jsonDescription, string image, decimal price)
        {
            this.id = id;
            this.category = category;
            this.name = name;
            this.description = description;
            this.jsonDescription = jsonDescription;
            this.image = image;
            this.price = price;
        }

        //Constructor without parameters
        public Product()
        {
            
        }

        //Get list of all products
        public List<Product> GetAllProducts()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT * FROM Prodotti";

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            //Create list of products
            List<Product> productsList = new List<Product>();

            //Add products to list
            foreach (DataRow row in dt.Rows)
            {
                productsList.Add(new Product(
                    row.Field<int>("IdProdotto"),
                    row.Field<int>("IdCategoria"),
                    row.Field<string>("NomeProdotto"),
                    row.Field<string>("DescrizioneProdotto"),
                    row.Field<string>("DescrizioneLunga"),
                    row.Field<string>("ImmagineProdotto"),
                    row.Field<decimal>("PrezzoProdotto")
                ));
            }

            return productsList;
        }

        //Add Product
        public void AddProduct()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "INSERT INTO Prodotti (IdCategoria, NomeProdotto, DescrizioneProdotto, DescrizioneLunga, ImmagineProdotto, PrezzoProdotto) VALUES (" + category + ", '" + name + "', '" + description + "', '" + jsonDescription + "', '" + image + "', " + Price.ToString().Replace(',', '.') + ")";

            //Execute query
            adoNetSQL.eseguiNonQuery(sql, CommandType.Text);
        }

        //Delete Product
        public void DeleteProduct(int id)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "UPDATE Prodotti SET Eliminato = 1 WHERE IdProdotto = " + id;

            //Execute query
            adoNetSQL.eseguiNonQuery(sql, CommandType.Text);
        }

        //get product from id
        public void GetProductFromId(int id)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT IdProdotto, IdCategoria, NomeProdotto, DescrizioneProdotto, DescrizioneLunga, ImmagineProdotto, PrezzoProdotto FROM Prodotti WHERE IdProdotto = " + id;

            //Execute query
            DataTable dt = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            Id = Convert.ToInt32(dt.Rows[0][0]);
            Category = Convert.ToInt32(dt.Rows[0][1]);
            Name = dt.Rows[0][2].ToString();
            Description = dt.Rows[0][3].ToString();
            JsonDescription = dt.Rows[0][4].ToString();
            Image = dt.Rows[0][5].ToString();
            Price = Convert.ToDecimal(dt.Rows[0][6]);
            
        }

        //Edit product
        public void EditProduct(int id)
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "UPDATE Prodotti SET IdCategoria = " + category + ", NomeProdotto = '" + name + "', DescrizioneProdotto = '" + description + "', DescrizioneLunga = '" + jsonDescription + "', ImmagineProdotto = '" + image + "', PrezzoProdotto = " + Price.ToString().Replace(',', '.') + " WHERE IdProdotto = " + id;
            
            //Execute query
            adoNetSQL.eseguiNonQuery(sql, CommandType.Text);
        }

        //Get list for datagrid
        public DataTable GetProductsForDataGrid()
        {
            //Get path of database
            string pathDB = ConfigurationManager.AppSettings["appStartupPath"] + "\\" + "Applestore.mdf";

            //Create adoNetSQL object
            adoNetSQL adoNetSQL = new adoNetSQL(pathDB);

            //Create query
            string sql = "SELECT IdProdotto as Id, nomeProdotto as Nome, nomeCategoria as Categoria, prezzoProdotto as Prezzo FROM Prodotti INNER JOIN Categorie ON Categorie.IdCategoria = Prodotti.IdCategoria WHERE Eliminato = 0";

            //Execute query
            DataTable products = adoNetSQL.eseguiQuery(sql, CommandType.Text);

            return products;
        }
    }
}
