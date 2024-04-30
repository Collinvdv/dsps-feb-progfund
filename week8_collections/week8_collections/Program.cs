namespace week8_collections;

class Program
{
    static void Main(string[] args)
    {
        // List of students
        //string[] students = new string[3];

        //students[0] = "Collin";
        //students[1] = "Lisa";
        //students[2] = "Renske";

        //for (int i = 0; i < students.Length; i++)
        //{
        //    Console.WriteLine(students[i]);
        //}

        // O: Add students till you say stop
        // I: Lisa
        // I: Collin
        // I: Renske
        // I: Stop
        // O: The amount of students in the list is 3

        // Lisa, Collin, Renske
        // ["lisa", "collin", "renske"]

        //string input = Console.ReadLine();
        //string people = "";

        //// Get all the names and it put in a big string
        //while (input != "stop")
        //{
        //    // Create a big string 6, 10, 5.5,
        //    people += input + ",";

        //    // Ask a new person
        //    input = Console.ReadLine();
        //}

        //// "collin,renske,lisa,"
        //// "collin,renske,lisa"

        //string inputWithoutCommaAtTheEnd = people.TrimEnd(',');
        //string[] persons = inputWithoutCommaAtTheEnd.Split(',');
        //Console.WriteLine(persons.Length);

        //List<string> persons = new List<string>();
        //persons.Add("Collin");
        //Console.WriteLine(persons[0]);
        //Console.WriteLine(persons.Count);

        // O: Add students till you say stop
        // I: Lisa
        // I: Collin
        // I: Renske
        // I: Stop
        // O: The amount of students in the list is 3
        // List<string> list = new List<string>();
        // .Add()

        //List<string> students = new List<string>();

        //string input = Console.ReadLine(); 

        //while (input != "stop")
        //{
        //    students.Add(input);

        //    input = Console.ReadLine();
        //}

        //Console.WriteLine(students.Count);

        //Dictionary<int, string> names = new Dictionary<int, string>();

        //names.Add(20, "Collin");
        //names.Add(21, "Lisa");
        //names.Add(22, "Renske");

        //Console.WriteLine(names.Keys);
        //Dictionary<int, int> namesDict = names.Keys;

        //foreach(KeyValuePair<int, string> name in names)
        //{
        //    Console.WriteLine(name.Value);
        //}



        // Table
        // collinvandervorst 1.94
        // lisavandervorst 1.73
        // renskevandervorst 0.82

        // Create a dictionairy
        // And at the end give me the average height
        //Dictionary<string, double> persons = new Dictionary<string, double>();

        //persons.Add("collinvandervorst", 1.94);
        //persons.Add("lisavandervorst", 1.73);
        //persons.Add("renskevandervorst", 0.82);

        //double total = 0;

        //foreach(double length in persons.Values)
        //{
        //    total += length;
        //}

        //double avg = total / persons.Count;
        //Console.WriteLine(avg);

        //Dictionary<string, List<double>> gradebook = new Dictionary<string, List<double>>();

        //gradebook.Add("col", new List<double>());
        //gradebook.Add("lis", new List<double>());
        //gradebook.Add("ren", new List<double>());

        //// col 2
        //gradebook["col"].Add(20);
        //gradebook["col"].Add(5);

        //// lis 1
        //gradebook["lis"].Add(20);

        //// ren 2
        //gradebook["ren"].Add(12);
        //gradebook["ren"].Add(12);


        // col 12.5
        // lis 20
        // ren 12
        //foreach (string name in gradebook.Keys)
        //{
        //    List<double> grades = gradebook[name];
        //    double total = 0;
        //    foreach (double grade in grades)
        //    {
        //        total += grade;
        //    }

        //    double avg = total / grades.Count;
        //    Console.WriteLine(name + " " + avg);
        //}

        Dictionary<string, Dictionary<string, string>> gradebook = new Dictionary<string, Dictionary<string, string>>();

        gradebook.Add("2", new Dictionary<string, string>());
        gradebook["2"].Add("name", "anthony");
        gradebook["2"].Add("date", "16/04/1991");


    }
}

