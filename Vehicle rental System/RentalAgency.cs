﻿// RentalAgency.cs
using System;
using System.Collections.Generic;

public class RentalAgency
{
    // Properties
    private List<Vehicle> Fleet { get; set; } = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; }

    // Methods
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (Fleet.Contains(vehicle))
        {
            Fleet.Remove(vehicle);
            TotalRevenue += vehicle.RentalPrice * days;
            Console.WriteLine($"Vehicle rented: {vehicle.Model} for {days} days.");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
