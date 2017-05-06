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
        List<Unit> tempUnitlist;
        List<Unit> tempUnitlist2;
        public RosterView()
        {
            InitializeComponent();
        }

        private void RosterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            DisplayController.ShowDashboard();
            Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            dbcontroller.AddUnit(unitnamebox.Text, unittypebox.Text, Convert.ToInt32(modelcostbox.Text));
            unitnamebox.Text = "";
            unittypebox.Text = "";
            modelcostbox.Text = "";
            this.RosterView_Load(this, null);
        }

        private void RosterView_Load(object sender, EventArgs e)
        {
            armylist.Items.Clear();
            rosterlist.Items.Clear();
            
            try
            {
                tempUnitlist = dbcontroller.GetUnit();
                if (tempUnitlist.Count() > 0)
                {
                    Unit unit;
                    for (int i = 0; i < tempUnitlist.Count; i++)
                    {
                        unit = tempUnitlist[i];
                        armylist.Items.Add(unit.getUnitName.ToString());
                        armylist.Items[i].SubItems.Add(unit.getUnitType);
                        armylist.Items[i].SubItems.Add(unit.getUnitCost.ToString());

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

        private void countbtn_Click(object sender, EventArgs e)
        {
            var sum = this.armylist.Items
              .Cast<ListViewItem>()
              .Sum(item => int.Parse(item.SubItems[2].Text));
            totalbox.Text = sum.ToString();
        }

        private void armylist_ItemActivate(object sender, EventArgs e)
        {
            // MessageBox.Show("Yes, this is click");
            //armylist.Items[].SubItems = rosterlist.Items[];

            //Unit unit;
            //for (int i = 0; i < tempUnitlist.Count; i++)
            //{
            //    unit = tempUnitlist[i];
            //    armylist.Items.Add(unit.getUnitName.ToString());
            //    armylist.Items[i].SubItems.Add(unit.getUnitType);
            //    armylist.Items[i].SubItems.Add(unit.getUnitCost.ToString());

            ////}
        
            //    Unit unit2;
            //    for (int i = 0; i < tempUnitlist.Count; i++)
            //    {
            //        unit2 = tempUnitlist2[i];
            //        rosterlist.Items.Add(unit2.getUnitName.ToString());
            //        rosterlist.Items[i].SubItems.Add(unit2.getUnitType);
            //        rosterlist.Items[i].SubItems.Add(unit2.getUnitCost.ToString());
                    
            //    }
            
        }
    }
}
