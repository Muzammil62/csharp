using System;

abstract class Dessert
{
    public void AddSugar()
    {
        Console.WriteLine("Adding sugar...");
    }

    public abstract void Prepare();

    public void Serve()
    {
        Console.WriteLine("Serving to the customer.\n");
    }
}

class IceCream : Dessert
{
    public override void Prepare()
    {
        Console.WriteLine("Churning and freezing the mixture...");
    }
}

class Cake : Dessert
{
    public override void Prepare()
    {
        Console.WriteLine("Baking in the oven...");
    }
}

class GulabJamun : Dessert
{
    public override void Prepare()
    {
        Console.WriteLine("Frying dough balls and soaking in syrup...");
    }
}

class Program
{
    static void Main()
    {
        Dessert iceCream = new IceCream();
        Dessert cake = new Cake();
        Dessert gulabJamun = new GulabJamun();

        iceCream.AddSugar();
        iceCream.Prepare();
        iceCream.Serve();

        cake.AddSugar();
        cake.Prepare();
        cake.Serve();

        gulabJamun.AddSugar();
        gulabJamun.Prepare();
        gulabJamun.Serve();
    }
}
