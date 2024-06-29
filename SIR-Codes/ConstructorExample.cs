using System;

namespace ConstructorsExample
{
    public class Car
    {
        // Static field
        public static string Manufacturer = "Toyota";

        // Instance fields
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Default constructor
        public Car()
        {
            Model = "Unknown";
            Year = 2000;
            Price = 0.0;
            Console.WriteLine("Default constructor called.");
        }

        // Static constructor
        /*static Car()
        {
            Manufacturer = "Toyota";
            Console.WriteLine("Static constructor called.");
        }*/

        // Parameterized constructor
        public Car(string model, int year, double price)
        {
            Model = model;
            Year = year;
            Price = price;
            Console.WriteLine("Parameterized constructor called.");
        }

        // Copy constructor
        public Car(Car car)
        {
            Model = other.Model;
            Year = other.Year;
            Price = other.Price;
            Console.WriteLine("Copy constructor called.");
        }

        // Method to display car details
        public void DisplayDetails()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Price: {Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started.");

            // Using default constructor
            Car car1 = new Car();
            car1.DisplayDetails();

            // Using parameterized constructor
            Car car2 = new Car("Camry", 2022, 30000.0);
            car2.DisplayDetails();

            //Using copy constructor
            Car car3 = new Car(car2);
            car3.DisplayDetails();
        }
    }
}
