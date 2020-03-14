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
        public static List<ProductCategory> _ProductCategory = new List<ProductCategory>();


        /// <summary>
        /// On récupere les catégories
        /// </summary>
        /// <param name="categories"></param>
        public FormAddCategory(List<ProductCategory> categories)
        {
            _ProductCategory = categories;
            InitializeComponent();
            listBox1.DataSource = _ProductCategory;
            ForceRefreshList();
        }

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
            ForceRefreshList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ForceRefreshList()
        {
            int selectedIndex = listBox1.SelectedIndex;
            listBox1.DataSource = null;
            listBox1.DataSource = _ProductCategory;
            listBox1.DisplayMember = nameof(ProductCategory.Label);
            listBox1.ValueMember = nameof(ProductCategory.Label);
            listBox1.SelectedIndex = selectedIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ProductCategory)
            {
                textBoxAddCategory.Text = ((ProductCategory)listBox1.SelectedItem).Label;
            }
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
                        //On passe dans la boucle pour chaque ligne
                        //GetInt32, GetString et IsDBNull attendent en paramètre
                        //Le numéro d'index de la colonne ici :
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
    }
}
