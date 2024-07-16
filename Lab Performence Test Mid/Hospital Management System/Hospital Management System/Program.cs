using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor(101, "Dr. Smith", 120000, "Cardiology", "Cardiologist", 60);
            Nurse nurse = new Nurse(102, "Nurse Jane", 50000, "Pediatrics", "Night", 250);

            // Show doctor information
            doc.ShowInfo();
            Console.WriteLine($"Eligible for Bonus: {doc.StaffStatus()}");
            Console.WriteLine();

            // Show nurse information
            nurse.ShowInfo();
            Console.WriteLine($"Eligible for Bonus: {nurse.StaffStatus()}");
            Console.WriteLine($"Total Earnings: {nurse.CalculateEarnings():C}");
            
            Console.ReadLine();
        }
    }
}
