using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                switch ((string)armychoice.SelectedItem)
                {
                case "Empire":
                    codex.Clear();
                    codex.AppendText("Knight");
                    codex.AppendText(Environment.NewLine);
                    codex.AppendText("Swordsman");
                    codex.AppendText(Environment.NewLine);
                        break;
                case "Elves":
                    codex.Clear();
                    codex.AppendText("Fighter");
                    codex.AppendText(Environment.NewLine);
                    codex.AppendText("Archer");
                    codex.AppendText(Environment.NewLine);
                    break;
                case "Chaos":
                    codex.Clear();
                    codex.AppendText("Dark Knight");
                    codex.AppendText(Environment.NewLine);
                    codex.AppendText("Berserker");
                    codex.AppendText(Environment.NewLine);
                    break;
            }
        }

        private void RosterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
