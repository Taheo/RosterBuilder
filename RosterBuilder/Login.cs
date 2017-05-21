using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RosterBuilder
{
    public partial class Login : Form
    {
         
           public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (dbcontroller.CheckPlayerExist(logintext.Text) == true)
            {
                if (dbcontroller.LoginUser(logintext.Text, passwordtext.Text) == true)
                {
                    Hide();
                    DisplayController.ShowDashboard();
                    Close();
                }

                else
                {
                    
                    Clearing();
                    MessageBox.Show("Enter correct data.", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("User not exist. Sign up yourself.", "New User Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clearing();
            }
        }
        
        private void registerbtn_Click(object sender, EventArgs e)
        {
            Hide();
            DisplayController.ShowRegister();
            Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void Clearing()
        {
            logintext.Text = "";
            passwordtext.Text = "";
        }
    }
}
