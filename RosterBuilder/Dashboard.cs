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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            Hide();
            DisplayController.ShowRoster();
            Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           // nicklabel.Text = currentuserlogin
        }
    }
}
