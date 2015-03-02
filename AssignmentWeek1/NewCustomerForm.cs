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
    public partial class NewCustomerForm : Form
    {
        Person person { get; set; }
        public bool PreviousCustomer { get; set; }
        Methods meth = new Methods();

        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            AddPerson();
            
        }

        private void AddPerson()
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
            fNameEmpty = string.IsNullOrEmpty(cntlPerson.txtFName.Text) ? false : true;

            lNameEmpty = string.IsNullOrEmpty(cntlPerson.txtLName.Text) ? false : true;

            //checking to see if email is correct format 
            emailEmpty = string.IsNullOrEmpty(cntlPerson.txtEmail.Text) ? false : true;
            emailEmpty = presMeth.EmailValidator(cntlPerson.txtEmail.Text) == null ? false : true;

            phoneEmpty = string.IsNullOrEmpty(cntlPerson.txtPhone.Text) ? false : true;
            phoneEmpty = presMeth.PhoneValidator(cntlPerson.txtPhone.Text) == null ? false : true;

            address1Empty = string.IsNullOrEmpty(cntlPerson.txtAddress1.Text) ? false : true;

            address2Empty = string.IsNullOrEmpty(cntlPerson.txtAddress2.Text) ? false : true;

            cityEmpty = string.IsNullOrEmpty(cntlPerson.txtCity.Text) ? false : true;

            countyEmpty = string.IsNullOrEmpty(cntlPerson.cmbCounty.Text) ? false : true;


            if (!fNameEmpty && !lNameEmpty && !emailEmpty && !phoneEmpty && !address1Empty && !address2Empty && !countyEmpty && !cityEmpty)
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
                    NewAccountForm account = new NewAccountForm();
                    account.Show();
                    //check state of page/refresh
              
                }
                //Person = person;
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
    }
}
