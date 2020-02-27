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
    public partial class FormDelCategory : Form
    {
        public static string _ConnectionString = "Server=localhost;Database=StockManager;User Id=sa;Password=Sql2019;";
        public FormDelCategory()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
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
        }

    }
}
