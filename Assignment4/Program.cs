using Assignment4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Car car = new Car();
        car.Brand = "Ford";
        Console.WriteLine(car.Brand);
    }

    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public EngineType EngineType { get; set; }
        public int Speed { get; set; }
        public int MaximumSpeed { get; set; }
    }

    public enum EngineType
    {
        Electric,
        Combustion
    }

    public class Car : Vehicle
    {
        public string BodyType { get; set; }
        public string DashboardMileage { get; set; }
        public string VIN { get; set; }
        public string LicenseNumber { get; set; }
        public int NumberOfDoors { get; set; }
    }

    public class Truck : Vehicle
    {
        public string BodyType { get; set; }
        public int LoadCapacity { get; set; }
    }

    public class Bus : Vehicle
    {
        public int SeatingCapacity { get; set; }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
    }

}