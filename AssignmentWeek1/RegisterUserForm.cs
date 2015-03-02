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
using Model;

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
                string username = txtUserName.Text;
                string password = txtEntPwdAgain.Text;

                Methods meth = new Methods();
                Employee emp = new Employee();

                emp.FirstName = firstName;
                emp.LastName = lastName;
                emp.Password = password;
                emp.Username = username;
                
                if (meth.RegisterUser(emp))
                {
                    MessageBox.Show("New account has been successfully created");
                }
                else
                {
                    MessageBox.Show("Username already exists");
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
