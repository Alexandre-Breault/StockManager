using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADO.Net (connecteur SQL Server)
using StockManager.WF.Model;

namespace StockManager.WF
{
    public partial class FormAddProduct : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<ProductCategory> _Category = new List<ProductCategory>();
        public static List<Product> _Product = new List<Product>();

        public FormAddProduct()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetProduct(sqlConnection);
                GetCategory(sqlConnection);
            }
            InitializeComponent();
            comboBoxCatProd.DataSource = _Category;
            ForceRefreshCombox();
        }
        /// <summary>
        /// Récupère dans la table produit l'identifiant , le nom , la référence
        /// </summary>
        /// <param name="sqlConnection">String de connection à la base de donnée</param>
        public void GetProduct(SqlConnection sqlConnection)
        {
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                //On préciser le texte de la commande
                command.CommandText = "SELECT Identifier, Nom , Reference FROM Product";
                //On exécute la requête et on obtient un SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Tant qu'il y a des résultats, on passe au suivant
                    while (reader.Read())
                    {
                        Product product = new Product();
                        _Product.Add(product);
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
                    }
                }
            }
        }
        /// <summary>
        /// Récupére les catégories dans la base de donnée et stocke dans la liste _Category
        /// </summary>
        /// <param name="sqlConnection">Connection SQL</param>
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
                        _Category.Add(productCategory);
                        //0 : Identifier
                        //1 : Label
                        productCategory.Identifier = reader.GetInt32(0); //Lecture d'un entier
                        //Pour les champs NULL, il faut tester avant avec IsDBNull()
                        if (reader.IsDBNull(1) == false)
                        {
                            productCategory.Label = reader.GetString(1);  //Lecture d'une chaîne
                        }
                        //Console.WriteLine($"[{contactType.Identifier}] : {contactType.Label}");
                    }
                }
            }
        }
        /// <summary>
        /// Rafraîchit ce qu'il y a dans la combobox
        /// </summary>
        public void ForceRefreshCombox()
        {
            int selectedIndex = comboBoxCatProd.SelectedIndex;
            comboBoxCatProd.DataSource = null;
            comboBoxCatProd.DataSource = _Category;
            comboBoxCatProd.DisplayMember = nameof(ProductCategory.Label);
            comboBoxCatProd.ValueMember = nameof(ProductCategory.Identifier);
            comboBoxCatProd.SelectedIndex = selectedIndex;
        }
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            ProductAdd();
        }
        /// <summary>
        /// Insert un produit dans la table produit avec un nom, une référence , un prix ,une description , un identifiant d'une catégorie et la quantité stockée
        /// </summary>
        private void ProductAdd()
        {
            if (!_Product.Exists(product => (product.NameProduct==textBoxNameProd.Text)))
            {
                using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
                {
                    sqlConnection.Open(); //On ouvre la connexion

                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        // Requête exécutée
                        sqlCommand.CommandText = $"INSERT INTO Product([Nom],[Reference],[Price],[Description],[IdentifierProductCategory],[StoredQuantity]) VALUES (@Nom , @Reference , @Price , @Description , @IdentifiantProductCategory , @StoredQuantity)";
                        //Paramètre de notre 
                        sqlCommand.Parameters.AddWithValue("Nom", textBoxNameProd.Text);
                        sqlCommand.Parameters.AddWithValue("Reference", textBoxRefProd.Text);
                        sqlCommand.Parameters.AddWithValue("Price", textBoxPriceProd.Text);
                        sqlCommand.Parameters.AddWithValue("IdentifiantProductCategory", comboBoxCatProd.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("Description", textBoxDescProd.Text);
                        sqlCommand.Parameters.AddWithValue("StoredQuantity", textBoxQuantityStored.Text);
                        sqlCommand.ExecuteNonQuery();
                        textBoxNameProd.Clear();
                        textBoxRefProd.Clear();
                        textBoxPriceProd.Clear();
                        textBoxDescProd.Clear();
                        textBoxQuantityStored.Clear();
                    }
                }
            }
            else
            {
                errorProviderAddProduct.SetError(textBoxNameProd,"Le nom de produit existe déjà");
            }
            
        }

        private void buttonCloseProduct_Click(object sender, EventArgs e)
        {
            comboBoxCatProd.DataSource = null;
            _Category.Clear();
            Close();
        }
    }
}
