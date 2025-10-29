using System;

class NumberCheck
{
    int num;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayResult()
    {
        if (num % 2 == 0)
            Console.WriteLine(num + " is an Even number.");
        else
            Console.WriteLine(num + " is an Odd number.");
    }
}

class Program
{
    static void Main()
    {
        NumberCheck obj = new NumberCheck();
        obj.ReadNumber();
        obj.DisplayResult();
    }
}
