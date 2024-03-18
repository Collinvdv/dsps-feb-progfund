using System;
using System.IO;

namespace week5_reading;

class Program
{
    static void Main(string[] args)
    {
        int amountOfVotesTrump = 0;
        int amountOfVotesBiden = 0;

        // Reading a file
        StreamReader reader = File.OpenText("votes.txt");

        // Reading by line
        string line = reader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            if (line.Contains("trump"))
            {
                amountOfVotesTrump++;
            }

            if (line.Contains("biden"))
            {
                amountOfVotesBiden++;
            }

            line = reader.ReadLine();
        }

        double totalAmountOfVotes = amountOfVotesTrump + amountOfVotesBiden;
        Console.WriteLine($"Votes for trum is {amountOfVotesTrump / totalAmountOfVotes * 100}");
        Console.WriteLine($"Votes for biden is {amountOfVotesBiden / totalAmountOfVotes * 100}");

        // Close
        reader.Close();
    }
}

