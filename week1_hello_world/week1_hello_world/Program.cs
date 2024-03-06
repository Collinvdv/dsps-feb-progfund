using System;

namespace week1_hello_world;
class Program
{
    static void Main(string[] args)
    {

        string firstname = Console.ReadLine();
        string lastname = Console.ReadLine();
        string fullname = $"Fullname is firstname {lastname}";
        Console.WriteLine(fullname);
        //Console.Write(" is awesome");
        //This is beautiful code
        //Console.WriteLine("DEF");

        //Int16 age = Convert.ToInt16(Console.ReadLine());
        //Console.WriteLine(age + 10);

    }
}

