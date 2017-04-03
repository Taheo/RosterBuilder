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
            GC.Collect();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string validator = @"((?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[@#$%]).{6,20})";
           // string caption = logintext.Text;

            Regex regexinst = new Regex(validator);
            if (regexinst.IsMatch(logintext.Text))
            {
                Hide();
               // Close();
                
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
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
