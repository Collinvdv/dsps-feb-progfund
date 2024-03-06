using System;

namespace week1_assignment_hello_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");
            string firstname = Console.ReadLine();
            Console.WriteLine("What's your last name? ");
            string lastname = Console.ReadLine();
            Console.WriteLine($"Hello {firstname} {lastname}");
        }
    }
}