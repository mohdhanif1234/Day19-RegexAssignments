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
        // UC-5 (Rule-1): Pattern to validate a password having minimum of 8 characters

        public string PASSWORD_REGEX = "^[A-Za-z]{8,}";

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