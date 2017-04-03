﻿using System;
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
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           
                if (logintext.Text == "" && 
                logintext.Text.Contains('@') && 
                logintext.Text.Contains('.') && 
                passwordtext.Text !="")
                {
                Hide();
                new Dashboard().ShowDialog();
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
            string p = @"((?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[@#$%]).{6,20})";
            string s = logintext.Text;
            Regex r = new Regex(p);
            if (r.IsMatch(s))
            {

            }
        }
    }
}
