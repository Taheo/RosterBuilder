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
                if (dbcontroller.Logowanie(logintext.Text, passwordtext.Text) == true)
                {
                    Hide();
                    DisplayController.ShowDashboard();
                    Close();
                }
                else
                {
                    MessageBox.Show("Enter correct data");
                }    
            }
            else
            {
                MessageBox.Show("Noooo");
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
    }
}
