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
using System.Configuration;

namespace AssignmentWeek1
{
    public partial class NewAccountForm : Form
    {
        public Person Person { get; set; }

        public bool PreviousCustomer { get; set; }

        //**********Have to change these events to MS event format****************
        public delegate void AddAccount();

        public event AddAccount OnAccountAdded;

        Methods meth = new Methods();
        
        public NewAccountForm()
        {
            InitializeComponent();
        }

        //private void btnAddCustomer_Click(object sender, EventArgs e)
        //{
        //    AddPerson();
        //}
        private void BoolAssign(bool input)
        {
            input = false;
        }

        //private string AddFillMessage(string message, string Method)
        //{ 
        //    return
        //}
        //private void AddPerson()
        //{
            
        //    PresentaionMethods presMeth = new PresentaionMethods();
            
            
        //    //bool flags to say whether each field has been filled out or not

        //    bool fNameEmpty = true;
        //    bool lNameEmpty = true;
        //    bool emailEmpty = true;
        //    bool phoneEmpty = true;
        //    bool address1Empty = true;
        //    bool address2Empty = true;
        //    bool cityEmpty = true;
        //    bool countyEmpty = true;
        //    string message = "";

        //    //checking to see that all fields have been input
        //    fNameEmpty = string.IsNullOrEmpty(cntlPerson.txtFName.Text) ? false : true;

        //    lNameEmpty = string.IsNullOrEmpty(cntlPerson.txtLName.Text) ? false : true;
           
        //    //checking to see if email is correct format 
        //    emailEmpty = string.IsNullOrEmpty(cntlPerson.txtEmail.Text) ? false : true;
        //    emailEmpty = presMeth.EmailValidator(cntlPerson.txtEmail.Text) == null ? false:true;
            
        //    phoneEmpty = string.IsNullOrEmpty(cntlPerson.txtPhone.Text) ? false : true;
        //    phoneEmpty = presMeth.PhoneValidator(cntlPerson.txtPhone.Text) == null ? false : true;

        //    address1Empty= string.IsNullOrEmpty(cntlPerson.txtAddress1.Text) ? false : true;
                        
        //    address2Empty = string.IsNullOrEmpty(cntlPerson.txtAddress2.Text) ? false : true;
            
        //    cityEmpty = string.IsNullOrEmpty(cntlPerson.txtCity.Text) ? false : true;
            
        //    countyEmpty = string.IsNullOrEmpty(cntlPerson.cmbCounty.Text) ? false : true;
            

        //    if (!fNameEmpty && !lNameEmpty && !emailEmpty && !phoneEmpty && !address1Empty && !address2Empty && !countyEmpty && !cityEmpty)
        //    {

        //        Person person = new Person();
        //        person.FName = cntlPerson.txtFName.Text;
        //        person.LName = cntlPerson.txtLName.Text;
        //        person.Email = cntlPerson.txtEmail.Text;
        //        person.Phone = cntlPerson.txtPhone.Text;
        //        person.Address1 = cntlPerson.txtAddress1.Text;
        //        person.Address2 = cntlPerson.txtAddress2.Text;
        //        person.City = cntlPerson.txtCity.Text;
        //        person.County = cntlPerson.cmbCounty.Text;

        //        if (meth.NewCustomer(person))
        //        {
        //            MessageBox.Show("Customer added");
        //            PreviousCustomer = true;
        //            //check state of page/refresh
        //            PageState();

                    
        //            txtInputCustId.Text = person.CustomerId.ToString();
        //        }
        //        Person = person;
        //    }
        //    else
        //    {
        //        //If fields are left empty this string of methods will create a message notifying the user which fields
        //        // are left blank. 
        //        message += presMeth.EmptyNotifier(cntlPerson.txtFName.Text, "First Name:");
        //        message += presMeth.EmptyNotifier(cntlPerson.txtLName.Text, "Last Name:");
                
                
        //        if (presMeth.EmptyNotifier(cntlPerson.txtEmail.Text, "Email:") == null)
        //        {
        //            //this will notify the user if email is in incorrect format
        //            message += presMeth.EmailValidator(cntlPerson.txtEmail.Text);
        //        }
        //        else
        //        {
        //            message += presMeth.EmptyNotifier(cntlPerson.txtEmail.Text, "Email:");
        //        }
                
        //        if (presMeth.EmptyNotifier(cntlPerson.txtPhone.Text, "Phone:")==null)
        //        {
        //            //this will notify the user if phone is in incorrect format
        //            message += presMeth.PhoneValidator(cntlPerson.txtPhone.Text);
        //        }
        //        else
        //        {
        //            message += presMeth.EmptyNotifier(cntlPerson.txtPhone.Text, "Phone:");
        //        }
           
        //        message += (presMeth.EmptyNotifier(cntlPerson.txtAddress1.Text, "Address 1:"));
        //        message += (presMeth.EmptyNotifier(cntlPerson.txtAddress2.Text, "Address 2:"));
        //        message += (presMeth.EmptyNotifier(cntlPerson.txtCity.Text, "City :"));
        //        message += (presMeth.EmptyNotifier(cntlPerson.cmbCounty.Text, "County :"));
            
        //        MessageBox.Show(message);
        //    }
        //}

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
            cntlAccount.txtSortCode.Text = ConfigurationManager.AppSettings["SortCode"];
            cntlAccount.txtSortCode.Enabled = false;
        }

        //private void rdoYes_CheckedChanged(object sender, EventArgs e)
        //{
        //    PreviousCustomer = true;
        //    PageState();

        //}
        private void existingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviousCustomer = true;
            PageState();
        }

        private void PageState()
        {
            if (PreviousCustomer)
            {
                cntlAccount.Enabled = true;
                txtInputCustId.Enabled = true;
                btnFindCustomer.Enabled = true;
            }

            
        }

        //private void rdoNo_CheckedChanged(object sender, EventArgs e)
        //{
        //    PreviousCustomer = false;
        //    PageState();
        //}

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {

            Person person = new Person();

            person.CustomerId = int.Parse(txtInputCustId.Text);

            person = meth.FindCustomer(person);

            if (person.FName != null)
            { 
                MessageBox.Show("Customer Found");
                //ShowCustomerDetails(person);
                Person = person;
            }
        }

        //private void ShowCustomerDetails(Person person)
        //{//Not all populating yet
        //    cntlPerson.txtFName.Text = person.FName;
        //    cntlPerson.txtLName.Text = person.LName;
        //    cntlPerson.txtEmail.Text = person.Email;
        //    cntlPerson.txtPhone.Text = person.Phone;
        //    cntlPerson.txtCity.Text = person.City;
        //}


    }
}
