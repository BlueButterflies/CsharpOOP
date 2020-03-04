using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private readonly IReadCommand readCommand;

        public Engine(IReadCommand readCommand)
        {
            this.readCommand = readCommand;
        }

        public void Run()
        {
            try
            {
                string input = Console.ReadLine();

                while (input != "End")
                {
                    string[] infoInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string result = readCommand.Read(infoInput);

                    Console.WriteLine(result);

                    input = Console.ReadLine();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
