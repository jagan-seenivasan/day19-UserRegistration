using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    class ValidFirstName
    {
        string pattern = "^[A-Za-z]{2,}$";
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the first name");
            ValidatingFirstName();

        }

       

        public void ValidatingFirstName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
