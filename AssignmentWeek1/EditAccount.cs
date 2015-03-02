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
using Model;

namespace AssignmentWeek1
{
    public partial class EditAccount : Form
    {

        public Account Account { get; set; }
        public delegate void EditDetails();

        public event EditDetails OnDetailsEdited;

        Methods meth = new Methods();


        public EditAccount()
        {
            InitializeComponent();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            Account acc = new Account();

            acc.AccountNo = int.Parse(txtAccountNumber.Text);

            acc = meth.PopulateDetails(acc);

            if (acc.Person.FName != null)
            {

                ShowCustomerDetails(acc);
                Account = acc;
            }
        }
        private void ShowCustomerDetails(Account acc)
        {//Not all populating yet
            cntlPerson.txtFName.Text = acc.Person.FName;
            cntlPerson.txtLName.Text = acc.Person.LName;
            cntlPerson.txtEmail.Text = acc.Person.Email;
            cntlPerson.txtPhone.Text = acc.Person.Phone;
            cntlPerson.txtCity.Text = acc.Person.City;
            cntlPerson.txtAddress1.Text = acc.Person.Address1;
            cntlPerson.txtAddress2.Text = acc.Person.Address2;
            cntlAccount.txtOverdraft.Text = acc.Overdraft.ToString();
            cntlAccount.txtSortCode.Text = acc.SortCode.ToString();
            cntlAccount.txtBalance.Text = acc.Balance.ToString();
            if (acc.AccountType == "Current")
            {
                cntlAccount.rdoCurrent.Checked = true;
            }
            else if (acc.AccountType == "Savings")
            {
                cntlAccount.rdoSavings.Checked = true;
            }
        }
        

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            PresentaionMethods presMeth = new PresentaionMethods();


            //bool flags to say whether each field has been filled out or not

            bool fNameEmpty = true;
            bool lNameEmpty = true;
            bool emailEmpty = true;
            bool phoneEmpty = true;
            bool address1Empty = true;
            bool address2Empty = true;
            bool cityEmpty = true;
            bool countyEmpty = true;
            string message = "";

            //checking to see that all fields have been input
            fNameEmpty = string.IsNullOrEmpty(cntlPerson.txtFName.Text) ? true:false;

            lNameEmpty = string.IsNullOrEmpty(cntlPerson.txtLName.Text) ? true : false;

            //checking to see if email is correct format 
            emailEmpty = string.IsNullOrEmpty(cntlPerson.txtEmail.Text) ? true : false;

            emailEmpty = presMeth.EmailValidator(cntlPerson.txtEmail.Text) == null ?  false: true;

            phoneEmpty = string.IsNullOrEmpty(cntlPerson.txtPhone.Text) ? true : false;

            phoneEmpty = presMeth.PhoneValidator(cntlPerson.txtPhone.Text) == null ? false : true;

            address1Empty = string.IsNullOrEmpty(cntlPerson.txtAddress1.Text) ? true : false;

            address2Empty = string.IsNullOrEmpty(cntlPerson.txtAddress2.Text) ? true : false;

            cityEmpty = string.IsNullOrEmpty(cntlPerson.txtCity.Text) ? true : false;

            countyEmpty = string.IsNullOrEmpty(cntlPerson.cmbCounty.Text) ? true : false;


            if (!fNameEmpty && !lNameEmpty && !emailEmpty && !phoneEmpty && !address1Empty && !address2Empty && !countyEmpty && !cityEmpty)
            {
                string email = cntlPerson.txtEmail.Text;
                string phone = cntlPerson.txtPhone.Text;
                string address1 = cntlPerson.txtAddress1.Text;
                string address2 = cntlPerson.txtAddress2.Text;
                string city = cntlPerson.txtCity.Text;
                string county = cntlPerson.cmbCounty.Text;
                int overdraft = int.Parse(cntlAccount.txtOverdraft.Text);

                if (meth.EditAccountDetails(email, phone, address1, address2, city, county, overdraft, Account))
                {

                    MessageBox.Show("The account has been edited");

                }
            }
            else
            {
                //If fields are left empty this string of methods will create a message notifying the user which fields
                // are left blank. 
                message += presMeth.EmptyNotifier(cntlPerson.txtFName.Text, "First Name:");
                message += presMeth.EmptyNotifier(cntlPerson.txtLName.Text, "Last Name:");


                if (presMeth.EmptyNotifier(cntlPerson.txtEmail.Text, "Email:") == null)
                {
                    //this will notify the user if email is in incorrect format
                    message += presMeth.EmailValidator(cntlPerson.txtEmail.Text);
                }
                else
                {
                    message += presMeth.EmptyNotifier(cntlPerson.txtEmail.Text, "Email:");
                }

                if (presMeth.EmptyNotifier(cntlPerson.txtPhone.Text, "Phone:") == null)
                {
                    //this will notify the user if phone is in incorrect format
                    message += presMeth.PhoneValidator(cntlPerson.txtPhone.Text);
                }
                else
                {
                    message += presMeth.EmptyNotifier(cntlPerson.txtPhone.Text, "Phone:");
                }

                message += (presMeth.EmptyNotifier(cntlPerson.txtAddress1.Text, "Address 1:"));
                message += (presMeth.EmptyNotifier(cntlPerson.txtAddress2.Text, "Address 2:"));
                message += (presMeth.EmptyNotifier(cntlPerson.txtCity.Text, "City :"));
                message += (presMeth.EmptyNotifier(cntlPerson.cmbCounty.Text, "County :"));

                MessageBox.Show(message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        
    }
}
