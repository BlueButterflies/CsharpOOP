using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class StudentRepository
    {
        public StudentRepository()
        {
            this.Repository = new Dictionary<string, Student>();
        }

        private Dictionary<string, Student> Repository { get; set; }

        public void Add(string name, int age, double grade)
        {
            if (!Repository.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Repository[name] = student;
            }
        }

        public Student Find(string name)
        {
            if (Repository.ContainsKey(name))
            {
                return this.Repository[name];
            }
            return null;
        }
    }
}
