using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new List<Doctor>();
            this.Departments = new List<Department>();
        }

        public List<Doctor> Doctors { get; set; }

        public List<Department> Departments { get; set; }

        public void AddDoctor(string firstName, string lastName)
        {
            string fullNameDoctor = firstName + " " + lastName;

            if (!this.Doctors.Any(d => d.FullName == fullNameDoctor))
            {
                Doctor doctor = new Doctor(firstName, lastName);

                this.Doctors.Add(doctor);
            }
        }

        public void AddDepartment(string name)
        {
            if (!this.Departments.Any(d => d.Name == name))
            {
                Department department = new Department(name);

                this.Departments.Add(department);
            }
        }

        public void AddPatient(string departmentName, string doctorName, string patientName)
        {
            var currentDepartment = this.Departments.FirstOrDefault(d => d.Name == departmentName);

            var currentDoctor = this.Doctors.FirstOrDefault(d => d.FullName == doctorName);

            Patient currentPatient = new Patient(patientName);

            if (currentDepartment.AddPatientToRoom(currentPatient))
            {
                currentDoctor.Patients.Add(currentPatient);
            }
        }
    }
}
