using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IId> identificables = new List<IId>();
            List<IBirthday> birthdays = new List<IBirthday>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] info = command.Split();

                if (info[0] == "Citizen")
                {
                    string name = info[1];
                    int age = int.Parse(info[2]);
                    string id = info[3];
                    string date = info[4];

                    birthdays.Add(new Citizen (name, age, id, date));
                }

                if (info[0] == "Robot")
                {
                    string model = info[1];
                    string id = info[2];

                    identificables.Add(new Robot(model, id));
                }

                if (info[0] == "Pet")
                {
                    string name = info[1];
                    string date = info[2];

                    birthdays.Add(new Pet(name, date));
                }

                command = Console.ReadLine();
            }

            string dateOfBirth = Console.ReadLine();

            birthdays.Where(c => c.Date.EndsWith(dateOfBirth))
            .Select(c => c.Date)
            .ToList()
            .ForEach(Console.WriteLine);
        }
    }
}
