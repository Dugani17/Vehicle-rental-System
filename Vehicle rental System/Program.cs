// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create instances of vehicles
        Car car = new Car
        {
            Model = "Model S",
            Manufacturer = "Tesla",
            Year = 2022,
            RentalPrice = 100m,
            Seats = 5,
            EngineType = "Electric",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Ram 1500",
            Manufacturer = "Dodge",
            Year = 2021,
            RentalPrice = 120m,
            Capacity = 6,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Street Triple",
            Manufacturer = "Triumph",
            Year = 2023,
            RentalPrice = 70m,
            EngineCapacity = 765,
            FuelType = "Petrol",
            HasFairing = true
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
        rentalAgency.RentVehicle(truck, 5);

        // Display total revenue
        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue:C}");

        // Display the fleet after renting a vehicle
        Console.WriteLine("Fleet Details After Renting a Truck:");
        rentalAgency.DisplayFleet();
    }
}
