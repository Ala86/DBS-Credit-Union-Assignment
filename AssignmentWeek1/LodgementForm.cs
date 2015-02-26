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
    public partial class LodgementForm : Form
    {
        // so this page has a property account, this is assigned by the find account button in the usercontrol

        public Account Account { get; set; }

        public delegate void LodgementEv();

        public event LodgementEv OnLodgementMade;

        public LodgementForm()
        {
            InitializeComponent();
        }

        public LodgementForm(int accountNum)
        {
            InitializeComponent();

            cntlLodgement.txtAccountNo.Text = accountNum.ToString();

            
        }

        private void btnLodge_Click(object sender, EventArgs e)
        {
            Methods meth = new Methods();
            Transaction trans = new Transaction();
            
            int amount;
            int balance;
            string message;
            //assigning the Account property to the account that usercontrol has found
            Account = cntlLodgement.AccountDisplay;
            trans.Actor = Account;
            trans.TransactionType = "Deposit";
            
           
            amount = int.Parse(cntlLodgement.txtAmount.Text);
            trans.Amount = amount;
            trans.TimeStamp = DateTime.Now;
            //this method takes an account and an amount, then adds the amount to the Account.Balance in the BLL

            if(meth.UpdateAccountBalance(amount, Account))
            {
                balance = Account.Balance;
                message = String.Format("This lodgement has be successful. New Balance is {0}c", balance);
                OnLodgementMade();
                meth.TransactionStore(trans);
                MessageBox.Show(message);
                Close();
            }
            


        }

        private void cntlLodgement_Load(object sender, EventArgs e)
        {

        }
    }
}
