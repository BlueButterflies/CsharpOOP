using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Commands
{
    public class Create : ICommand
    {
        public void Execute(string[] args, StudentRepository studentRepository)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);

            studentRepository.Add(name, age, grade);
        }
    }
}
