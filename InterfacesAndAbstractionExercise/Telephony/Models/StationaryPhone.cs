using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (number.Any(x => char.IsDigit(x)))
            {
                return $"Dialing... {number}";
            }

            return "Invalid number!";
        }
    }
}
