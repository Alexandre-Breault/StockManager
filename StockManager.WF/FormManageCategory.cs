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
    public partial class FormManageCategory : Form
    {
        public FormManageCategory()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formAddCategory.ShowDialog();
        }

        private void buttonDelCategory_Click(object sender, EventArgs e)
        {
            FormDelCategory formDelCategory = new FormDelCategory();
            //Préférez les ShowDialogs pour éviter des conflits de données etc...
            formDelCategory.ShowDialog();
        }
    }
}
