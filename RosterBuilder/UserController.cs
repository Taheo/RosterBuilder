using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RosterBuilder
{
    public abstract class UserController
    {
        

        bool ValidateUserPassword(string _password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            var hasSafeLength = new Regex(@"^(?=.{8})(?=.*[^a-zA-Z])");

            if (hasLowerChar.IsMatch(_password) &&
                hasNumber.IsMatch(_password) &&
                hasUpperChar.IsMatch(_password) &&
                hasSymbols.IsMatch(_password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ValidateUserEmail(string _email)
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (hasSymbols.IsMatch(_email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}