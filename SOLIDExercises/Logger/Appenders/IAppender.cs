
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface IAppender
    {
        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        void Append(string dateTime, ReportLevel logLevel, string message);
    }
}
