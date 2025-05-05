using System;
using System.Collections.Generic;

public class VehicleRegistry
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void ListCars()
    {
        foreach (var car in cars)
        {
            car.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void RegisterAll(string ownerName)
    {
        foreach (var car in cars)
        {
            car.Register(ownerName);
        }
    }
}
