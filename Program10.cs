using System;

class DigitSum
{
    int num;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateSum()
    {
        int sum = 0, temp = num;
        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        Console.WriteLine("Sum of digits of " + num + " is: " + sum);
    }
}

class Program
{
    static void Main()
    {
        DigitSum obj = new DigitSum();
        obj.ReadNumber();
        obj.CalculateSum();
    }
}
