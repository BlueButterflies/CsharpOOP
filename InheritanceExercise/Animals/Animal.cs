
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => name;

            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                name = value;
            }
        }

        public int Age 
        { 
            get => age;

            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                age = value;
            }
        }

        public string Gender
        {
            get => gender;

            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value) || (value != "Female" && value != "Male"))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
           StringBuilder result = new StringBuilder();

            result.AppendLine(this.GetType().Name);
            result.AppendLine($"{this.name} {this.age} {this.gender}");
            result.Append(this.ProduceSound());

            return result.ToString();
        }
    }
}
