using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class RegexPatternMatching
    {
        // UC-3: Pattern to validate an email Id

        public string EMAIL_REGEX = "^[A-Za-z]+([.][A-Za-z]+)?[@][a-z]+[.][a-z]{2,3}([.][a-z]{2})?$";

        public void ValidateEmail( string eMail)
        {
            if (Regex.IsMatch(eMail, EMAIL_REGEX))
            {
                Console.WriteLine("Email is valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Email is not valid");
                Console.ReadLine();
            }
        }
    }
}