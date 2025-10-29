using System;

class Person
{
    string name;
    int age;

    public void ReadPerson()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.ReadPerson();
        p.DisplayPerson();
    }
}
