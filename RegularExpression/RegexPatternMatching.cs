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
        // UC-1: First name starts with a capital letter and has minimum 3 letters followed by it

        public string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{3,4}$";

        public void ValidateFirstName(string fName)
        {
            if (Regex.IsMatch(fName, FIRST_NAME_REGEX))
            {
                Console.WriteLine("Pattern is valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pattern is invalid");
                Console.ReadLine();
            }
        }
    }
}
