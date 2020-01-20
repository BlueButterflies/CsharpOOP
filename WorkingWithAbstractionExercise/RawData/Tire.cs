using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double prassure, int age)
        {
            this.Prassure = prassure;
            this.Age = age;
        }

        public double Prassure { get; set; }
        public int Age { get; set; }

    }
}
