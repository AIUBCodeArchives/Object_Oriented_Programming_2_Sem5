using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    internal class Truck: Vehicle
    {
        public int CargoCapacity { get; }

        public Truck(string vehicleID, string brand, string model, int year, double dailyRentalRate, int cargoCapacity)
            : base(vehicleID, brand, model, year, dailyRentalRate)
        {
            CargoCapacity = cargoCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Truck - ID: {VehicleID}, Brand: {Brand}, Model: {Model}, Year: {Year}, Daily Rate: ${DailyRentalRate:F2}, Cargo Capacity: {CargoCapacity}kg");
        }
    }
}
