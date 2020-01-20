using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hospital
{
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string department = arguments[0];

                string firstName = arguments[1];
                string lasteName = arguments[2];

                string patient = arguments[3];

                string fullName = firstName + " " + lasteName;


                this.hospital.AddDoctor(firstName, lasteName);
                this.hospital.AddDepartment(department);
                this.hospital.AddPatient(department,fullName, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (arguments.Length == 1)
                {
                    var departmenName = arguments[0];

                    var depatment = this.hospital.Departments
                        .FirstOrDefault(d => d.Name == departmenName);

                    Console.WriteLine(depatment);
                }
                else 
                {
                    bool isRoom = int.TryParse(arguments[1], out int resultRoom);

                    if (isRoom)
                    {
                        var departmenName = arguments[0];

                        var depatment = this.hospital.Departments
                            .FirstOrDefault(d => d.Name == departmenName);

                        var currentRoom = depatment.Rooms[resultRoom - 1];

                        Console.WriteLine(currentRoom);
                    }
                    else
                    {
                        string firstName = arguments[0];
                        string lastName = arguments[1];

                        string fullName = firstName + " " + lastName;

                        var doctor = this.hospital.Doctors.FirstOrDefault(d => d.FullName ==  fullName);

                        Console.WriteLine(doctor);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
