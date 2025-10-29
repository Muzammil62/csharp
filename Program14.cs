using System;

class Vehicle
{
    public string Model;
    public string Brand;
    public double RentalPricePerDay;

    public void ReadVehicleDetails()
    {
        Console.Write("Enter Vehicle Model: ");
        Model = Console.ReadLine();
        Console.Write("Enter Vehicle Brand: ");
        Brand = Console.ReadLine();
        Console.Write("Enter Rental Price per Day: ");
        RentalPricePerDay = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Rental Price per Day: " + RentalPricePerDay);
    }
}

class Car : Vehicle
{
    public int NumberOfSeats;
    public string FuelType;

    public void ReadCarDetails()
    {
        ReadVehicleDetails();
        Console.Write("Enter Number of Seats: ");
        NumberOfSeats = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Fuel Type: ");
        FuelType = Console.ReadLine();
    }

    public void DisplayCarDetails()
    {
        DisplayVehicleDetails();
        Console.WriteLine("Number of Seats: " + NumberOfSeats);
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

class Product
{
    public string Name;
    public double Price;

    public void ReadProductDetails()
    {
        Console.Write("Enter Product Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Product Price: ");
        Price = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }
}

class ElectronicProduct : Product
{
    public string Brand;
    public int Warranty;

    public void ReadElectronicDetails()
    {
        ReadProductDetails();
        Console.Write("Enter Brand: ");
        Brand = Console.ReadLine();
        Console.Write("Enter Warranty (in years): ");
        Warranty = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayElectronicDetails()
    {
        DisplayProductDetails();
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Warranty: " + Warranty + " years");
    }
}

class Smartphone : ElectronicProduct
{
    public string OS;
    public int Storage;

    public void ReadSmartphoneDetails()
    {
        ReadElectronicDetails();
        Console.Write("Enter Operating System: ");
        OS = Console.ReadLine();
        Console.Write("Enter Storage Capacity (in GB): ");
        Storage = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplaySmartphoneDetails()
    {
        DisplayElectronicDetails();
        Console.WriteLine("Operating System: " + OS);
        Console.WriteLine("Storage Capacity: " + Storage + " GB");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        Console.WriteLine("Enter Car Details:");
        car.ReadCarDetails();
        Console.WriteLine("\nCar Details:");
        car.DisplayCarDetails();

        Console.WriteLine();

        Smartphone phone = new Smartphone();
        Console.WriteLine("Enter Smartphone Details:");
        phone.ReadSmartphoneDetails();
        Console.WriteLine("\nSmartphone Details:");
        phone.DisplaySmartphoneDetails();
    }
}
 
