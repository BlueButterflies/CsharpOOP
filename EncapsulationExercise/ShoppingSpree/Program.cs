using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
			
			try
			{
				List<Person> personInput = Console.ReadLine()
					.Split(";", StringSplitOptions.RemoveEmptyEntries)
					.Select(p => new
					{
						Name = p.Split("=")[0],
						Money = double.Parse(p.Split("=")[1])
					})
					.Select(x => new Person(x.Name, x.Money))
					.ToList();

				List<Product> productInput = Console.ReadLine()
					.Split(";", StringSplitOptions.RemoveEmptyEntries)
					.Select(p => new
					{
						Name = p.Split("=")[0],
						Cost = double.Parse(p.Split("=")[1])
					})
					.Select(x => new Product(x.Name, x.Cost))
					.ToList();

				string input = Console.ReadLine();

				while (input != "END")
				{
					string[] infoInput = input.Split();

					string name = infoInput[0];
					string product = infoInput[1];

					Person person = personInput.FirstOrDefault(x => x.Name == name);
					Product product1 = productInput.FirstOrDefault(x => x.NameProduct == product);

					person.AddToBag(product1);

					input = Console.ReadLine();
				}

				foreach (var person in personInput)
				{
					Console.WriteLine(person);
				}
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex.Message);
			}
        }
    }
}
