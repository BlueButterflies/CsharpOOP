using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Logger
{
    public class LogFile : ILogFile
    {
        private const string LogFilePath = @"..\..\..\log.txt";

        public void Write(string message)
        {
            //CreateIfDoesntExistingLogFileDocument();

            File.AppendAllText(LogFilePath, message + Environment.NewLine);
        }

        //private void CreateIfDoesntExistingLogFileDocument()
        //{
        //    bool doesExist = File.Exists(LogFilePath);

        //    if (!doesExist)
        //    {
        //        File.Create(LogFilePath);
        //    }
        //}

        public int Size => File.ReadAllText(LogFilePath).Where(char.IsLetter).Sum(x => x);
    }
}