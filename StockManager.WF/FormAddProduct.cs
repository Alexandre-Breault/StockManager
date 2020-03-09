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
        public static string _ConnectionString = "Server=localhost;Database=StockManager;Password=Sql2019;User ID=sa;";
        public FormAddProduct()
        {
            InitializeComponent();
            ForceRefreshList();
        }

        public void ForceRefreshList()
        {
            // TODO: cette ligne de code charge les données dans la table 'stockManagerDataSetCategory.ProductCategory'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productCategoryTableAdapter.Fill(this.stockManagerDataSetProductCategory.ProductCategory);

        }
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
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
            ForceRefreshList();
        }
    }
}
