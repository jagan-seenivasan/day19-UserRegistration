using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class CheckDiffEmail
    {
        public string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pattern);
        }
    }
}
