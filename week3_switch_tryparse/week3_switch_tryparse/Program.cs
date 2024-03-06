namespace week3_switch_tryparse;
class Program
{
    static void Main(string[] args)
    {
        // I: 1
        // O: monday

        // I: 4
        // O: thursday

        // I: 10
        // O: You are a dumb person
        string userInput = Console.ReadLine();

        Int16 dayOfWeek;

        Boolean tryToParse = Int16.TryParse(userInput, out dayOfWeek);

        if (tryToParse == false)
        {
            Console.WriteLine("Not an integer");
        } else
        {
            switch(dayOfWeek)
            {
                case 1: // if (dayOfWeek == 1)
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("w");
                    break;
                default:
                    Console.WriteLine("No a day of the week");
                    break;
            }

        }
    }
}

