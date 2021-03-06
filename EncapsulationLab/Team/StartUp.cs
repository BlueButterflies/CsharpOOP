﻿ using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    string[] info = Console.ReadLine().Split();

                    string name = info[0];
                    string lastName = info[1];
                    int age = int.Parse(info[2]);
                    decimal salary = decimal.Parse(info[3]);


                    Person person = new Person(name, lastName, age, salary);

                    persons.Add(person);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            //decimal parcentage = decimal.Parse(Console.ReadLine());

            //persons.ForEach(p => p.IncreaseSalary(parcentage));

            //persons.ForEach(p => Console.WriteLine(p.ToString()));

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}
