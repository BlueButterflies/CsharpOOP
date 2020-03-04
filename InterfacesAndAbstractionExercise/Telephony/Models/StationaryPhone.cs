using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Calling(string calling)
        {
            if (calling.Any(x => char.IsDigit(x)))
            {
                return $"Dialing... {calling}";
            }

            return "Invalid number!";
        }
    }
}
