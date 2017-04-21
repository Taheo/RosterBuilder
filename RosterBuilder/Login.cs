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
        //var currentuser = 
           public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (
                hasLowerChar.IsMatch(logintext.Text) &&
                hasNumber.IsMatch(logintext.Text) &&
                hasUpperChar.IsMatch(logintext.Text) && 
                hasSymbols.IsMatch(logintext.Text)
                )
            {
                Hide();
                DisplayController.ShowDashboard();
                Close();
            }
            else
            {
                MessageBox.Show("NOPE");
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
