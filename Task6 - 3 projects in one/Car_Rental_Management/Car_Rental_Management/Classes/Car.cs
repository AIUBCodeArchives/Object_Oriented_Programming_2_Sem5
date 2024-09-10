using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    internal class Car: Vehicle
    {
        public int NumberOfDoors { get; }

        public Car(string vehicleID, string brand, string model, int year, double dailyRentalRate, int numberOfDoors)
            : base(vehicleID, brand, model, year, dailyRentalRate)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car - ID: {VehicleID}, Brand: {Brand}, Model: {Model}, Year: {Year}, Daily Rate: ${DailyRentalRate:F2}, Doors: {NumberOfDoors}");
        }
    }
}
