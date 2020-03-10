using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class JsonLayout : ILayout
    {
        public string Format
            => 
    @"
    {{
        ""log"": {{
        ""date"": {0},
        ""level"": {1},
        ""messege"": {2} 
        }}
    }}";
    }
}
