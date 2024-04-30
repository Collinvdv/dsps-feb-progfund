using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace week10_method;

class Program
{
    

    static void Main(string[] args)
    {
        //string fn = "Collin";
        //string ln = "Van der Vorst";
        //int age = 33;
        //SayHello(fn, ln, age);

        //SayHello("Renske", "Van der Vorst");

        ////string fullname = CreateFullname(fn, ln);

        //List<int> numbers = new List<int>();
        //numbers.Add(5);
        //numbers.Add(10);
        //numbers.Add(3);
        //numbers.Add(2);

        //PrintList(numbers);
        //PrintAndSortList(numbers);

        //Random rd = new Random();
        //Console.WriteLine(rd.Next(1, 11));
        //Console.WriteLine(rd.Next(1, 11));
        //Console.WriteLine(rd.Next(1, 11));
        //Console.WriteLine(rd.Next(1, 11));
        //Console.WriteLine(rd.Next(1, 11));
        //Console.WriteLine(rd.Next(1, 11));

        //List<string> students = new List<string>();

        //students.Add("BeardMeatsFood");
        //students.Add("Collin");
        //students.Add("Renske");

        //PrintList(students);

        string animal = "Mr. Chichuaha";

        ChangeAnimalName(ref animal);
        Console.WriteLine(animal);
    }

    static void ChangeAnimalName(ref string animal)
    {
        animal = "Mrs. Chicuaha";
    }

    static void PrintAndSortList(List<int> list)
    {
        list.Sort();

        foreach (int number in list)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static void PrintList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void PrintList(List<int> list)
    {
        foreach (int number in list)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static void SayHello(string firstname, string lastname, int age = 0)
    {
        Console.WriteLine($"Hello, I am {CreateFullname(firstname, lastname)}. I am {age} years old");
    }

    static string CreateFullname(string firstname, string lastname)
    {
        string fullname = firstname + " " + lastname;

        return fullname;

    }
}

//
// Methods explanation
//

