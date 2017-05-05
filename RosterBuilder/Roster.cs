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
            LV1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            LV1.Items.Clear();
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
                        LV1.Items.Add(unit.getUnitName.ToString());
                        LV1.Items[i].SubItems.Add(unit.getUnitType);
                        LV1.Items[i].SubItems.Add(unit.getUnitCost.ToString());

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
