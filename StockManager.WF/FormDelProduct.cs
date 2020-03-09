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
        public static string _ConnectionString = "Server=localhost;Database=StockManager;User Id=sa;Password=Sql2019;";

        public FormDelProduct()
        {
            InitializeComponent();
        }

        private void FormDelProduct_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stockManagerDataSet.Product'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productTableAdapter.Fill(this.stockManagerDataSet.Product);

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"DELETE FROM Product WHERE nom = @nom";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("nom", dataGridViewProduct.CurrentCell);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
