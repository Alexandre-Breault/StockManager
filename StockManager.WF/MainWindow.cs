using StockManager.WF.Model;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory();
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formManageCategory.ShowDialog();
        }

        private void buttonManageProduct_Click(object sender, EventArgs e)
        {
            FormManageProduct formManageProduct = new FormManageProduct();
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formManageProduct.ShowDialog();
        }

        private void buttonManageEntryStock_Click(object sender, EventArgs e)
        {
            FormManageEntryStock formManageEntryStock = new FormManageEntryStock();
            formManageEntryStock.ShowDialog();
        }

        private void buttonManageExitStock_Click(object sender, EventArgs e)
        {
            FormManageExitStock formManageExitStock = new FormManageExitStock();
            formManageExitStock.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
