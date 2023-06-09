using System;

internal class Program
{
    public enum VehicleType
    {
        Car,
        Truck,
        Bus,
        Motorcycle
    }

    public class Engine
    {
        public string Model { get; set; }
        public int Horsepower { get; set; }

        public Engine(string model, int horsepower)
        {
            Model = model;
            Horsepower = horsepower;
        }
    }

    public class Body
    {
        public string Color { get; set; }
        public int NumDoors { get; set; }

        public Body(string color, int numDoors)
        {
            Color = color;
            NumDoors = numDoors;
        }
    }

    // Vehicle class
    public class Vehicle<TVehicleType, TEngine, TBody>
        where TEngine : Engine
        where TBody : Body
    {
        public TVehicleType Type { get; set; }
        public TEngine Engine { get; set; }
        public TBody Body { get; set; }

        public Vehicle(TVehicleType type, TEngine engine, TBody body)
        {
            Type = type;
            Engine = engine;
            Body = body;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Engine: {Engine.Model} ({Engine.Horsepower} HP)");
            Console.WriteLine($"Body: {Body.Color} with {Body.NumDoors} doors");
            Console.WriteLine();
        }
    }

    private static void Main(string[] args)
    {
        var car = new Vehicle<VehicleType, Engine, Body>(VehicleType.Car, new Engine("V6", 200), new Body("Red", 4));
        var truck = new Vehicle<VehicleType, Engine, Body>(VehicleType.Truck, new Engine("V8", 350), new Body("Blue", 2));
        var bus = new Vehicle<VehicleType, Engine, Body>(VehicleType.Bus, new Engine("Bus Engine", 300), new Body("Yellow", 3));
        var motorcycle = new Vehicle<VehicleType, Engine, Body>(VehicleType.Motorcycle, new Engine("Motor Engine", 100), new Body("Black", 0));

        // Displaying vehicle information
        car.DisplayInfo();
        truck.DisplayInfo();
        bus.DisplayInfo();
        motorcycle.DisplayInfo();
    }
}
