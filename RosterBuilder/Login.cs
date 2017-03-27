using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
                if (logintext.Text != "" && 
                logintext.Text.Contains('@') && 
                logintext.Text.Contains('.'))
                {
                    new Dashboard().ShowDialog();
                }
                else
                {
                    MessageBox.Show("NOPE");
                }
        }
    }
}
