using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.CommandsConsole
{
    public interface InputOutput
    {
        string Read();
        void Write(string args);
    }
}
