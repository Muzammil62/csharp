using System;

namespace checkingbalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 1000.00m; // Starting balance

            Console.WriteLine("Welcome to Checking Balance Program!");
            Console.WriteLine($"Your current balance is: ${balance:F2}");

            Console.Write("Enter amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal deposit))
            {
                balance += deposit;
                Console.WriteLine($"Deposited: ${deposit:F2}");
            }

            Console.Write("Enter amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdraw))
            {
                if (withdraw <= balance)
                {
                    balance -= withdraw;
                    Console.WriteLine($"Withdrew: ${withdraw:F2}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }

            Console.WriteLine($"Final balance: ${balance:F2}");
        }
    }
}
