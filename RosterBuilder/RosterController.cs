using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosterBuilder
{
    public class RosterController
    {

        public List<string> army = new List<string>();
        string armyname = "Empire";
        public void ReadCSV()
        {
            try
            {
                using (StreamReader reader = new StreamReader($"{armyname}.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        army.Add(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
