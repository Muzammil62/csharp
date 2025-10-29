using System;

class SquareNumber
{
    int num;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplaySquare()
    {
        Console.WriteLine("Square of " + num + " is: " + (num * num));
    }
}

class Program
{
    static void Main()
    {
        SquareNumber obj = new SquareNumber();
        obj.ReadNumber();
        obj.DisplaySquare();
    }
}
 
