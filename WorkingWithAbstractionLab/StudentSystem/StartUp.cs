
using StudentSystem.CommandsConsole;
using System;

namespace StudentSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem(new ConsoleCommand());
            
            studentSystem.ParseCommand();
            
        }
    }
}
