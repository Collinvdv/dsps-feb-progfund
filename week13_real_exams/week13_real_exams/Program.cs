using System.Xml.Linq;

namespace week13_real_exams;

class Program
{
    static void Main(string[] args)
    {
        string task = Console.ReadLine();

        switch (task)
        {
            case "trial1":
                Trial1();
                break;

            case "trial2":
                Trial2();
                break;

            default:
                Console.WriteLine("Don't know the assignment");
                break;

        }
    }

    static void Trial1()
    {
        // Cleaning the data
        List<string> names = CleanData();

        // Search relative names
        string input = Console.ReadLine();
        List<string> finalNames = new List<string>();

        foreach(string name in names)
        {
            // name = "Mary"
            bool matchWord = true;

            foreach(char character in input)
            {
                if (name.Contains(character) == false)
                {
                    matchWord = false;
                }
            }

            if (matchWord)
            {
                finalNames.Add(name);
            }
        }


        finalNames.Sort();

        if (finalNames.Count == 0)
        {
            Console.WriteLine("not found");
        } else
        {
            foreach(string name in finalNames)
            {
                Console.Write($"{name} ");
            }
        }
    }

    static void Trial2()
    {
        string nbr = Console.ReadLine(); // "808"
        int nbrAsInt = Convert.ToInt16(nbr);
        bool isPalindrome = false;

        if (nbrAsInt < 0)
        {
            Console.WriteLine("crazy input");
        } else
        {
            while (isPalindrome == false)
            {
                nbrAsInt++;

                isPalindrome = IsPalindrome(nbrAsInt);

                if (isPalindrome)
                {

                    Console.WriteLine($"The next palindrome is {nbrAsInt}");
                }
            }

        } 

    }

    static string RemoveQuotes(string input)
    {
        string cleanedName = "";

        foreach (char character in input)
        {
            if (character != '"')
            {
                cleanedName += character;
            }
        }

        return cleanedName;
    }

    static List<string> CleanData()
    {
        string rawNames = File.ReadAllText("names.txt");
        string[] rawNamesList = rawNames.Split(',');

        List<string> names = new List<string>();
        foreach (string name in rawNamesList)
        {
            names.Add(RemoveQuotes(name));
        }

        return names;
    }

    static string Reverse(string word)
    {
        string reversedWord = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }

        return reversedWord;
    }

    static bool IsPalindrome(int nbr)
    {
        string nbrAsString = Convert.ToString(nbr);
        string reversedString = Reverse(nbrAsString);
        return nbrAsString == reversedString;
    }
}

