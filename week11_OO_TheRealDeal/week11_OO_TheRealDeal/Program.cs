namespace week11_OO_TheRealDeal;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Person collin = new Person("Collin", new DateOnly(1991, 4, 16));
        Person renske = new Person("Renske", new DateOnly(2023, 7, 5));
        Doctor oetker = new Doctor("Oetker", new DateOnly(1970, 7, 5), "Department A");

        Fighter mcgregor = new Fighter("mcgregor", new DateOnly(1991, 4, 16), 170);
        Fighter aldo = new Fighter("aldo", new DateOnly(1992, 4, 16), 180);

        //mcgregor.Kick(aldo);
        //mcgregor.Kick(aldo);
        //mcgregor.Kick(aldo);
        //mcgregor.Kick(aldo);
        //oetker.Treat(aldo);
        //mcgregor.Kick(aldo);

        String persons = File.ReadAllText("persons.txt");
        Regex rx = new Regex(@"\b{6}\b");
        MatchCollection matches = rx.Matches(persons);
        Console.WriteLine(matches.Count + " matches found!");
    }
}
