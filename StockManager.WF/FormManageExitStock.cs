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
    public partial class FormManageExitStock : Form
    {
        public FormManageExitStock()
        {
            InitializeComponent();
        }

        private void buttonCloseManageExitStock_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
