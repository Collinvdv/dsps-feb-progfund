namespace week10_assignment;

class Program
{
    static void Main(string[] args)
    {
        //string assignment = Console.ReadLine();
        string assignment = "06 Reverse";

        switch (assignment)
        {
            case "04 Largest":
                Largest();
                break;
            case "06 Even or Odd":
                EvenOrOd();
                break;
            case "06 Reverse":
                Reverse();
                break;
        }
    }

    static void Largest()
    {
        // O: Give the name of the assignment
        // I: 04 Largest
        // I: -28
        // I: 19
        // I: 37
        // I: 508
        // I: -302
        // I: X
        // O: 508
        string command = Console.ReadLine();
        int maxNumber;
        Boolean checkParsing = int.TryParse(command, out maxNumber);

        if (checkParsing)
        {
            while (command != "x")
            {
                if (Convert.ToInt16(command) > maxNumber)
                {
                    maxNumber = Convert.ToInt16(command);
                }

                command = Console.ReadLine();
            }
        }
        Console.WriteLine(maxNumber);
    }

    static void EvenOrOd()
    {
        //
        // I: 06 Even or Odd
        // I: 5 -2 3 18 99 27 4 16
        // O: Odd Even Odd Even Odd Odd Even Even
        //
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        foreach(string numberStr in numbers)
        {
            int number = Convert.ToInt16(numberStr);
            Console.WriteLine(number);
            if (number % 2 == 0 )
            {
                Console.Write("Even ");
            } else
            {
                Console.Write("Odd ");
            }
        }
    }

    static void Reverse()
    {
        string input = "Once I make my move, the Queen will take me. Then you're free to check the king.";
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            Console.Write(ReverseWord(word) + " ");
        }
        Console.WriteLine("");
    }

    static string ReverseWord(string word)
    {
        string reversedWord = "";
        for(int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return reversedWord;
    }
}


//
// O: Welcome to our C3 programma


// I: 06 Reverse
// I: 
// O: ecnO I ekam ym ,evom eht neeuQ lliw ekat .em nehT er'uoy eerf ot kcehc eht .gnik
// 
