namespace week5_eurosong;

class Program
{
    static void Main(string[] args)
    {
        // Read line by line
        StreamReader reader = File.OpenText("eurosong.txt");

        string line = reader.ReadLine();
        int spainPoints = 0;
        int belgiumPoints = 0;
        int netherlandsPoints = 0;

        while (line != null)
        {
            // Split up a string FE "spain 12"
            // by country = "spain" points = 12
            string country = line.Split(' ')[0];
            int points = Convert.ToInt16(line.Split(' ')[1]);

            if (country == "belgium")
            {
                belgiumPoints += points;
            } else if (country == "netherlands")
            {
                netherlandsPoints += points;
            } else if (country == "spain")
            {
                spainPoints += points;
            }
            // Read in the next line
            line = reader.ReadLine();
        }

        Console.WriteLine($"Belgium has {belgiumPoints} points");
        Console.WriteLine($"Netherlands has {netherlandsPoints} points");
        Console.WriteLine($"Spain has {spainPoints} points");
        
    }
}

