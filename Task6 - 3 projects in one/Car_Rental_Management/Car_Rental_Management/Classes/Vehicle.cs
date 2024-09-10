using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    abstract class Vehicle
    {
        public string VehicleID { get; }
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public double DailyRentalRate { get; }

        private static int totalVehiclesRented = 0;

        protected Vehicle(string vehicleID, string brand, string model, int year, double dailyRentalRate)
        {
            VehicleID = vehicleID;
            Brand = brand;
            Model = model;
            Year = year;
            DailyRentalRate = dailyRentalRate;
        }

        public abstract void ShowInfo();

        public double CalculateRentalCost(int days)
        {
            // Increment totalVehiclesRented each time CalculateRentalCost is called
            totalVehiclesRented++;
            return DailyRentalRate * days;
        }

        public static void DisplayTotalVehiclesRented()
        {
            Console.WriteLine($"Total number of vehicles rented: {totalVehiclesRented}");
        }
    }
}
