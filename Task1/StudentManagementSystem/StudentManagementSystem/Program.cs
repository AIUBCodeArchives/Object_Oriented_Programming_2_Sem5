using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public bool IsFullTime { get; set; }

        public Student()
        {
            //default constructor
        }
        public Student(int id, string name, double gpa, bool isfulltime)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
            this.IsFullTime = isfulltime;
        }
        public void display()
        {
            Console.WriteLine($"Student's ID : {Id}");
            Console.WriteLine($"Student's Name : {Name}");
            Console.WriteLine($"Student's GPA : {GPA}");
            Console.WriteLine($"Student's attendence status(IsFullTime y//n) : {IsFullTime}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of student : ");
            int numberOfStudent = Convert.ToInt32(Console.ReadLine()); 
            Student[] student = new Student[numberOfStudent];

            for (int i = 0; i < numberOfStudent; i++) {

                //Green - For using empty/Default Constructor
                //student[i] = new Student();
                Console.WriteLine($"Enter details for Student : {i+1}");
                Console.Write($"Enter Student No.{i+1} ID : ");
                //student[i].Id = Convert.ToInt32(Console.ReadLine());
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Student No.{i + 1} Name : ");
                //student[i].Name = Console.ReadLine();
                string Name = Console.ReadLine();
                Console.Write($"Enter Student No.{i + 1} GPA : ");
                //student[i].GPA = Convert.ToDouble(Console.ReadLine());
                double GPA = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter Student No.{i + 1} Attendence Info : ");
                //student[i].IsFullTime = Convert.ToBoolean(Console.ReadLine());
                bool IsFullTime = Convert.ToBoolean(Console.ReadLine());
                student[i] = new Student(Id, Name, GPA, IsFullTime);
                Console.WriteLine();
                Console.WriteLine();
            }
            double TotalGPA = 0.0;
            for (int i = 0; i < numberOfStudent; i++)
            {
                TotalGPA += student[i].GPA;
            }

            double aveGPA = TotalGPA / numberOfStudent;


            //display 
            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.WriteLine($"Details for Student : {i + 1}");
                Console.WriteLine($"ID : {student[i].Id}");
                Console.WriteLine($"Name : {student[i].Name}");
                Console.WriteLine($"GPA : {student[i].GPA}");
                Console.WriteLine($"Attendence Info : {student[i].IsFullTime}");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine($"Avarage GPA : {aveGPA}");

            Console.ReadLine();

        }
    }
}
