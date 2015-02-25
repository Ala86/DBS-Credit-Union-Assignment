using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AssignmentWeek1
{
    public partial class ViewTransactionHistory : Form
    {
        public ViewTransactionHistory()
        {
            InitializeComponent();
        }

        private void ViewTransactionHistory_Load(object sender, EventArgs e)
        {
            DisplayTransactions();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplayIntTranfers_Click(object sender, EventArgs e)
        {
            DisplayIntTransfers();
        }
        
        private void DisplayTransactions()
        {
            Methods meth = new Methods();

           DataSet ds= meth.DisplayTransactions();

           BindingSource bs = new BindingSource();

           bs.DataSource = ds.Tables[0];
           dgvTransactionDisplay.DataSource = bs;
        }

        private void DisplayIntTransfers()
        {
            Methods meth = new Methods();

            DataSet ds = meth.DisplayIntTransfers();

            BindingSource bs = new BindingSource();

            bs.DataSource = ds.Tables[0];
            dgvTransactionDisplay.DataSource = bs;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            DisplayTransactions();
        }
    }
}
