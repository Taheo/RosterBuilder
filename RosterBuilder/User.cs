using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterBuilder
{
    public class User : UserController
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

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

    }
}
