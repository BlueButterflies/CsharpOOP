using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IMission  
    {
        public string CodeName { get; }

        public State State { get; }

        public void CompleteMission();
    }
}
