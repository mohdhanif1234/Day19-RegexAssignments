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
        // UC-9: To clear all the email samples provided separately

        public string EMAIL_REGEX = "^[a-z]+[-.+]?([0-9]+)?([a-z]|[0-9])+[@]([0-9]+)?([a-z]+)?[.][a-z]{2,3}([.][a-z]+)?$";

        public void ValidateEmailAllRules(string emailId)
        {
            if (Regex.IsMatch(emailId, EMAIL_REGEX))  
            {
                Console.WriteLine("Email Id is valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Email Id is invalid");
                Console.ReadLine();
            }
        }
    }
}