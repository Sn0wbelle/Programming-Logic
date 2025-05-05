using System;

class Program
{
    static void Main(string[] args)
    {
        VehicleRegistry registry = new VehicleRegistry();

        Car tesla = new Car("Tesla", "Model 4", 2024, true);
        Car camaro = new Car("Chevy", "Camaro", 2021, false);

        registry.AddCar(tesla);
        registry.AddCar(camaro);

        Console.WriteLine("Before Registration:");
        registry.ListCars();

        Console.WriteLine("Registering cars to Alice:");
        registry.RegisterAll("Alice");

        Console.WriteLine("\nAfter Registration (visual check):");
        registry.ListCars();
    }
}
