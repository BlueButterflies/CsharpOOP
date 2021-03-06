﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        protected int Counter { get; set; }

        public abstract void Append(string dateTime, ReportLevel logLevel, string message);

        public override string ToString()
        {
            return
                $"Appender type: {this.GetType().Name}, Layout type: {this.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.Counter}";
        }
    }
}
