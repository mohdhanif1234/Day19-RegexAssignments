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
        // UC-4: Pattern to validate mobile number

        public string MOBILE_NO_REGEX = "^[9][1][ ][6-9][0-9]{9}$";

        public void ValidateMobileNo(string mobNumber)
        {
            if (Regex.IsMatch(mobNumber, MOBILE_NO_REGEX))
            {
                Console.WriteLine("Mobile number is valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Mobile number is invalid");
                Console.ReadLine();
            }
        }

        
    }
}