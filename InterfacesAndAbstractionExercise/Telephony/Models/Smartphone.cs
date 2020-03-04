using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {

        public string Calling(string calling)
        {
            if (calling.Any(x => char.IsDigit(x)))
            {
                return $"Calling... {calling}";
            }

            return "Invalid number!";
        }

        public string Browsing(string website)
        {
            if (!website.Any(x => char.IsDigit(x)))
            {
                return $"Browsing: {website}!";
            }

            return "Invalid URL!";
        }

    }
}
