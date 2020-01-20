using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Commands
{
    public interface ICommand
    {
        void Execute(string[] args, StudentRepository studentRepository);
    }
}
