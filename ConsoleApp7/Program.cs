using System;

// Define the Drivable interface
interface Drivable
{
    void Start();
    void Stop();
    void Drive();
}

// Implement the Drivable interface in the Car class
class Car : Drivable
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

// Implement the Drivable interface in the Bicycle class
class Bicycle : Drivable
{
    public void Start()
    {
        Console.WriteLine("Bicycle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stopped.");
    }

    public void Drive()
    {
        Console.WriteLine("Bicycle is being ridden.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Store objects in arrays
        Car[] cars = new Car[] { new Car(), new Car() };
        Bicycle[] bicycles = new Bicycle[] { new Bicycle(), new Bicycle() };

        // Invoke methods using foreach loop
        foreach (Car car in cars)
        {
            car.Start();
            car.Drive();
            car.Stop();
            Console.WriteLine();
        }

        foreach (Bicycle bicycle in bicycles)
        {
            bicycle.Start();
            bicycle.Drive();
            bicycle.Stop();
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}