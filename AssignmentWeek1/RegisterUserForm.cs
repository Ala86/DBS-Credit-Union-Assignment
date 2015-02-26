using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AssignmentWeek1
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        { 
            if (txtEntPwd.Text == txtEntPwdAgain.Text)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string userName = txtUserName.Text;
                string password = txtEntPwdAgain.Text;

                Methods meth = new Methods();

                if (meth.RegisterUser(firstName, lastName, userName, password))
                {
                    MessageBox.Show("New account has been successfully created");
                }
                else
                {
                    MessageBox.Show("Account creation failed");
                }
            }
            else
            {
                MessageBox.Show("The passwords you have entered do not match");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
