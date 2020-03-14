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
    public partial class FormDelProduct : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=AddressBook;integrated security=True;";
        public static List<Product> _Product = new List<Product>();

        public FormDelProduct(List<Product> products)
        {
            _Product = products;
            InitializeComponent();
            listBoxProduct.DataSource = _Product;
            ForceRefreshList();
        }
        private void listBoxDelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedItem is ProductCategory)
            {
                textBox1.Text = ((ProductCategory)listBoxProduct.SelectedItem).Label;
            }
        }
        public void ForceRefreshList()
        {
            int selectedIndex = listBoxProduct.SelectedIndex;
            listBoxProduct.DataSource = null;
            listBoxProduct.DataSource = _Product;
            listBoxProduct.DisplayMember = nameof(Product.NameProduct);
            listBoxProduct.ValueMember = nameof(Product.NameProduct);
            listBoxProduct.SelectedIndex = selectedIndex;
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Product productToDelete = new Product();
            ProductDelete(productToDelete);
        }
        private static void ProductDelete(Product product)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"DELETE FROM Product WHERE Identifier = @Identifier";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("nom", (object)product.Identifier ?? DBNull.Value);
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
