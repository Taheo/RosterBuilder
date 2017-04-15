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
        List<User> DBusers;
        public Login()
        {
            InitializeComponent();
            GC.Collect();
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
                new Dashboard().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("NOPE");
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
