using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
		private string flouerType;

		public Dough(string flourType, string bakingTechType, double weight)
		{
			this.FlourType = flourType;
			this.BackingTechnique = bakingTechType;
			this.Weight = weight;
		}
		public string FlourType
		{
			get => flouerType;

			set 
			{
				if (!DoughValidator.IsValidFlourType(value))
				{
					throw new Exception("Invalid type of dough.");
				}

				flouerType = value; 
			}
		}

		private string backingTechnique;

		public string BackingTechnique
		{
			get => backingTechnique;

			set 
			{
				if (!DoughValidator.IsValidBackingTechnique(value))
				{
					throw new Exception("Invalid type of dough.");
				}

				backingTechnique = value;
			}
		}

		private double weight;

		public double Weight
		{
			get => weight;

			set
			{
				if (value < 1 || value > 200)
				{
					throw new Exception("Dough weight should be in the range [1..200].");
				}

				weight = value;
			}
		}

		public double GetTotalCalories()
		{
			return this.weight
				* 2
				* DoughValidator.GetBackingTechModifier(this.BackingTechnique)
			    * DoughValidator.GetFlourModifier(this.FlourType);
		}
	}
}
