using Car_Rental_Management.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Creating a list to hold all vehicles
                List<Vehicle> vehicles = new List<Vehicle>();

                // Creating and adding some vehicles
                vehicles.Add(new Car("C001", "Toyota", "Camry", 2020, 40.0, 4));
                vehicles.Add(new Motorcycle("M001", "Harley-Davidson", "Sportster", 2018, 25.0, 1200));
                vehicles.Add(new Truck("T001", "Ford", "F-150", 2021, 60.0, 10000));

                // Taking input for number of days to rent
                Console.WriteLine("Enter the number of days for rental:");
                if (!int.TryParse(Console.ReadLine(), out int days))
                {
                    Console.WriteLine("Invalid number of days.");
                    return;
                }

                // Displaying information and rental costs for each vehicle
                foreach (var vehicle in vehicles)
                {
                    vehicle.ShowInfo();
                    Console.WriteLine($"Rental Cost for {days} days: ${vehicle.CalculateRentalCost(days):F2}");
                    Console.WriteLine();
                }

                // Displaying the total number of vehicles rented
                Vehicle.DisplayTotalVehiclesRented();
            
        }
    }
}
