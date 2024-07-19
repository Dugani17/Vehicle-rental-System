// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create instances of vehicles
        Car car = new Car
        {
            Model = "Civic",
            Manufacturer = "Honda",
            Year = 2020,
            RentalPrice = 50m,
            Seats = 5,
            EngineType = "V4",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "F-150",
            Manufacturer = "Ford",
            Year = 2019,
            RentalPrice = 80m,
            Capacity = 5,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Ninja",
            Manufacturer = "Kawasaki",
            Year = 2021,
            RentalPrice = 40m,
            EngineCapacity = 600,
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
        rentalAgency.RentVehicle(car, 3);

        // Display total revenue
        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue:C}");

        // Display the fleet after renting a vehicle
        Console.WriteLine("Fleet Details After Renting a Car:");
        rentalAgency.DisplayFleet();
    }
}
