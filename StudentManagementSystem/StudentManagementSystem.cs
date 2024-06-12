using System;

namespace StudentManagementSystem
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public bool IsFullTime { get; set; }

        public Student(int id, string name, double gpa, bool isFullTime)
        {
            this.ID = id;
            this.Name = name;
            this.GPA = gpa;
            this.IsFullTime = isFullTime;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", GPA: " + GPA + ", Full-Time: " + IsFullTime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter details for student " + (i + 1) + ":");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("GPA: ");
                double gpa = double.Parse(Console.ReadLine());

                Console.Write("Is Full-Time (true/false): ");
                bool isFullTime = bool.Parse(Console.ReadLine());

                students[i] = new Student(id, name, gpa, isFullTime);
            }

            Console.WriteLine("\nStudent Details:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                students[i].DisplayStudentInfo();
            }

            double averageGPA = CalculateAverageGPA(students, numberOfStudents);
            Console.WriteLine("\nAverage GPA: " + averageGPA);
        }

        static double CalculateAverageGPA(Student[] students, int numberOfStudents)
        {
            double totalGPA = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                totalGPA += students[i].GPA;
            }
            return totalGPA / numberOfStudents;
        }
    }
}
