using System;

interface IVehicle
{
    void Start();
    void Stop();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike started.");
    }

    public void Stop()
    {
        Console.WriteLine("Bike stopped.");
    }
}

class Bus : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bus started.");
    }

    public void Stop()
    {
        Console.WriteLine("Bus stopped.");
    }
}

class Program
{
    static void Main()
    {
        IVehicle car = new Car();
        IVehicle bike = new Bike();
        IVehicle bus = new Bus();

        car.Start();
        car.Stop();

        bike.Start();
        bike.Stop();

        bus.Start();
        bus.Stop();
    }
}
 
