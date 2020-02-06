using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams) 
            : base(name, price)
        {
            this.Garms = grams;
        }
        public double Garms { get; set; }
    }
}
