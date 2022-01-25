using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReGex_UserRegistration
{
    public class AtleastOneDigit
    {
        public string Regex_Pattern = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z]).*$";

        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pattern);
        }
    }
}
