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
    public partial class FormModProd : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<ProductCategory> _Category = new List<ProductCategory>();
        public static List<Product> _Product = new List<Product>();
        public FormModProd()
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
                command.CommandText = "SELECT Identifier, Nom, Price, StoredQuantity  FROM Product";
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
                            product.PriceProduct = reader.GetDecimal(2);  //Lecture d'une chaîne
                        }
                        if (!reader.IsDBNull(3))
                        {
                            product.StoredQuantity = reader.GetDecimal(3);  //Lecture d'une chaîne
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
        /// <summary>
        /// Rafraîchit la listbox
        /// </summary>
        public void ForceRefreshList()
        {
            int selectedIndex = listBox1.SelectedIndex;
            listBox1.DataSource = null;
            listBox1.DataSource = _Product;
            listBox1.DisplayMember = nameof(Product.NameProduct);
            listBox1.ValueMember = nameof(Product.Identifier);
            listBox1.SelectedIndex = selectedIndex;
        }
        private void buttonCloseProduct_Click(object sender, EventArgs e)
        {
            comboBoxCatProd.DataSource = null;
            _Category.Clear();
            Close();
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"UPDATE Product SET " + $"[Nom] = @Nom " + $"[Price] = @Price " + $"[IdentifiantProductCategory] = @IdentifiantProductCategory " + $"[StoredQuantity] = @StoredQuantity " + $"WHERE [Identifier] = @Identifier ";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("Nom", textBoxNameProd.Text);
                    sqlCommand.Parameters.AddWithValue("Price", textBoxPriceProd.Text);
                    sqlCommand.Parameters.AddWithValue("IdentifiantProductCategory", comboBoxCatProd.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("StoredQuantity", textBoxQuantityStored.Text);
                    sqlCommand.Parameters.AddWithValue("Identifier", listBox1.SelectedValue);
                    sqlCommand.ExecuteNonQuery();
                    textBoxNameProd.Clear();
                    textBoxPriceProd.Clear();
                    textBoxQuantityStored.Clear();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product)
            {
                //ajoute dans la textbox l'article sélection dans la liste
                textBoxNameProd.Text = ((Product)listBox1.SelectedItem).NameProduct;
                textBoxPriceProd.Text = ((Product)listBox1.SelectedItem).PriceProduct.ToString();
                textBoxQuantityStored.Text = ((Product)listBox1.SelectedItem).StoredQuantity.ToString();
            }

        }
    }
}
