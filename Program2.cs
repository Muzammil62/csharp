using System;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours parked: ");
            if (double.TryParse(Console.ReadLine(), out double hours))
            {
                double ratePerHour = 2.0;
                double totalFee = Math.Ceiling(hours) * ratePerHour;
                Console.WriteLine($"Total parking fee: ${totalFee:0.00}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}
