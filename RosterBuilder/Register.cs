using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosterBuilder
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
              
            if (UserController.ValidateUserPassword(passwordtext.Text) == true &&
                UserController.ValidateUserEmail(emailtext.Text) == true)
            {
                dbcontroller.AddUser(logintext.Text, emailtext.Text, passwordtext.Text);
                logintext.Text = "";
                emailtext.Text = "";
                passwordtext.Text = "";
            }
            else
            {
                MessageBox.Show("Enter correct data");
            }


        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
