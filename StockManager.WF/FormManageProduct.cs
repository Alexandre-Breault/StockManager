using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.WF
{
    public partial class FormManageProduct : Form
    {
        public FormManageProduct()
        {
            InitializeComponent();
        }

        private void buttonCloseManageProduct_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formAddProduct.ShowDialog();
        }

        private void buttonDelProduct_Click(object sender, EventArgs e)
        {
            FormDelProduct formDelProduct = new FormDelProduct();
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formDelProduct.ShowDialog();
        }
    }
}
