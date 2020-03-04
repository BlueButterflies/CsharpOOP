using MilitaryElite.Core;
using System;

namespace MilitaryElite
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IReadCommand command = new ReadCommand();

            IEngine engine = new Engine(command);

            engine.Run();
        }
    }
}
