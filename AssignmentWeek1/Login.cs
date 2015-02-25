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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPass.Text;
            string username = txtUserName.Text;

            Methods meth = new Methods();
            if (meth.UserLogin(password, username))
            {
               MessageBox.Show("Login Successful");
               MainForm mf = new MainForm();
               mf.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {

            RegisterUser ru = new RegisterUser();

            ru.Show();

        }
    }
}
