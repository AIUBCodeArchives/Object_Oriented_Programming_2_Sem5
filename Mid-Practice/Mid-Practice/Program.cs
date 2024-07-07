using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Practice
{
    internal class Program
    {
        public void BasicHW()
        {
            string message = "Hello World";
            Console.WriteLine(message);
            Console.Write("Hello");
            message = " World";
            Console.WriteLine(message);
            Console.Write("message");

            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number + 10);
            Console.WriteLine("\nResult : " + number + 10);
            Console.WriteLine(Environment.NewLine + "Result : " + (number + 10));

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Hi!  " + name);


            Console.Write("Enter First Number   : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number  : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int Result = number1 + number2;
            Console.Write("Result is : " + Result);


            Console.Write("Enter your name  : ");
            string name1 = Console.ReadLine();
            Console.Write("Enter your Score : ");
            int score = Convert.ToInt32(Console.ReadLine());
            string Condition;
            if (score >= 50)
            {
                ///Console.WriteLine("Hi ! " + name+ " you have passed.");
                Condition = " you have passed. ";
            }
            else
            {
                ///Console.WriteLine("Hi ! " + name + " you have failed.");
                Condition = " you have failed. ";
            }
            Console.WriteLine("Hi ! " + name1 + Condition);

            for (int i = 0; i < 5;i++ )
            {
                Console.WriteLine("Proud AIUBIAN!");
            }
            

            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 5;
            numbers[2] = 6;
            numbers[3] = 7;
            numbers[4] = 8;
            ///for (int i = 0; i < 5; i++)
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (var variable in numbers)
            {
                Console.WriteLine(variable);
            }
        }

        public void BasicVariables ()
        {
            // int value
            var age = 45;
            Console.WriteLine("Var can hold int values : " + age);
            // string value
            var name = "Cecilia Hansen";
            Console.WriteLine("Var can hold string values : " + name);
            /// Array
            var odds = new[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Var can hold an array .");
            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }
            //for loop
            for (var x = 1; x <= 10; x++)
            {
                Console.WriteLine("Proud AIUBIAN");
            }

            var p = 10; //Valid

            ///String from Constructor
            char[] chars = { 'C', 'e', 'c', 'i', 'l', 'i', 'a' };
            string name = new string(chars);
            Console.WriteLine(name);
            /// String from Literal
            string fname = "Cecilia";
            string lname = "Hansen";
            string age = "25";

            Console.WriteLine($"First Name : {fname}, Last Name : {lname}, Age : {age}");
            //Console.WriteLine("Last Name  : {0}", lname);
            //Console.WriteLine("Age        : {0}", age);

            Console.WriteLine("First Name : " + fname);
            Console.WriteLine("Last Name  : " + lname);
            Console.WriteLine("Age        : " + age);

            string now = "Date : " + DateTime.Now.ToString("D");
            Console.WriteLine(now);
            now = "Date : " + DateTime.Now.ToString("dd-MM-yy");
            Console.WriteLine(now);
            now = "Date : " + DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(now);
            now = "Date : " + DateTime.Now.ToString();
            Console.WriteLine(now);

            string Info = "Cecilia Hansen is 25 years old";
            int start = Info.IndexOf("is") + 1;
            Console.WriteLine(start);//16
            string substring = Info.Substring(start + 2, 2);
            //string substring = Info.Substring(0, 6);// 0<=x<6
            Console.WriteLine("Age is " + substring);
            for (int count = 0; count <= Info.Length - 1; count++)
            {
                Console.Write(Info[count]);
            }


        }

        public int x;
        //readonly 
        public readonly int y = 50;
        public readonly int z;

        public Program()
        {
            z = 80;
        }
        public Program(int r1, int r2, int r3)
        {
            x = r1;
            y = r2;
            z = r3;
        }

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday = 6,
            Friday,
            Saturday,
            Sunday
        }
        enum Categories
        {
            Electronics = 10,
            Furniture = 3,
            Food = 5,
            Arts = 2
        }

        static void Main(string[] args)
        {

            Program program = new Program();
            //program.BasicHW();
           // program.BasicVariables();
            //Program p1 = new Program(11, 22, 33);
            //Console.WriteLine("X= " + p1.x + " Y= " + p1.y + " Z= " + p1.z);
            //Program p2 = new Program();
            //p2.x = 100;
            //Console.WriteLine("X= " + p2.x + " Y= " + p2.y + " Z= " + p2.z);
            //Console.WriteLine(WeekDays.Monday);
            //Console.WriteLine(WeekDays.Tuesday);
            //Console.WriteLine(WeekDays.Wednesday);
            //Console.WriteLine(WeekDays.Thursday);
            //Console.WriteLine(WeekDays.Friday);
            //Console.WriteLine(WeekDays.Saturday);
            //Console.WriteLine(WeekDays.Sunday);

            //Console.WriteLine((int)WeekDays.Monday);
            //Console.WriteLine((int)WeekDays.Tuesday);
            //Console.WriteLine((int)WeekDays.Wednesday);
            //Console.WriteLine((int)WeekDays.Thursday);
            //Console.WriteLine((int)WeekDays.Friday);
            //Console.WriteLine((int)WeekDays.Saturday);
            //Console.WriteLine((int)WeekDays.Sunday);

            //string[] value = Enum.GetNames(typeof(Categories));
            //foreach (string s in value)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] n = (int[])Enum.GetValues(typeof(Categories));
            //foreach (int x in n)
            //{
            //    Console.WriteLine(x);
            //}

            Console.ReadLine();
        }
    }
}
