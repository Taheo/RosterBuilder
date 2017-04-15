﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            dbcontroller.AddUser(logintext.Text, emailtext.Text, passwordtext.Text);
            logintext.Text = "";
            emailtext.Text = "";
            passwordtext.Text = "";
            
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
