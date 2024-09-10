using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    internal class Motorcycle: Vehicle
    {
        public int EngineCapacity { get; }

        public Motorcycle(string vehicleID, string brand, string model, int year, double dailyRentalRate, int engineCapacity)
            : base(vehicleID, brand, model, year, dailyRentalRate)
        {
            EngineCapacity = engineCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Motorcycle - ID: {VehicleID}, Brand: {Brand}, Model: {Model}, Year: {Year}, Daily Rate: ${DailyRentalRate:F2}, Engine Capacity: {EngineCapacity}cc");
        }
    }
}
