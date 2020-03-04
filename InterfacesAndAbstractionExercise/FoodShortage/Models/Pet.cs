using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Pet
    {
        public Pet(string name, string date)
        {
            this.Name = name;
            this.Date = date;
        }

        public string Name { get; set; }

        public string Date { get; set; }
    }
}
