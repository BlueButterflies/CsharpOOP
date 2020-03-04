using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class ToppingValidator
    {
        private static Dictionary<string, double> toppingType;

        public static bool IsValid(string type)
        {
            Initialize();

            return toppingType.ContainsKey(type);
        }

        public static double GetToppingModificare(string type)
        {
            Initialize();

            return toppingType[type];
        }

        private static void Initialize()
        {
            if (toppingType != null)
            {
                return;
            }

            toppingType = new Dictionary<string, double>();

            toppingType.Add("Meat",1.2);
            toppingType.Add("Veggies", 0.8);
            toppingType.Add("Cheese", 1.1);
            toppingType.Add("Sauce", 0.9);

        }
    }
}
