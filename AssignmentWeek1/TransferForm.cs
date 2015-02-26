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
    public partial class TransferForm : Form
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }

        public delegate void Transfered();
        public event Transfered OnTransferMade;

        public TransferForm()
        {
            InitializeComponent();
        }
        public TransferForm(int accountNum)
        {
            InitializeComponent();

            cntlSender.txtAccountNo.Text = accountNum.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Methods meth = new Methods();

            int creditAmount;
            int debitAmount;
            
            Sender = cntlSender.AccountDisplay;
            Receiver = cntlReceiver.AccountDisplay;

            
            creditAmount= int.Parse(cntlSender.txtAmount.Text);

            debitAmount = creditAmount * -1;

            if(meth.UpdateAccountBalance(debitAmount, Sender)&&meth.UpdateAccountBalance(creditAmount, Receiver))
            {
                string message = String.Format("{0}c has been successfully transfered from Account:{1} ({2} {3}) to Account:{4}({5} {6})",creditAmount,Sender.AccountNo,Sender.Person.FName,Sender.Person.LName,Receiver.AccountNo,Receiver.Person.FName,Receiver.Person.LName);
                
                

                Transaction sending = new Transaction();
                sending.Actor = Sender;
                sending.Amount = debitAmount;
                sending.TimeStamp = DateTime.Now;
                sending.TransactionType = "TransferOut";
                
                Transaction receiver = new Transaction();
                receiver.Actor = Receiver;
                receiver.Amount = creditAmount;
                receiver.TimeStamp = DateTime.Now;
                receiver.TransactionType = "TransferIn";

                Transfer transfer = new Transfer();

                transfer.Sender = sending;
                transfer.Receiver = receiver;
                transfer.Description = "Test";

                if (meth.TransferStore(transfer))
                {
                    message += " and Transaction recorded";
                }
                MessageBox.Show(message);
                OnTransferMade();
               
                Close();
            }
            




        }

    }
}
