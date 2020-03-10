using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class XmlLayout : ILayout
    {
        public string Format 
            =>
    @"
    <log>
         <date>{0}</date>
         <level>{1}</level>
         <messege>{2}</messege>
    </log>";
        
    }
}
