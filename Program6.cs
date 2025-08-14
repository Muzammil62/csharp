namespace ConsoleApp3
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }

        static bool IsLeapYear(int year)
        {
           
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}