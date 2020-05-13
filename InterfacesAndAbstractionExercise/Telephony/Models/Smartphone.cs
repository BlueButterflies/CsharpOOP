using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {

        public string Call(string number)
        {
            if (number.Any(x => char.IsDigit(x)))
            {
                return $"Calling... {number}";
            }
            
            return "Invalid number!";
        }

        public string Browse(string website)
        {
            if (!website.Any(x => char.IsDigit(x)) && !website.Any(x => char.IsWhiteSpace(x)))
            {
                return $"Browsing: {website}!";
            }

            return "Invalid URL!";
        }

    }
}
