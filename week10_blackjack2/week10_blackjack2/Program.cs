namespace week10_blackjack2;

class Program
{
    static void Main(string[] args)
    {
        // Ask for user cards
        int userScore = UserCards();
        Console.WriteLine($"Total points user: {userScore}");

        // Ask for computer cards
        int computerScore = ComputerCards();
        Console.WriteLine($"Total points pc: {computerScore}");

        // Declare winner
        DeclareWinner(userScore, computerScore);
    }

    static void DeclareWinner(int userScore, int computerScore)
    {
        if (
            (userScore > computerScore && userScore <= 21)
            ||
            (userScore <= 21 && computerScore > 21)
          )
        {
            Console.WriteLine("User won");
        } else if
            (
                (computerScore > userScore && computerScore < 21)
                ||
                (computerScore <= 21 && userScore > 21)
            )
        {
            Console.WriteLine("Computer won");
        } else
        {
            Console.WriteLine("draw");
        }
    }

    static int ComputerCards()
    {
        int total = 0;

        while (total < 16)
        {
            int randomCard = RandomCard();
            total += randomCard;
            Console.WriteLine(randomCard);
        }

        return total;
    }

    static int UserCards()
    {
        // O: You want a new card?
        // I: Y
        // O: 8
        // I: Y
        // O: 10
        // I: N
        // O: Total is 18

        // Ask if user wants to have a new card
        string userInput = Console.ReadLine();
        int total = 0;

        while (userInput != "N")
        {
            int randomCard = RandomCard();
            total += randomCard;
            Console.WriteLine(randomCard);
            // Ask if user wants to have a new card
            userInput = Console.ReadLine();
        }

        return total;
    }

    static int RandomCard()
    {
        Random rd = new Random();
        return rd.Next(1, 11);
    }

}



// Black jack with methods
// O: Welcome to blackjack
// O: You want a new card?
// I: Y
// O: 8
// I: Y
// O: 10
// I: N
// O: Total is 18
//
// O: Computer cards
// O: 6
// O: 10
// O: PC total is 16
// 
// O: User wins!




//
// O: Welcome to our C3 programma
// O: Give the name of the assignment
// I: 04 Largest
// I: -28
// I: 19
// I: 37
// I: 508
// I: -302
// I: X
// O: 508
//
// I: 06 Even or Odd
// I: 5 -2 3 18 99 27 4 16
// O: Odd Even Odd Even Odd Odd Even Even
//
// I: 06 Reverse
// I: Once I make my move, the Queen will take me. Then you're free to check the king.
// O: ecnO I ekam ym ,evom eht neeuQ lliw ekat .em nehT er'uoy eerf ot kcehc eht .gnik
// 

