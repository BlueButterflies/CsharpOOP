using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;

            this.Rooms = new List<Rooms>();

            CreateRoom();
        }

        public string Name { get; set; }

        public List<Rooms> Rooms { get; set; }

        public bool AddPatientToRoom(Patient patient)
        {
            var currentRoom = this.Rooms.FirstOrDefault(r => !r.IsFullRoom);

            if (currentRoom != null)
            {
                currentRoom.Patients.Add(patient);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CreateRoom()
        {
            for (int i = 0; i < 20; i++)
            {
                this.Rooms.Add(new Rooms());
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var rooms in this.Rooms)
            {
                foreach (var room in rooms.Patients)
                {
                    builder.AppendLine(room.Name);
                }
            }

            return builder.ToString().TrimEnd();
        }
    }
}
