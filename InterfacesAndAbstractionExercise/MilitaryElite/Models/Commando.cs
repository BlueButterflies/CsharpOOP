using MilitaryElite.Enum;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps, ICollection<IMission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public ICollection<IMission> Missions { get; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine($"Corps: {this.Corps}");
            builder.AppendLine("Missions:");

            foreach (var item in this.Missions)
            {
                builder.AppendLine("  " + item.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
