using new_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Alice";
            Console.WriteLine("Please enter a name:");
            person.Age = 90;
            Console.WriteLine($"The person's name and agge is: {person.Name} and {person.Age}");

        }
    }
}
