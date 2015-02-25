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
    public partial class NewAccount : Form
    {
        public Person Person { get; set; }

        public bool PreviousCustomer { get; set; }

        public delegate void AddAccount();

        public event AddAccount OnAccountAdded;

        Methods meth = new Methods();
        
        public NewAccount()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddPerson();
        }
        private void AddPerson()
        {
            Person person = new Person();

            person.FName = cntlPerson.txtFName.Text;
            person.LName = cntlPerson.txtLName.Text;
            person.Email = cntlPerson.txtEmail.Text;
            person.Phone = cntlPerson.txtPhone.Text;
            person.Address1 = cntlPerson.txtAddress1.Text;
            person.Address2 = cntlPerson.txtAddress2.Text;
            person.City = cntlPerson.txtCity.Text;
            person.County = cntlPerson.cmbCounty.Text;

            

            if (meth.NewCustomer(person))
            {
                MessageBox.Show("Customer added");
                PreviousCustomer = true;
                PageState();
                lblCustomerIdDisplay.Text = person.CustomerId.ToString();
                txtInputCustId.Text = person.CustomerId.ToString();
            }
            Person = person;

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            
            account.Balance = int.Parse(cntlAccount.txtBalance.Text);
            account.SortCode = 101010;
            account.Overdraft = int.Parse(cntlAccount.txtOverdraft.Text);
            account.AccountType = cntlAccount.AccountType;
             
            account.Person = Person;

            if (meth.NewAccount(account))
            {
                MessageBox.Show("Account created");
                OnAccountAdded();
                Close();
            }
            
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            cntlAccount.txtSortCode.Text = "101010";
            cntlAccount.txtSortCode.Enabled = false;
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            PreviousCustomer = true;
            PageState();

        }

        private void PageState()
        {
            if (PreviousCustomer)
            {
                cntlPerson.Enabled = false;
                btnAddCustomer.Enabled = false;
                cntlAccount.Enabled = true;
                txtInputCustId.Enabled = true;
                btnFindCustomer.Enabled = true;
            }

            else if (!PreviousCustomer)
            {
                cntlPerson.Enabled = true;
                btnAddCustomer.Enabled = true;
                cntlAccount.Enabled = false;
                txtInputCustId.Enabled = false;
                btnFindCustomer.Enabled = false;
            }
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            PreviousCustomer = false;
            PageState();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {

            Person person = new Person();

            person.CustomerId = int.Parse(txtInputCustId.Text);

            person = meth.FindCustomer(person);

            if (person.FName!= null)
            { 
                MessageBox.Show("Customer Found");
                ShowCustomerDetails(person);
                Person = person;
            }
        }

        private void ShowCustomerDetails(Person person)
        {//Not all populating yet
            cntlPerson.txtFName.Text = person.FName;
            cntlPerson.txtLName.Text = person.LName;
            cntlPerson.txtEmail.Text = person.Email;
            cntlPerson.txtPhone.Text = person.Phone;
            cntlPerson.txtCity.Text = person.City;
        }


    }
}
