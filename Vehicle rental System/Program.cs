// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create instances of vehicles
        Car car = new Car
        {
            Model = "Altroz",
            Manufacturer = "Tata",
            Year = 2022,
            RentalPrice = 30m,
            Seats = 5,
            EngineType = "Petrol",
            Transmission = "Manual",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Ace",
            Manufacturer = "Tata",
            Year = 2021,
            RentalPrice = 50m,
            Capacity = 1.5,
            TruckType = "Mini Truck",
            FourWheelDrive = false
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Pulsar",
            Manufacturer = "Bajaj",
            Year = 2023,
            RentalPrice = 20m,
            EngineCapacity = 150,
            FuelType = "Petrol",
            HasFairing = false
        };

        // Create rental agency
        RentalAgency rentalAgency = new RentalAgency();

        // Add vehicles to the fleet
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Display the fleet
        Console.WriteLine("Fleet Details:");
        rentalAgency.DisplayFleet();

        // Rent a vehicle
        rentalAgency.RentVehicle(car, 7);

        // Display total revenue
        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue:C}");

        // Display the fleet after renting a vehicle
        Console.WriteLine("Fleet Details After Renting a Car:");
        rentalAgency.DisplayFleet();
    }
}
