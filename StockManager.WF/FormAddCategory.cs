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
    public partial class FormAddCategory : Form
    {

        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<ProductCategory> _Category = new List<ProductCategory>();
        public FormAddCategory()
        {
            //Récupération des données
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetCategory(sqlConnection);
            }
            InitializeComponent();
            listBox1.DataSource = _Category;
            ForceRefreshList();
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
        /// Boutton pour ajouter une catégorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"INSERT INTO ProductCategory([Label]) VALUES (@Label)";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("Label", textBoxAddCategory.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxAddCategory.Clear();
                }
            }
            RefreshListBox();
        }
        /// <summary>
        /// Bouton pour fermer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            _Category.Clear();
            Close();
        }
        /// <summary>
        /// Rafraîchit ce qu'il y a dans la liste
        /// </summary>
        public void ForceRefreshList()
        {
            int selectedIndex = listBox1.SelectedIndex;
            listBox1.DataSource = null;
            listBox1.DataSource = _Category;
            listBox1.DisplayMember = nameof(ProductCategory.Label);
            listBox1.ValueMember = nameof(ProductCategory.Label);
            listBox1.SelectedIndex = selectedIndex;
        }
        /// <summary>
        /// Rafraîchit ce qu'il y a dans la listebox1
        /// </summary>
        public void RefreshListBox()
        {
            _Category.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetCategory(sqlConnection);
            }

            ForceRefreshList();
        }
    }
}
