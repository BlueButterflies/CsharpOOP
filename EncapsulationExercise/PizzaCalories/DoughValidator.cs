using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class DoughValidator
    {
        private static Dictionary<string, double> flourType;
        private static Dictionary<string, double> bakingTechnique;

        public static bool IsValidFlourType(string type)
        {
            Initialize();

            return flourType.ContainsKey(type);
        }

        public static bool IsValidBackingTechnique(string type)
        {
            Initialize();

            return bakingTechnique.ContainsKey(type);
        }

        public static double GetFlourModifier(string type)
        {
            Initialize();

            return flourType[type];
        }

        public static double GetBackingTechModifier(string type)
        {
            Initialize();

            return bakingTechnique[type];
        }

        private static void Initialize()
        {
            if (flourType != null && bakingTechnique != null)
            {
                return;
            }

            flourType = new Dictionary<string, double>();
            bakingTechnique = new Dictionary<string, double>();

            flourType.Add("White", 1.5);
            flourType.Add("Wholegrain", 1);

            bakingTechnique.Add("Crispy", 0.9);
            bakingTechnique.Add("Chewy", 1.1);
            bakingTechnique.Add("Homemade", 1);
        }
    }
}
