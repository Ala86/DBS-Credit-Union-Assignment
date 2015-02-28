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
    public partial class MainForm : Form
    {
        int selectedRow = 0;
        int accountColumn = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lodgementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccountDisplay.SelectedRows[0].Index > -1)
            {
                selectedRow = dgvAccountDisplay.SelectedRows[0].Index;
            } 
            
            if (selectedRow < 0)
            {

                LodgementForm lodge = new LodgementForm();
                lodge.Show();
                lodge.OnLodgementMade += DisplayAccountsLastName;
            }
            else
            { 
                int accountNum = (int)dgvAccountDisplay.Rows[selectedRow].Cells[accountColumn].Value;
                LodgementForm lodge = new LodgementForm(accountNum);
                lodge.Show();
                lodge.OnLodgementMade += DisplayAccountsLastName;
            }
            
            

        }

        private void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccountDisplay.SelectedRows[0].Index > -1)
            {
                selectedRow = dgvAccountDisplay.SelectedRows[0].Index;
            }
            if (selectedRow < 0)
            {

                WithdrawalForm with = new WithdrawalForm();
                with.Show();
                with.OnWithdrawalMade += DisplayAccountsLastName;
            }
            else
            {
                int accountNum = (int)dgvAccountDisplay.Rows[selectedRow].Cells[accountColumn].Value;
                WithdrawalForm with = new WithdrawalForm(accountNum);
                with.Show();
                with.OnWithdrawalMade += DisplayAccountsLastName;
                
            }
        }

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvAccountDisplay.SelectedRows[0].Index > -1)
            {
                selectedRow = dgvAccountDisplay.SelectedRows[0].Index;
            }
            if (selectedRow < 0)
            {

                TransferForm trans = new TransferForm();
                trans.Show();
                trans.OnTransferMade += DisplayAccountsLastName;
            }
            else
            {
                int accountNum = (int)dgvAccountDisplay.Rows[selectedRow].Cells[accountColumn].Value;
                TransferForm trans = new TransferForm(accountNum);
                trans.Show();
                trans.OnTransferMade += DisplayAccountsLastName;

            }
   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAccountsLastName();
        }

        private void DisplayAccountsLastName()
        {
            Methods meth = new Methods();

            BindingSource bs = new BindingSource();

            DataSet ds = meth.DisplayAccountsLastName();
            bs.DataSource = ds.Tables[0];
            dgvAccountDisplay.DataSource = bs;
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransactionHistoryForm viewTrans = new ViewTransactionHistoryForm();

            viewTrans.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer newcus = new NewCustomer();
            newcus.Show();
        }

        private void existingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccountForm newacc = new NewAccountForm();
            newacc.OnAccountAdded += DisplayAccountsLastName;
            newacc.Show();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccount edit = new EditAccount();
            edit.Show();
        }
    }
}
