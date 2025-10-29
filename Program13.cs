using System;

class BankAccount
{
    protected double balance;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + balance);
    }
}

class SavingsAccount : BankAccount
{
    double interestRate;

    public SavingsAccount(double rate)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine("Interest Added: " + interest);
    }
}

class Book
{
    public string Title;
    public string Author;

    public void ReadBookDetails()
    {
        Console.Write("Enter Book Title: ");
        Title = Console.ReadLine();
        Console.Write("Enter Author Name: ");
        Author = Console.ReadLine();
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }
}

class EBook : Book
{
    public double FileSize;
    public string Format;

    public void ReadEBookDetails()
    {
        ReadBookDetails();
        Console.Write("Enter File Size (in MB): ");
        FileSize = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Format (e.g., PDF, EPUB): ");
        Format = Console.ReadLine();
    }

    public void DisplayEBookDetails()
    {
        DisplayBookDetails();
        Console.WriteLine("File Size: " + FileSize + " MB");
        Console.WriteLine("Format: " + Format);
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount account = new SavingsAccount(5.0);
        account.Deposit(1000);
        account.AddInterest();
        account.Withdraw(300);
        account.ShowBalance();

        Console.WriteLine();

        EBook ebook = new EBook();
        ebook.ReadEBookDetails();
        Console.WriteLine("\nE-Book Details:");
        ebook.DisplayEBookDetails();
    }
}
