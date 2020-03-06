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

        static List<ProductCategory> _ProductCategories = new List<ProductCategory>();
        public static string _ConnectionString = "Server=localhost;Database=StockManager;User Id=sa;Password=Sql2019;";
        public string ProduitCategorieLabel = "";
        public FormAddCategory()
        {
            InitializeComponent();
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
        }

    }
}
