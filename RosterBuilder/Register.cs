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
                dbcontroller.AddUser(logintext.Text, emailtext.Text, passwordtext.Text);
                logintext.Text = "";
                emailtext.Text = "";
                passwordtext.Text = "";
            }
            else
            {
                MessageBox.Show("NOPE");
            }
            
            
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
