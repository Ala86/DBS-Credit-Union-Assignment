using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace ClassLibrary1
{
    public partial class AccountManagementControl : UserControl
    {
        public bool Deposit { get; set; }
        public bool Withdrawal { get; set; }

        public Account AccountDisplay { get; set; }


        public AccountManagementControl()
        {
            InitializeComponent();
        }

        private void AccountManagementControl_Load(object sender, EventArgs e)
        {
            if (Deposit)
            {
                lblAmount.Text = "Amount to Deposit:";
            }
            if (Withdrawal)
            {
                lblAmount.Text = "Amount to Withdraw";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateUserControl();
           
        }

        private void PopulateUserControl()
        {
            Methods meth = new Methods();
            Account acc = new Account();
            acc.AccountNo = int.Parse(txtAccountNo.Text);


            meth.PopulateDetails(acc);
            AccountDisplay = acc;

            txtAccountNo.Text = AccountDisplay.AccountNo.ToString();
            txtName.Text = AccountDisplay.Person.FName + " " + AccountDisplay.Person.LName;
            txtCustomerId.Text = AccountDisplay.Person.CustomerId.ToString();
            txtSortCode.Text = AccountDisplay.SortCode.ToString();
            txtBalance.Text = AccountDisplay.Balance.ToString();
        }

    }
}
