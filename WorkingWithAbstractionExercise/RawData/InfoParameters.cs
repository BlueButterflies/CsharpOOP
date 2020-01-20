using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RawData
{
    public class InfoParameters
    {
        public void Info()
        {
            int lines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                GenereteCars(cars, parameters);
            }

            string command = Console.ReadLine();

            PrintResult(cars, command);
        }

        private static void PrintResult(List<Car> cars, string command)
        {
            if (command == "fragile")
            {
                List<string> fragile = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.Prassure < 1))
               .Select(x => x.Model)
               .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else if (command == "flamable")
            {
                List<string> flamable = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                .Select(x => x.Model)
                .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        private static void GenereteCars(List<Car> cars, string[] parameters)
        {
            Tire[] tire = new Tire[4];

            string model = parameters[0];

            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            double firstTirePressure = double.Parse(parameters[5]);
            int firstTireAge = int.Parse(parameters[6]);
            tire[0] = new Tire(firstTirePressure, firstTireAge);

            double secondTirePressure = double.Parse(parameters[7]);
            int secondTireAge = int.Parse(parameters[8]);
            tire[1] = new Tire(secondTirePressure, secondTireAge);

            double thirdTirePressure = double.Parse(parameters[9]);
            int thirdTireAge = int.Parse(parameters[10]);
            tire[2] = new Tire(thirdTirePressure, thirdTireAge);

            double fourthTirePressure = double.Parse(parameters[11]);
            int fourthTireAge = int.Parse(parameters[12]);
            tire[3] = new Tire(fourthTirePressure, fourthTireAge);

            cars.Add(new Car(model, engine, cargo, tire));
        }
    }
}
