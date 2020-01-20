using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.CommandsConsole
{
    class ConsoleCommand : InputOutput
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string args)
        {
            Console.WriteLine(args);
        }
    }
}
