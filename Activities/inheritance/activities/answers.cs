public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public virtual void StartEngine()
    {
        Console.WriteLine("Starting the engine of a generic vehicle.");
    }
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Starting the car's engine.");
    }
}

public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Starting the motorcycle's engine.");
    }
}