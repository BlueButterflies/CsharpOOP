using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverage.HotBeverage
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50m;

        public Coffee(string name, double coffeine) 
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Coffeine = coffeine;
        }
        public double Coffeine { get; set; }
    }
}
