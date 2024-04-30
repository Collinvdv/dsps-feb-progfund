namespace week9_exceptions;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Recap list and dictionairy
        //string[] students = new string[4];

        //students[0] = "Collin";
        //students[1] = "Renske";
        //students[2] = "Lisa";
        //students[3] = "Sharon";

        //Console.WriteLine(students.Length);

        //List<string> students = new List<string>();

        //students.Add("Collin");
        //students.Add("Renske");
        //students.Add("Sharon");

        //students.RemoveAt(1);

        //Dictionary<string, double> persons = new Dictionary<string, double>();
        //persons.Add("Collin", 1.94);


        //Dictionary<string, List<double>> gradebook = new Dictionary<string, List<double>>();
        //gradebook.Add("collin", new List<double>() );

        //gradebook["collin"].Add(20);

        // Finishing the assignment
        //Dictionary<string, Dictionary<string, string>> yearbook = new Dictionary<string, Dictionary<string, string>>();
        //string commando = Console.ReadLine();

        //while (commando.ToLower() != "end")
        //{
        //    // Check if commando is equal to add,delete,adjust,end
        //    switch (commando.ToLower())
        //    {
        //        case "add":
        //            string name = Console.ReadLine();
        //            string age = Console.ReadLine();
        //            string dob = Console.ReadLine();
        //            string studentNbr = Console.ReadLine();

        //            yearbook.Add(studentNbr, new Dictionary<string, string>());
        //            yearbook[studentNbr].Add("Name", name);
        //            yearbook[studentNbr].Add("Age", age);
        //            yearbook[studentNbr].Add("Dob", dob);
        //            break;
        //        case "list":
        //            foreach (var student in yearbook)
        //            {
        //                Console.WriteLine("Studentnbr is " + student.Key);

        //                foreach (var attributes in student.Value)
        //                {
        //                    Console.WriteLine(attributes.Key + " : " + attributes.Value);
        //                }
        //            }
        //            break;
        //        case "delete":
        //            Console.WriteLine("Give me your studentnumber");
        //            string deletedStudentNbr = Console.ReadLine();
        //            yearbook.Remove(deletedStudentNbr);
        //            break;
        //        case "adjust":
        //            Console.WriteLine("Give me your studentnumber");
        //            string adjustStudentNbr = Console.ReadLine();
        //            string adjustName = Console.ReadLine();
        //            string adjustAge = Console.ReadLine();
        //            string adjustDob = Console.ReadLine();

        //            yearbook[adjustStudentNbr]["Name"] = adjustName;
        //            yearbook[adjustStudentNbr]["Age"] = adjustAge;
        //            yearbook[adjustStudentNbr]["Dob"] = adjustDob;

        //            break;
        //        default:
        //            Console.WriteLine("Wake up brooooh.");
        //            break;
        //    }

        //    // Ask it again
        //    commando = Console.ReadLine();
        //}

        // Exceptions theory



        Console.WriteLine("Welcome to soccer statistics");
        Console.WriteLine(" Following commands can be used [player, assists, goals, stop]");

        // Prepare a list of players
        StreamReader reader = File.OpenText("soccer.txt");

        string line = reader.ReadLine();
        List<string[]> data = new List<string[]>();

        while (line != null)
        {
            data.Add(line.Split(','));

            line = reader.ReadLine();
        }


        // Commando shizzl
        string commando = Console.ReadLine().ToLower();

        while (commando != "stop")
        {
            switch (commando)
            {
                case "player":
                    string playerId = Console.ReadLine();
                    foreach(string[] player in data)
                    {
                        Console.WriteLine(player[0]);
                        if (player[0] == playerId)
                        {
                            Console.WriteLine($"Name: {player[1]}");
                            Console.WriteLine($"Assist: {player[2]}");
                            Console.WriteLine($"Goals: {player[3]}");
                        }
                    }
                    break;
                case "assists":
                    int highestAmountOfAssits = 0;

                    foreach (string[] player in data)
                    {
                        int playerAssists = Convert.ToInt16(player[2]);

                        if (playerAssists > highestAmountOfAssits)
                        {
                            highestAmountOfAssits = playerAssists;
                        }
                    }

                    foreach (string[] player in data)
                    {
                        int playerAssists = Convert.ToInt16(player[2]);

                        if (playerAssists == highestAmountOfAssits)
                        {
                            Console.WriteLine($"Name of the player with the highest assists is {player[1]}");
                        }
                    }
                    Console.WriteLine("Something with player");
                    break;
                case "goals":
                    Console.WriteLine("Something with player");
                    break;
            }
            // Ask it again
            commando = Console.ReadLine().ToLower();
        }

        // Assignment exceptions football file
        // O: Welcome to soccer statistics
        // O:
        // ----------
        // I: player
        // O: What is the player id?
        // I: P1001
        // O: P1001 is Patricia Johnson
        // O: P1001 has 12 assists
        // O: P1001 has 18 GOALS
        // O: what is the next command?
        // ----------
        // I: player
        // O: What is the player id?
        // I: P2
        // O: Can not find the player in my file
        // O: what is the next command?
        // ----------
        // I: assists
        // O: Patricia Johnson has the most assists
        // O: what is the next command?
        // ----------
        // I: goals
        // O: Patricia Johnson has the most goals
        // O: what is the next command?
        // ----------
        // I: dribbles
        // O: Command is not known
        // O: what is the next command?
        // ----------
        // I: stop
        // O: Program will be stopped 
        // ----------
        //StreamReader reader = File.OpenText("soccer.txt");

        //string line = reader.ReadLine();

        //while (line != null)
        //{
        //    Console.WriteLine(line);

        //    line = reader.ReadLine();
        //}

        // Methods theory t
    }
}

