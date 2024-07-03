using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Management_System
{
    public class Vehicle
    {
        protected string vehicleId { get; set; }
        protected string brand { get; set; }
        protected double price { get; set; }
        public static int vehicleCount = 0;

        public Vehicle(string vehicleId, string brand, double price) 
        {
            this.vehicleId = vehicleId;
            this.brand = brand;
            this.price = price;
            vehicleCount++;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine($"Vehicle ID : {vehicleId}");
            Console.WriteLine($"Vehicle brand : {brand}");
            Console.WriteLine($"Vehicle price : {price}");
        }

        public static void showVehicleDetails(Vehicle vehicle)
        {
            if (vehicle is Car car)
            {
                car.displayInfo();
            }
            else if (vehicle is Motorcycle motorcycle)
            {
                motorcycle.displayInfo();
            }
            else
            {
                vehicle.displayInfo();
            }
        }
    }

    public class Car : Vehicle
    {
        public int numberOfDoors { get; set; }
        public string fuelType { get; set; }

        public Car(string vehicleId, string brand, double price, int numberOfDoors, string fuelType) : base(vehicleId, brand, price)
        {
            base.displayInfo();
            this.numberOfDoors = numberOfDoors;
            this.fuelType = fuelType;
        }

        public override void displayInfo()
        {
            Console.WriteLine($"Car ID : {vehicleId}");
            Console.WriteLine($"Car brand : {brand}");
            Console.WriteLine($"Car price : {price}");
            Console.WriteLine($"Car number of doors : {numberOfDoors}");
            Console.WriteLine($"Car fuel type : {fuelType}");
        }
    }

    public class Motorcycle : Vehicle
    {
        public int engineCapacity { get; set; }
        public string type { get; set; }

        public Motorcycle(string vehicleId, string brand, double price, int engineCapacity, string type) : base(vehicleId, brand, price)
        {
            base.displayInfo();
            this.engineCapacity = engineCapacity;
            this.type = type;
        }

        public override void displayInfo()
        { 
            Console.WriteLine($"Motorcycle ID : {vehicleId}");
            Console.WriteLine($"Motorcycle brand : {brand}");
            Console.WriteLine($"Motorcycle price : {price}");
            Console.WriteLine($"Motorcycle number of doors : {engineCapacity}");
            Console.WriteLine($"Motorcycle fuel type : {type}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("V001", "GenericBrand", 5000.00);
            Car car = new Car("C001", "Toyota", 30000.00, 4, "Petrol");
            Motorcycle motorcycle = new Motorcycle("M001", "Harley-Davidson", 20000.00, 1200, "Cruiser");

            Vehicle.showVehicleDetails(vehicle);
            Vehicle.showVehicleDetails(car);
            Vehicle.showVehicleDetails(motorcycle);

            Console.WriteLine($"Total number of vehicles: {Vehicle.vehicleCount}");
        }
    }
}
