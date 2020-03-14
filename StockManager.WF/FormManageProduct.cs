using StockManager.WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.WF
{
    public partial class FormManageProduct : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<Product> _Product = new List<Product>();
        public static List<ProductCategory> _ProductCategory = new List<ProductCategory>();

        public FormManageProduct()
        {
            InitializeComponent();
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetCategory(sqlConnection);
                GetProduct(sqlConnection);
            }
        }

        private void buttonCloseManageProduct_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct(_ProductCategory);
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formAddProduct.ShowDialog();
        }

        private void buttonDelProduct_Click(object sender, EventArgs e)
        {
            FormDelProduct formDelProduct = new FormDelProduct(_Product);
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formDelProduct.ShowDialog();
        }
        private void GetCategory(SqlConnection sqlConnection)
        {
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                //On préciser le texte de la commande
                command.CommandText = "SELECT Identifier, Label FROM ProductCategory";

                //On exécute la requête et on obtient un SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Tant qu'il y a des résultats, on passe au suivant
                    while (reader.Read())
                    {
                        ProductCategory productCategory = new ProductCategory();
                        _ProductCategory.Add(productCategory);
                        //0 : Identifier
                        //1 : Label

                        productCategory.Identifier = reader.GetInt32(0); //Lecture d'un entier
                        //Pour les champs NULL, il faut tester avant avec IsDBNull()
                        if (reader.IsDBNull(1) == false)
                        {
                            productCategory.Label = reader.GetString(1);  //Lecture d'une chaîne
                        }
                    }
                }
            }
        }
        private void GetProduct(SqlConnection sqlConnection)
        {
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                //On préciser le texte de la commande
                command.CommandText = "SELECT Identifier, Nom , Reference , IdentifierProductCategory  FROM Product";

                //On exécute la requête et on obtient un SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Tant qu'il y a des résultats, on passe au suivant
                    while (reader.Read())
                    {
                        Product product = new Product();
                        _Product.Add(product);
                        //0 : Identifier
                        //1 : Label

                        product.Identifier = reader.GetInt32(0); //Lecture d'un entier
                        //Pour les champs NULL, il faut tester avant avec IsDBNull()
                        if (!reader.IsDBNull(1))
                        {
                            product.NameProduct = reader.GetString(1);  //Lecture d'une chaîne
                        }
                        if (!reader.IsDBNull(2))
                        {
                            product.ReferenceProduct = reader.GetString(2);  //Lecture d'une chaîne
                        }
                        if (!reader.IsDBNull(3))
                        {
                            product.IdentifierProductCategory = _ProductCategory
                                .First(productCategory => productCategory.Identifier == reader.GetInt32(3));
                        }
                    }
                }
            }
        }
    }
}
