using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    // Base - Staff
    public class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public Staff(int id, string name, int salary, string department)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Department: {Department}");
        }

        public virtual bool StaffStatus()
        {
            return false;
        }
    }

    // D1 - Doctor
    public class Doctor : Staff
    {
        public string Specialization { get; set; }
        public int PatientsPerMonth { get; set; }

        public Doctor(int id, string name, int salary, string department, string specialization, int patientsPerMonth)
            : base(id, name, salary, department)
        {
            this.Specialization = specialization;
            this.PatientsPerMonth = patientsPerMonth;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Specialization: {Specialization}");
            Console.WriteLine($"Patients per Month: {PatientsPerMonth}");
        }

        public override bool StaffStatus()
        {
            return PatientsPerMonth > 50;
        }
    }

    // D2 - Nurse
    public class Nurse : Staff
    {
        public string Shift { get; set; }
        public int PatientsHandled { get; set; }
        private const int RatePerPatient = 50; // Fixed rate per patient handled

        public Nurse(int id, string name, int salary, string department, string shift, int patientsHandled)
            : base(id, name, salary, department)
        {
            this.Shift = shift;
            this.PatientsHandled = patientsHandled;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Shift: {Shift}");
            Console.WriteLine($"Patients Handled: {PatientsHandled}");
        }

        public override bool StaffStatus()
        {
            return PatientsHandled > 200;
        }
        public int CalculateEarnings()
        {
            return Salary + (PatientsHandled * RatePerPatient);
        }
    }
}
