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
        // UC-7 (Rule-3): Pattern to validate a password having atleast 1 number

        public string PASSWORD_REGEX = "^[A-Z]{1,}[0-9]{1,}[A-Za-z]{6,}$";

        public void ValidatePassword(string passWord)
        {
            if (Regex.IsMatch(passWord, PASSWORD_REGEX))
            {
                Console.WriteLine("Password is valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Password is invalid");
                Console.ReadLine();
            }
        }

        

        
    }
}