using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace AssignmentWeek1
{
    public partial class Withdrawal : Form
    {
        public Account Account { get; set; }

        public delegate void WithdrawalEv();

        public event WithdrawalEv OnWithdrawalMade;

        public Withdrawal()
        {
            InitializeComponent();
        }

        public Withdrawal(int accountNum)
        {
            InitializeComponent();

            cntlWithdrawal.txtAccountNo.Text = accountNum.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Methods meth = new Methods();

            Transaction trans = new Transaction();

            int amount;
            int balance;
            string message;

            Account = cntlWithdrawal.AccountDisplay;

            trans.Actor = Account;
            trans.TransactionType = "Withdrawal";

            amount = int.Parse(cntlWithdrawal.txtAmount.Text);
            //set the amount to negative number so the number will be subtracted in the method UpdateAccountBalance()

            amount = amount * -1;

            trans.Amount = amount;
            trans.TimeStamp = DateTime.Now;
            if (meth.UpdateAccountBalance(amount, Account))
            {
                balance = Account.Balance;
                message = String.Format("This withdrawal has be successful. New Balance is {0}c", balance);
                OnWithdrawalMade();
                meth.TransactionStore(trans);
                MessageBox.Show(message);
                Close();
            }
        }
    }
}
