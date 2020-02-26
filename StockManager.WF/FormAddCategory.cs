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
    public partial class FormAddCategory : Form
    {
        public static string _ConnectionString = "Server=localhost;Database=AddressBook;User Id=sa;Password=Sql2019;";
        public FormAddCategory()
        {
            InitializeComponent();

        }
    }
}
