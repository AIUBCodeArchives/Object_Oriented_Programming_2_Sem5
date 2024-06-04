using System;
using System.Linq;


namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    System.Console.WriteLine("Hello world");

        //    string name = "rakin";

        //    Console.WriteLine($"my name is {name}");


            int[] source = { 1, 2, 3 };
            
            var query = from item in source where item <= 2 select item;

            foreach( var item in query )
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
