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
            buttonManageProduct.BackColor = Color.FromArgb(180, 180, 180);
            formManageProduct.ShowDialog();
            buttonManageProduct.BackColor = DefaultBackColor;

        }

        private void buttonManageEntryStock_Click(object sender, EventArgs e)
        {
            FormManageEntryStock formManageEntryStock = new FormManageEntryStock();
            buttonManageEntryStock.BackColor = Color.FromArgb(180, 180, 180);
            formManageEntryStock.ShowDialog();
            buttonManageEntryStock.BackColor = DefaultBackColor;

        }

        private void buttonManageExitStock_Click(object sender, EventArgs e)
        {
            FormManageExitStock formManageExitStock = new FormManageExitStock();
            buttonManageExitStock.BackColor = Color.FromArgb(180, 180, 180);
            formManageExitStock.ShowDialog();
            buttonManageExitStock.BackColor = DefaultBackColor;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonManageCategory_MouseEnter(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageCategory.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void buttonManageCategory_MouseLeave(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageCategory.BackColor = Color.Transparent;
        }

        private void buttonManageProduct_MouseEnter(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageProduct.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void buttonManageProduct_MouseLeave(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageProduct.BackColor = Color.Transparent;
        }

        private void buttonManageEntryStock_MouseEnter(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageEntryStock.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void buttonManageEntryStock_MouseLeave(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageEntryStock.BackColor = Color.Transparent;
        }

        private void buttonManageExitStock_MouseEnter(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageExitStock.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void buttonManageExitStock_MouseLeave(object sender, EventArgs e)
        {
            //couleur du button modifié lorsque qu'on survole le button avec la souris
            buttonManageExitStock.BackColor = Color.Transparent;
        }

    }
}
