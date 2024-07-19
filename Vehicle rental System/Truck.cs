// Truck.cs
public class Truck : Vehicle
{
    // Truck-specific properties
    public double Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Override DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity} tons");
        Console.WriteLine($"Truck Type: {TruckType}");
        Console.WriteLine($"Four Wheel Drive: {FourWheelDrive}");
    }
}
