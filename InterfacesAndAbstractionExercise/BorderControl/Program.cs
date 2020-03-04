using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentificableId> identificables = new List<IIdentificableId>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] info = command.Split();

                if (info.Length == 3)
                {
                    string name = info[0];
                    int age = int.Parse(info[1]);
                    string id = info[2];

                    identificables.Add(new Citizen(name, age, id));
                }

                if (info.Length == 2)
                {
                    string model = info[0];
                    string id = info[1];

                    identificables.Add(new Robot(model, id));
                }

                command = Console.ReadLine();
            }

            string idIdentifical = Console.ReadLine();

            identificables.Where(c => c.Id.EndsWith(idIdentifical))
            .Select(c => c.Id)
            .ToList()
            .ForEach(Console.WriteLine);
        }
    }
}
