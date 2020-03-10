
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Loggers : ILoggers
    {
        private IAppender[] appender;

        public Loggers(params IAppender[] appender)
        {
            this.Appender = appender;
        }

        public IAppender[] Appender
        {
            get => appender;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException(nameof(Appender), "value cannot be null");
                }

                appender = value;
            }
        }

        public void Critical(string dateTime, string message)
        {
            ApendMessage(dateTime, ReportLevel.CRITICAL, message);
        }

        public void Error(string dateTime, string message)
        {
            ApendMessage(dateTime, ReportLevel.ERROR, message);

        }

        public void Fatal(string dateTime, string message)
        {
            ApendMessage(dateTime, ReportLevel.FATAL, message);
        }

        public void Info(string dateTime, string message)
        {
            ApendMessage(dateTime, ReportLevel.INFO, message);
        }

        public void Warning(string dateTime, string message)
        {
            ApendMessage(dateTime, ReportLevel.WARNING, message);
        }

        private void ApendMessage(string dateTime, ReportLevel log, string message)
        {
            foreach (var item in this.Appender)
            {
                item.Append(dateTime, log, message);
            }
        }
    }
}
