using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Test1
{
    public class Employee 
    {
        private string fullName;

        //Accessor 
        public string getFullName()
        {
            return fullName;
        }
        //Mutator
        public void setFullName(string fullName)
        {
            this.fullName = fullName;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello world");

            //    string name = "rakin";

            //    Console.WriteLine($"my name is {name}");


            //int[] source = { 1, 2, 3 };

            //var query = from item in source where item <= 2 select item;

            //foreach( var item in query )
            //{
            //    Console.WriteLine(item);
            //}

            Employee employee = new Employee();
            Console.Write("Enter name for testing : ");

            string test = Console.ReadLine();
            employee.setFullName(test);

            Console.WriteLine(employee.getFullName());

            Console.ReadLine();

        }
    }
}
