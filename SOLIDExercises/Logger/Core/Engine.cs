using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Engine
    {
        public void Run()
        {
            List<IAppender> appenders = new List<IAppender>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                string appenderType = inputInfo[0];
                string layoutType = inputInfo[1];
                ReportLevel reportLevel = ReportLevel.INFO;

                if (inputInfo.Length > 2)
                {
                    reportLevel = Enum.Parse<ReportLevel>(inputInfo[2], true);
                }

                ILayout layout = LayoutFactory.CreateLayout(layoutType);
                IAppender appender = AppenderFactory.CreateAppender(appenderType, layout, reportLevel);

                appenders.Add(appender);
            }

            string input = Console.ReadLine();

            ILoggers loggers = new Loggers(appenders.ToArray());

            while (input != "END")
            {
                string[] inputInfo = input.Split("|");

                string loggerType = inputInfo[0];
                string date = inputInfo[1];
                string message = inputInfo[2];

                if (loggerType == "INFO")
                {
                    loggers.Info(date, message);
                }
                if (loggerType == "ERROR")
                {
                    loggers.Error(date, message);
                }
                if (loggerType == "WARNING")
                {
                    loggers.Warning(date, message);
                }
                if (loggerType == "CRITICAL")
                {
                    loggers.Critical(date, message);
                }
                if (loggerType == "FATAL")
                {
                    loggers.Fatal(date, message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Logger info");

            foreach (var appender1 in appenders)
            {
                Console.WriteLine(appender1);
            }
        }
    }
}
