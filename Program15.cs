using System;

class Payment
{
    public double Amount;
    public string Date;

    public void ReadPaymentDetails()
    {
        Console.Write("Enter Payment Amount: ");
        Amount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Payment Date (DD/MM/YYYY): ");
        Date = Console.ReadLine();
    }

    public virtual void ProcessPayment()
    {
        Console.WriteLine("Processing generic payment...");
    }
}

class CreditCardPayment : Payment
{
    public string CardNumber;
    public string CardHolderName;

    public void ReadCreditCardDetails()
    {
        ReadPaymentDetails();
        Console.Write("Enter Card Number: ");
        CardNumber = Console.ReadLine();
        Console.Write("Enter Card Holder Name: ");
        CardHolderName = Console.ReadLine();
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("\n--- Credit Card Payment ---");
        Console.WriteLine("Amount: " + Amount);
        Console.WriteLine("Date: " + Date);
        Console.WriteLine("Card Number: " + CardNumber);
        Console.WriteLine("Card Holder: " + CardHolderName);
        Console.WriteLine("Credit Card Payment Processed Successfully!");
    }
}

class UPIPayment : Payment
{
    public string UPIId;
    public string BankName;

    public void ReadUPIDetails()
    {
        ReadPaymentDetails();
        Console.Write("Enter UPI ID: ");
        UPIId = Console.ReadLine();
        Console.Write("Enter Bank Name: ");
        BankName = Console.ReadLine();
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("\n--- UPI Payment ---");
        Console.WriteLine("Amount: " + Amount);
        Console.WriteLine("Date: " + Date);
        Console.WriteLine("UPI ID: " + UPIId);
        Console.WriteLine("Bank Name: " + BankName);
        Console.WriteLine("UPI Payment Processed Successfully!");
    }
}

class Program
{
    static void Main()
    {
        CreditCardPayment credit = new CreditCardPayment();
        Console.WriteLine("Enter Credit Card Payment Details:");
        credit.ReadCreditCardDetails();
        credit.ProcessPayment();

        Console.WriteLine();

        UPIPayment upi = new UPIPayment();
        Console.WriteLine("Enter UPI Payment Details:");
        upi.ReadUPIDetails();
        upi.ProcessPayment();
    }
}


