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
            PresentaionMethods presMeth = new PresentaionMethods();
            //WILL REFACTOR THIS TO METHOD

            bool fNameEmpty = true;
            bool lNameEmpty = true;
            bool emailEmpty = true;
            bool phoneEmpty = true;
            bool address1Empty = true;
            bool address2Empty = true;
            bool cityEmpty = true;
            bool countyEmpty = true;
            string message = "";
            
            if (presMeth.EmptyChecker(cntlPerson.txtFName.Text, "First Name:") == null)
            {
                fNameEmpty = false;
                message += presMeth.EmptyChecker(cntlPerson.txtFName.Text, "First Name:");
            }

            if (presMeth.EmptyChecker(cntlPerson.txtLName.Text, "Last Name:") == null)
            {
                lNameEmpty = false;
                message += presMeth.EmptyChecker(cntlPerson.txtLName.Text, "Last Name:");
            }

            if (presMeth.EmptyChecker(cntlPerson.txtEmail.Text, "Email:") == null)
            {
                emailEmpty = false;
                message += presMeth.EmptyChecker(cntlPerson.txtEmail.Text, "Email:");
            }

            if (presMeth.EmptyChecker(cntlPerson.txtPhone.Text, "Phone:") == null)
            {
                phoneEmpty = false;
                message += presMeth.EmptyChecker(cntlPerson.txtPhone.Text, "Phone:");
            }
           
            if (presMeth.EmptyChecker(cntlPerson.txtAddress1.Text, "Address 1:") == null)
            {
                address1Empty = false;
                message += (presMeth.EmptyChecker(cntlPerson.txtAddress1.Text, "Address 1:"));
            }
            if (presMeth.EmptyChecker(cntlPerson.txtAddress2.Text, "Address 2:") == null)
            {
                address2Empty = false;
                message +=(presMeth.EmptyChecker(cntlPerson.txtAddress2.Text, "Address 2:"));
            }
            if (presMeth.EmptyChecker(cntlPerson.txtCity.Text, "City :") == null)
            {
                cityEmpty = false;
                message += (presMeth.EmptyChecker(cntlPerson.txtCity.Text, "City :"));
            }
            if (presMeth.EmptyChecker(cntlPerson.cmbCounty.Text, "County :") == null)
            {
                countyEmpty = false;
                message += (presMeth.EmptyChecker(cntlPerson.cmbCounty.Text, "County :"));
            }

            if (!fNameEmpty && !lNameEmpty && !emailEmpty && !phoneEmpty && !address1Empty && !address2Empty && !countyEmpty && !cityEmpty)
            {


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
            else
            { 
            MessageBox.Show(message);
            }
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
