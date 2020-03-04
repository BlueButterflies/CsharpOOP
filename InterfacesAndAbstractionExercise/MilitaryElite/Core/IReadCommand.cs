using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Core
{
    public interface IReadCommand
    {
        public string Read(string[] command);
    }
}
