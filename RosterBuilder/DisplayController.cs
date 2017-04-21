using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RosterBuilder
{
    abstract class DisplayController
    {
        public static void ShowLogin()
        {
            new Login().ShowDialog();
        }

        public static void ShowRegister()
        {
            new Register().ShowDialog();
        }

        public static void ShowRoster()
        {
            new RosterView().ShowDialog();
        }

        public static void ShowDashboard()
        {
            new Dashboard().ShowDialog();
        }
    }
}
