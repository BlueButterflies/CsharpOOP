using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();


            string typeAnimals = Console.ReadLine();

            while (typeAnimals != "Beast!")
            {
                try
                {
                    string[] animalParams = Console.ReadLine().Split();

                    string name = animalParams[0];
                    int age = int.Parse(animalParams[1]);
                    string gender = animalParams[2];

                    if (typeAnimals == "Cat")
                    {
                        animals.Add(new Cat(name, age, gender));
                    }
                    else if (typeAnimals == "Dog")
                    {
                        animals.Add(new Dog(name, age, gender));
                    }
                    else if (typeAnimals == "Frog")
                    {
                        animals.Add(new Frog(name, age, gender));
                    }
                    else if (typeAnimals == "Kitten")
                    {
                        animals.Add(new Kitten(name, age));
                    }
                    else if (typeAnimals == "Tomcat")
                    {
                        animals.Add(new Tomcat(name, age));
                    }
                    else
                    {
                        animals.Add(new Animal(name, age, gender));
                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                typeAnimals = Console.ReadLine();

            }
            animals.ForEach(x => Console.WriteLine(x));
        }
    }
}
