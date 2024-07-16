using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Book_Inventroy_Management_System
{

    //CustomDate Custom class type
    public class CustomDate
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }

        public CustomDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Year;

            if (today.Month < Month || (today.Month == Month && today.Day < Day))
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return $"{Year}-{Month:D2}-{Day:D2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Library maximum book capacity : ");
            int maxBookCapacity = Convert.ToInt32(Console.ReadLine());

            Library library = new Library(maxBookCapacity);  // Create a library with a capacity of 10 books

            library.AddBook(new Fiction("101", "The Great C++", "John F. Kennedy", new CustomDate(1925, 4, 10), "Computer Science"));
            library.AddBook(new NonFiction("102", "A Brief History of Time", "Donald Trump", new CustomDate(1988, 3, 1), "Science"));

            library.ShowAllBooks();
            Console.WriteLine($"Total number of books: {library.TotalBooks}");
            Console.ReadLine();
        }
    }
}
