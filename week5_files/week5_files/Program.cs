namespace week5_files;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // Count from 0 till 10
        //for(int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        // Count down from 100 to 80
        //for(int i = 100; i >=80; i--)
        //{
        //    Console.WriteLine(i);
        //}

        // I: woop woop
        // O: the sound of the police
        // I: woop woop
        // O: the sound of the police
        // I: stop
        // O: thx bye xxx
        //string commando = Console.ReadLine();

        //while (commando != "stop")
        //{
        //    if (commando == "woop woop")
        //    {
        //        Console.WriteLine("the sound of the police");
        //    }

        //    // ask it again
        //    commando = Console.ReadLine();
        //}
        //Console.WriteLine("thx bye xxx");




        // ZOMBIE ACOPOLYPS
        // Only when the user say HUMAN, we will let them in

        // FE:
        // I: human
        // O: Enter

        // I: zombeeeeeee
        // O: Go away, whaaaaah
        //string input = Console.ReadLine();

        //if (input == "human")
        //{
        //    Console.WriteLine("enter");
        //} else
        //{
        //    Console.WriteLine("Go away, whaaaah");
        //}

        string input = Console.ReadLine();
        int chances = 3;

        while (input != "human")
        {
            if (input != "human")
            {
                chances--;
                Console.WriteLine($"You have {chances} chances left");
            }

            if (chances == 0)
            {
                Console.WriteLine("BAM BAM, you are dead");
                break;
            }
            // Asking input
            input = Console.ReadLine();
        }

        if (input == "human")
        {
            Console.WriteLine("enter");
        }


    }
}




// ZOMBIE ACOPOLYPS
// Only when the user say HUMAN, we will let them in
// They have 3 chances

// FE:

// Scenario 1
// I: human
// O: Enter


// Scenario 2
// I: zombeeeeeee
// O: You are not a human, you got 2 chances left.

// I: zombeeeeeee
// O: You are not a human, you got 1 chances left.

// I: zombeeeeeee
// O: BAM YOU ARE DEAD













//
// Multiplication table
//
// I: 6
// O: 0 X 6 = 0
// O: 1 X 6 = 6
// ..
// O: 10 X 6 = 60










