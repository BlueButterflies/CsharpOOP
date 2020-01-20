using StudentSystem.CommandsConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Commands
{
    public class Show : ICommand
    {
        public Show(InputOutput inputOutput)
        {
            this.InputOutput = inputOutput;
        }

        public InputOutput InputOutput { get; }

        public void Execute(string[] args, StudentRepository studentRepository)
        {
            var name = args[1];

            var student = studentRepository.Find(name);

            if (student != null)
            {
                this.InputOutput.Write(student.ToString());
            }
        }
    }
}
