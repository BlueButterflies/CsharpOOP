using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyer = new List<IBuyer>();

            int numOfPerson = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPerson; i++)
            {
                string[] info = Console.ReadLine().Split();

                if (info.Length == 4)
                {
                    string name = info[0];
                    int age = int.Parse(info[1]);
                    string id = info[2];
                    string birthdate = info[3];

                    buyer.Add(new Citizen(name,age, id, birthdate));
                }

                if (info.Length == 3)
                {
                    string name = info[0];
                    int age = int.Parse(info[1]);
                    string group = info[2];

                    buyer.Add(new Rebel(name, age, group));
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var buyers = buyer.SingleOrDefault(x => x.Name == command);

                if (buyers != null)
                {
                    buyers.Buy();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(buyer.Sum(x => x.Food));
        }
    }
}
