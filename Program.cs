using System;

namespace icecream1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flavors = { "Vanilla", "Chocolate", "Strawberry", "Mint" };

            Console.WriteLine("Welcome to the Ice Cream Shop!");
            Console.WriteLine("Available flavors:");
            for (int i = 0; i < flavors.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {flavors[i]}");
            }

            Console.Write("Please select a flavor (1-4): ");
            int flavorChoice;
            while (!int.TryParse(Console.ReadLine(), out flavorChoice) || flavorChoice < 1 || flavorChoice > flavors.Length)
            {
                Console.Write("Invalid choice. Please select a flavor (1-4): ");
            }

            Console.Write("How many scoops would you like? ");
            int scoops;
            while (!int.TryParse(Console.ReadLine(), out scoops) || scoops < 1)
            {
                Console.Write("Invalid number. Please enter a positive integer: ");
            }

            Console.WriteLine($"\nOrder Summary:");
            Console.WriteLine($"Flavor: {flavors[flavorChoice - 1]}");
            Console.WriteLine($"Scoops: {scoops}");
            Console.WriteLine("Thank you for your order!");
        }
    }
}
