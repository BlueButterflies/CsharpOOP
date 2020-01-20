using System;
using System.Collections.Generic;
using System.Text;
using StudentSystem.Commands;
using StudentSystem.CommandsConsole;

namespace StudentSystem
{
    public class StudentSystem 
    {
        private StudentRepository students;
        private Dictionary<string, ICommand> commands;

        public StudentSystem(InputOutput inputOutput)
        {
            this.students = new StudentRepository();
            this.commands = new Dictionary<string, ICommand>();
            this.commands.Add("Create", new Create());
            this.commands.Add("Show", new Show(inputOutput));

            this.InputOutput = inputOutput;
        }

        public InputOutput InputOutput { get; }

        public void ParseCommand()
        {
            while (true)
            {
                string[] args = this.InputOutput.Read().Split();

                string commandName = args[0];

                if (this.commands.ContainsKey(commandName))
                {
                    var command = this.commands[commandName];
                    command.Execute(args, students);
                }
                else if (commandName == "Exit")
                {
                    return;
                }
            }
        }
    }
}
