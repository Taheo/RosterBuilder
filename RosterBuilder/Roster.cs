using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosterBuilder
{
    public partial class RosterView : Form
    {
        public RosterView()
        {
            InitializeComponent();
        }

        private void codex_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            //var filename = "Empire.csv";
            //var lines = File.ReadAllLines(filename);
            //foreach (string line in lines)
            //{
            //    var parts = line.Split(',');
            //    ListViewItem lvi = new ListViewItem(parts[0]);
            //    LV.Items.Add(parts[0] + "  -  " + parts[1]);
            //}

            //var lines = File.ReadAllLines("test.txt").Select(a => a.Split(';'));
            //var csv = from line in lines
            //          select (line.Split(',')).ToArray();
            //    switch ((string)armychoice.SelectedItem)
            //    {

            //    case "Empire":
            //        codex.Clear();
            //        codex.AppendText("Knight");
            //        codex.AppendText(Environment.NewLine);
            //        codex.AppendText("Swordsman");
            //        codex.AppendText(Environment.NewLine);
            //            break;
            //    case "Elves":
            //        codex.Clear();
            //        codex.AppendText("Fighter");
            //        codex.AppendText(Environment.NewLine);
            //        codex.AppendText("Archer");
            //        codex.AppendText(Environment.NewLine);
            //        break;
            //    case "Chaos":
            //        codex.Clear();
            //        codex.AppendText("Dark Knight");
            //        codex.AppendText(Environment.NewLine);
            //        codex.AppendText("Berserker");
            //        codex.AppendText(Environment.NewLine);
            //        break;
            //}
        }

        private void RosterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            GC.Collect();
            new Dashboard().ShowDialog();
            Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
