using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hospital
{
    public class Rooms
    {
        public Rooms()
        {
            this.Patients = new List<Patient>(); 
        }

        public bool IsFullRoom => this.Patients.Count >= 3;

        public List<Patient> Patients{ get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var patient in this.Patients.OrderBy(n => n.Name))
            {
                builder.AppendLine(patient.Name);
            }

            return builder.ToString().TrimEnd();
        }
    }
}
