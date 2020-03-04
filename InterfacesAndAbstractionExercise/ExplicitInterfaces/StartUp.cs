using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Citizen> person = new List<Citizen>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string name = command[0];
                string country = command[1];
                int age = int.Parse(command[2]);

                person.Add(new Citizen(name, country, age));

                command = Console.ReadLine().Split();
            }

            foreach (var people in person)
            {
                Console.WriteLine(people.GetNames() + Environment.NewLine + people.GetName());
            }
        }
    }
}
