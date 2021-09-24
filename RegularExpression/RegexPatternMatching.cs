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
        public string PASSWORD_REGEX = "^[A-Za-z]{7,}[~!@#$%^&*]$";

        // UC-8 (Rule-4): Pattern to validate a password having exactly 1 special character

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