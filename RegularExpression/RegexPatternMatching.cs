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
        // UC-6 (Rule-2): Pattern to validate a password having atleast 1 uppercase character

        public string PASSWORD_REGEX = "^[A-Z]{1,}[A-Za-z]{7,}$";

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