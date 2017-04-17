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
            dbcontroller.AddUnit(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox5.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            this.RosterView_Load(this, null);
        }

        private void RosterView_Load(object sender, EventArgs e)
        {
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            listView1.Items.Clear();
            List<Unit> cos;
            try
            {
                cos = dbcontroller.GetUnit();
                if (cos.Count() > 0)
                {
                    Unit unit;
                    for (int i = 0; i < cos.Count; i++)
                    {
                        unit = cos[i];
                        listView1.Items.Add(unit.getUnitName.ToString());
                        listView1.Items[i].SubItems.Add(unit.getUnitType);
                        listView1.Items[i].SubItems.Add(unit.getUnitCost.ToString());

                }
                }
                else
                {
                    MessageBox.Show("something goes wrong");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
