using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterBuilder
{
    public class Unit
    {
        private string unitname;
        private string unittype;
        private int cost;

        public Unit() { }

        public string getUnitName
        {
            get { return unitname; }
            set { unitname = value; }
        }

        public string getUnitType
        {
            get { return unittype; }
            set { unittype = value; }
        }

        public int getUnitCost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
