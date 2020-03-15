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
    public partial class FormManageEntryStock : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<Product> _Product = new List<Product>();
        public static List<StockMovement> _StockMovement = new List<StockMovement>();
        public FormManageEntryStock()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetProduct(sqlConnection);
            }
            InitializeComponent();
            comboBoxProduct.DataSource = _Product;
            ForceRefreshCombox();
        }
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
        private void buttonCloseManageEntryStock_Click(object sender, EventArgs e)
        {
            _Product.Clear();
            Close();
        }
        /// <summary>
        /// Rafraîchit la combox qui contient les noms des produits
        /// </summary>
        public void ForceRefreshCombox()
        {
            int selectedIndex = comboBoxProduct.SelectedIndex;
            comboBoxProduct.DataSource = null;
            comboBoxProduct.DataSource = _Product;
            comboBoxProduct.DisplayMember = nameof(Product.NameProduct);
            comboBoxProduct.ValueMember = nameof(Product.Identifier);
            comboBoxProduct.SelectedIndex = selectedIndex;
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                //Insert la date, le code de l'employée et si c'est une entrée dans le stock
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"INSERT INTO StockMovement([Date],[EmployeeCode],[IsStockEntry]) VALUES (@Date,@EmployeeCode,@IsStockEntry)";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("Date", dateTimePickerProduct.Value);
                    sqlCommand.Parameters.AddWithValue("EmployeeCode", textBoxCodeEmployee.Text);
                    sqlCommand.Parameters.AddWithValue("IsStockEntry", "1");
                    sqlCommand.ExecuteNonQuery();
                }
                //Récupère l'identifiant de la table Stockmovement 
                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    int stock = 0;
                    //On préciser le texte de la commande
                    command.CommandText = "SELECT Identifier FROM Stockmovement";
                    //On exécute la requête et on obtient un SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Tant qu'il y a des résultats, on passe au suivant
                        while (reader.Read())
                        {
                            StockMovement stockMovement = new StockMovement();
                            _StockMovement.Add(stockMovement);
                            stockMovement.Identifier = reader.GetInt32(0); //Lecture d'un entier
                            stock = stockMovement.Identifier;
                        }
                    }
                    //Insert l'identifiant du produit ,l'identifiant du mouvement et la quantité
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        // Requête exécutée
                        sqlCommand.CommandText = $"INSERT INTO StockMovementProduct([IdentifierProduct],[IdentifierStockMovement],[Quantity]) VALUES (@IdentifierProduct,@IdentifierStockMovement,@Quantity)";
                        //Paramètre de notre 
                        sqlCommand.Parameters.AddWithValue("IdentifierProduct", comboBoxProduct.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("IdentifierStockMovement", stock);
                        sqlCommand.Parameters.AddWithValue("Quantity", textBoxQuantity.Text);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
