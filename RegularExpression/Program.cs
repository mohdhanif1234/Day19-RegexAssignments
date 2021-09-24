using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexPatternMatching mobNo = new RegexPatternMatching();
            mobNo.ValidateMobileNo("91 9919819801");
        }
    }
}
