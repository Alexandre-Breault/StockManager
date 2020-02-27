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
        public FormAddCategory()
        {
            InitializeComponent();
            listBoxCategory.DataSource = _ProductCategories;
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
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"SELECT Identifier, Label from ProductCategory";
                    //Paramètre de notre 
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        //Tant qu'il y a des résultats, on passe au suivant
                        while (reader.Read())
                        {
                            ProductCategory productCategory = new ProductCategory();
                            productCategory.Identifier = reader.GetInt32(0);
                            if (reader.IsDBNull(1) == false)
                            {
                                productCategory.Label = reader.GetString(1);
                            }
                        }
                        if (listBoxCategory.SelectedItem is ProductCategory)
                        {
                            textBoxAddCategory.Text = ((ProductCategory)listBoxCategory.SelectedItem).Label;
                        }
                    }
                }
            }
            ForceRefreshList();
        }
        public void ForceRefreshList()
        {
            int selectedIndex = listBoxCategory.SelectedIndex;
            listBoxCategory.DataSource = null;
            listBoxCategory.DataSource = _ProductCategories;
            listBoxCategory.DisplayMember = nameof(ProductCategory.Label);
            listBoxCategory.ValueMember = nameof(ProductCategory.Label);
            listBoxCategory.SelectedIndex = selectedIndex;
        }
    }
}
