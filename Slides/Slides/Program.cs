using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slides
{
    internal class Program
    {
        public void printLine()
        {
            Console.WriteLine("This is a line code");
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.printLine();

            const float pi = 3.1416f;

            Console.ReadLine();
        }
    }
}
