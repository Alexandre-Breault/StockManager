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
    public partial class FormDelProduct : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<Product> _Product = new List<Product>();
        public FormDelProduct()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetProduct(sqlConnection);
            }
            InitializeComponent();
            listBoxProduct.DataSource = _Product;
            ForceRefreshList();
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
        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedItem is Product)
            {
                textBox1.Text = ((Product)listBoxProduct.SelectedItem).NameProduct;
            }
        }
        /// <summary>
        /// Rafraîchit la listbox
        /// </summary>
        public void ForceRefreshList()
        {
            int selectedIndex = listBoxProduct.SelectedIndex;
            listBoxProduct.DataSource = null;
            listBoxProduct.DataSource = _Product;
            listBoxProduct.DisplayMember = nameof(Product.NameProduct);
            listBoxProduct.ValueMember = nameof(Product.NameProduct);
            listBoxProduct.SelectedIndex = selectedIndex;
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"DELETE FROM Product WHERE Nom = @nom";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("nom", textBox1.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBox1.Clear();
                }
                ForceDeleteList();
            }
        }
        private void buttonCloseProd_Click(object sender, EventArgs e)
        {
            _Product.Clear();
            Close();
        }
        /// <summary>
        /// Supprime un article de la listbox
        /// </summary>
        private void ForceDeleteList()
        {
            _Product.Clear();
            listBoxProduct.DataSource = null;
            listBoxProduct.Items.Remove(listBoxProduct.SelectedItem);
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetProduct(sqlConnection);
            }
            ForceRefreshList();
        }
    }
}
