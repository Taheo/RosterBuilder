using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterBuilder
{
    class User : UserController
    {
        int IDuser;
       private string Username;
       private string Password;
       private string Email;

        public User() { }

        public int id
        {
            get {return IDuser ;}
            set {IDuser = value ;}
        }

    }
}
