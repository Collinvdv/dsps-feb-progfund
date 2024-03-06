namespace week3_bouncer;
class Program
{
    static void Main(string[] args)
    {
        // Bouncer at tomorrowland 
        // ask the age of the user they need to be older
        // or equal than 18
        // and they have to be female
        // They can also pay more than 20 euros to enter. 

        // Example 1:
        // O: What is your age?
        // I: 18
        // O: What is your gender?
        // I: f
        // O: Do you got some bribemoney?
        // I: 0
        // O: Enter

        // Example 2:
        // O: What is your age?
        // I: 20
        // O: What is your gender?
        // I: m
        // O: Do you got some bribemoney?
        // I: 20
        // O: Enter
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("What is your gender?");
        string gender = Console.ReadLine();

        Console.WriteLine("Do you got some bribe money");
        int bribeMoney = Convert.ToInt16(Console.ReadLine());

        if ( (age > 18 && gender == "f") || bribeMoney >= 20)
        {
            Console.WriteLine("enter");
        } else
        {
            Console.WriteLine("Kick them out");
        }


    }
}

