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

        public static string _ConnectionString = "Server=localhost;Database=StockManager;User Id=sa;Password=Sql2019;";

        public FormAddCategory()
        {
            InitializeComponent();
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
            // TODO: cette ligne de code charge les données dans la table 'stockManagerDataSetCategory.ProductCategory'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productCategoryTableAdapter.Fill(this.stockManagerDataSetCategory.ProductCategory);

        }

    }
}
