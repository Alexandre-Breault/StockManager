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
    public partial class FormManageCategory : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<ProductCategory> _ProductCategory = new List<ProductCategory>();
               
        public FormManageCategory()
        {
            InitializeComponent();
            //Récupération des données
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                GetCategory(sqlConnection);
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
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory(_ProductCategory);
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formAddCategory.ShowDialog();
        }

        private void buttonDelCategory_Click(object sender, EventArgs e)
        {
            FormDelCategory formDelCategory = new FormDelCategory(_ProductCategory);
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formDelCategory.ShowDialog();
        }
        
    }
}
