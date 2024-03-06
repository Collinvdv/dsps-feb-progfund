namespace week3_speed_camera;
class Program
{
    static void Main(string[] args)
    {
        // The speed camera can be in different zones.
        // The first input will be which zone it is placed

        // O: What zone is the speed camera installed (50, 90, 120)
        // I: 50
        // O: The speed camera is installed in zone 50
        // O: In zone 50 the maximum speedlimit is 55
        // O: Waiting for the first car
        // I: 60
        // O: Fine is 20 EUROS

        // O: What zone is the speed camera installed (50, 90, 120)
        // I: 50
        // O: The speed camera is installed in zone 50
        // O: In zone 50 the maximum speedlimit is 55
        // O: Waiting for the first car
        // I: 110
        // O: Give me your driver license, you fool!

        // Asking which zone
        Console.WriteLine("What zone is the speed camera installed (50, 90, 120)");
        double zone = Convert.ToInt16(Console.ReadLine());

        // Calculating the speedlimit
        double speedlimit = 0;
        if (zone == 50)
        {
            speedlimit = zone + (zone / 100 * 10);
        } else if (zone == 90)
        {
            speedlimit = zone + (zone / 100 * 15);
        } else
        {
            speedlimit = zone + (zone / 100 * 20);
        }

        Console.WriteLine($"The speed camera is installed in zone {zone}");
        Console.WriteLine($"In zone {zone} the maximum speedlimit is {speedlimit}");

        // Checking speed of the car and fining them if needed
        Console.WriteLine("Waiting for the first car");
        int speed = Convert.ToInt16(Console.ReadLine());

        if (speed > (speedlimit * 2))
        {
            Console.WriteLine("Give me your driver licens, broo");
        } else if (speed > speedlimit)
        {
            // The speed of the car is over the speedlimit,
            // so i need to check which zone
            if (zone == 50)
            {
                Console.WriteLine("The fine is 20 euros");
            } else if (zone == 90)
            {
                Console.WriteLine("The fine is 100 euros");
            } else
            {
                Console.WriteLine("The fine is 300 euros");
            }
        } else
        {
            Console.WriteLine("All good");
        }

    }
}

