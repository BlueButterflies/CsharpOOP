using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            Horsepower = horsePower;
            Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public int Horsepower { get; set; }

        public double Fuel { get; set; }

        public virtual void Drive(double km)
        {
            this.Fuel -= km * FuelConsumption;
        }
    }
}
