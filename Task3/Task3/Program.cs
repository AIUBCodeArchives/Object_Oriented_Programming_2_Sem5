using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{   
    public class Person 
    { 
        protected string name { set; get; }
        protected int age { set; get; }

        public Person() 
        {
            name = "N/F";
            age = 0;
        }
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;        
        }


        public virtual void display ()
        {
            Console.WriteLine($"Person name : {name}\nPerson age : {age}");
        }
    }

    public class Employee : Person
    {
        protected int employeeid { set; get; }
        protected string deptartment { set; get; }
        public static int employeeNumber = 0;

        public Employee() 
        {
            
        }
        public Employee(string name ,int age, int employeeid, string department) : base(name, age)
        { 
            this.employeeid = employeeid;
            this.deptartment = department;
            employeeNumber++;
            Console.WriteLine("Number of employee increased");
        }
        public override void display() 
        {
            base.display();
            Console.WriteLine($"Employee ID : {employeeid}\nEmployee Department : {deptartment}");
        } 

        public static void NumberOfEmployees () 
        {
            Console.WriteLine($"Total number of employees : {employeeNumber}");
        }

    }
    class Manager : Employee
    {
        protected int teamsize { set; get; }

        public Manager()
        {

        }
        public Manager(string name, int age, int employeeid, string department, int teamsize) : base(name, age, employeeid, department)
        {
            this.teamsize = teamsize;
        }
        public override void display()
        {
            base.display ();
            Console.WriteLine($"Manager Teamsize : {teamsize}");
        }
    }
    class Tecnician : Employee
    {
        protected string specialization { set; get; }

        public Tecnician() 
        {
            
        }
        public Tecnician(string name, int age, int employeeid, string department, string specialization) : base(name, age, employeeid, department)
        {
            this.specialization = specialization;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine($"Tecnicain specialization : {specialization}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Manager details:");
            Console.Write("Name: ");
            string Name1 = Console.ReadLine();
            Console.Write("Age: ");
            int Age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee ID: ");
            int EmployeeId1 = int.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string Department1 = Console.ReadLine();
            Console.Write("Team Size: ");
            int TeamSize1 = int.Parse(Console.ReadLine());
            Manager manager = new Manager(Name1, Age1, EmployeeId1, Department1, TeamSize1);

            manager.display();
            Console.WriteLine("Enter Manager details:");
            Console.Write("Name: ");
            string Name2 = Console.ReadLine();
            Console.Write("Age: ");
            int Age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee ID: ");
            int EmployeeId2 = int.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string Department2 = Console.ReadLine();
            Console.Write("Specialization: ");
            string Specialization1 = Console.ReadLine();
            Tecnician tecnician = new Tecnician(Name1, Age1, EmployeeId1, Department1, Specialization1);

            tecnician.display();

            Employee.NumberOfEmployees();


            Console.ReadLine();
        }
    }
}
