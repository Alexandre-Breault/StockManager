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
    public partial class FormAddProduct : Form
    {
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;integrated security=True;";
        public static List<ProductCategory> _ProductCategory = new List<ProductCategory>();

        public FormAddProduct(List<ProductCategory> categories)
        {
            _ProductCategory = categories;
            InitializeComponent();
            comboBoxCatProd.DataSource = _ProductCategory;
        }
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            ProductAdd();
        }
        /// <summary>
        /// Insert un produit dans la table produit avec un nom, une référence , un prix ,une description , un identifiant d'une catégorie et la quantité stockée
        /// </summary>
        private void ProductAdd()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // Requête exécutée
                    sqlCommand.CommandText = $"INSERT INTO Product([Nom],[Reference],[Price],[Description],[IdentifierProductCategory],[StoredQuantity]) VALUES (@Nom , @Reference , @Price , @Description , @IdentifiantProductCategory , @StoredQuantity)";
                    //Paramètre de notre 
                    sqlCommand.Parameters.AddWithValue("Nom", textBoxNameProd.Text);
                    sqlCommand.Parameters.AddWithValue("Reference", textBoxRefProd.Text);
                    sqlCommand.Parameters.AddWithValue("Price", textBoxPriceProd.Text);
                    sqlCommand.Parameters.AddWithValue("IdentifiantProductCategory", comboBoxCatProd.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("Description", textBoxDescProd.Text);
                    sqlCommand.Parameters.AddWithValue("StoredQuantity", textBoxQuantityStored.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxNameProd.Clear();
                    textBoxRefProd.Clear();
                    textBoxPriceProd.Clear();
                    textBoxDescProd.Clear();
                    textBoxQuantityStored.Clear();
                }
            }
        }

        private void buttonCloseProduct_Click(object sender, EventArgs e)
        {
            _ProductCategory.Clear();
            Close();
        }
    }
}
