using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Practice
{
    internal class Program
    {
        static void Main(string[] args)
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

            /*
             Console.Write("Enter First Number   : ");
             int number1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter Second Number  : ");
             int number2 = Convert.ToInt32(Console.ReadLine());
             int Result = number1 + number2;
             Console.Write("Result is : " + Result);
             */
            /*
            Console.Write("Enter your name  : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Score : ");
            int score = Convert.ToInt32(Console.ReadLine());
            string Condition;
            if(score>=50)
            {
                ///Console.WriteLine("Hi ! " + name+ " you have passed.");
                Condition = " you have passed. ";
            }
            else
            {
                ///Console.WriteLine("Hi ! " + name + " you have failed.");
                Condition = " you have failed. ";
            }
            Console.WriteLine("Hi ! " + name + Condition);*/
            /*
            for (int i = 0; i < 5;i++ )
            {
                Console.WriteLine("Proud AIUBIAN!");
            }
            */
            /*
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
            */

        }
    }
}
