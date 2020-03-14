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
        public static List<ProductCategory> _ProductCategory = new List<ProductCategory>();

        public FormDelCategory(List<ProductCategory> categories)
        {
            _ProductCategory = categories;
            InitializeComponent();
            listBoxDelCategory.DataSource = _ProductCategory;
            ForceRefreshList();
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
        public void ForceRefreshList()
        {
            int selectedIndex = listBoxDelCategory.SelectedIndex;
            listBoxDelCategory.DataSource = null;
            listBoxDelCategory.DataSource = _ProductCategory;
            listBoxDelCategory.DisplayMember = nameof(ProductCategory.Label);
            listBoxDelCategory.ValueMember = nameof(ProductCategory.Label);
            listBoxDelCategory.SelectedIndex = selectedIndex;
        }

        private void listBoxDelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDelCategory.SelectedItem is ProductCategory)
            {
                textBoxDelCategory.Text = ((ProductCategory)listBoxDelCategory.SelectedItem).Label;
            }
        }
    }
}
