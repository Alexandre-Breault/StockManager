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
using StockManager.WF.Model;


namespace StockManager.WF
{
    public partial class FormDelCategory : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<ProductCategory> _Category = new List<ProductCategory>();

        public FormDelCategory()
        {
            //Récupération des données
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetCategory(sqlConnection);
            }
            InitializeComponent();
            listBoxDelCategory.DataSource = _Category;
            ForceRefreshList();

        }
        /// <summary>
        /// Récupére dans la table ProductCategory l'Identifiant et le label
        /// </summary>
        /// <param name="sqlConnection"></param>
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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            _Category.Clear();
            Close();
        }

        private void buttonDelCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"DELETE FROM ProductCategory WHERE Label = @Label";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("Label", textBoxDelCategory.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxDelCategory.Clear();
                }
            }
            ForceDeleteList();
        }
        /// <summary>
        /// Raifraichi ce qu'il y a dans la liste
        /// </summary>
        public void ForceRefreshList()
        {
            int selectedIndex = listBoxDelCategory.SelectedIndex;
            listBoxDelCategory.DataSource = null;
            listBoxDelCategory.DataSource = _Category;
            listBoxDelCategory.DisplayMember = nameof(ProductCategory.Label);
            listBoxDelCategory.ValueMember = nameof(ProductCategory.Label);
            listBoxDelCategory.SelectedIndex = selectedIndex;

        }
        /// <summary>
        /// Supprime un article dans la liste
        /// </summary>
        private void ForceDeleteList()
        {
            _Category.Clear();
            listBoxDelCategory.DataSource = null;
            listBoxDelCategory.Items.Remove(listBoxDelCategory.SelectedItem);
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetCategory(sqlConnection);
            }
            ForceRefreshList();
        }
        private void listBoxDelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDelCategory.SelectedItem is ProductCategory)
            {
                //ajoute dans la textbox l'article sélection dans la liste
                textBoxDelCategory.Text = ((ProductCategory)listBoxDelCategory.SelectedItem).Label;
            }
        }
    }
}
