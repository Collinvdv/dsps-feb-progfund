using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Xml.Linq;

namespace week6_arrays;

class Program
{
    static void Main(string[] args)
    {
        //// Option 1
        //string[] goats2 = new string[3];
        //goats2[0] = "t-rex";
        //goats2[1] = "connie";
        //goats2[2] = "clyde";

        //// Option 2
        //string[] goats = { "T-rex", "Connie", "Clyde", "Angel"};
        //goats[2] = "John";

        //for (int index = 0; index < goats.Length; index++)
        //{
        //    Console.WriteLine(goats[index]);
        //}

        //
        // O: How many students?
        // I: 3
        // O: Student1 result is:
        // I: 10
        // O: Student2 result is:
        // I: 14
        // O: Student3 result is:
        // I: 18
        // O: Average is 14
        //
        //Console.WriteLine("How many students?");
        //int amountOfStudents = Convert.ToInt16(Console.ReadLine());

        //// Population of grades
        //double[] grades = new double[amountOfStudents];

        //for (int index = 0; index < amountOfStudents; index++)
        //{
        //    Console.WriteLine($"Student {index + 1} result is:");
        //    double grade = Convert.ToDouble(Console.ReadLine());

        //    grades[index] = grade;
        //}

        //// Calculation of total
        //double total = 0;

        //foreach (double grade in grades)
        //{
        //    total += grade;
        //}

        //double avg = total / amountOfStudents;
        //Console.WriteLine(avg);

        //string goats = Console.ReadLine(); // "trex connie clyde"
        //string[] listOfGoats = goats.Split(' ');
        //Console.WriteLine(listOfGoats[1]);

        //int rows = 2;
        //int columns = 3;
        //int[,] gradebook = new int[rows, columns];

        //// student collin
        //gradebook[0, 0] = 20;
        //gradebook[0, 1] = 20;
        //gradebook[0, 2] = 14;

        //// student lisa
        //gradebook[1, 0] = 8;
        //gradebook[1, 1] = 10;
        //gradebook[1, 2] = 6;

        //for (int row = 0; row < gradebook.GetLength(0); row++)
        //{
        //    Console.WriteLine($"The result of student {row + 1}");

        //    for (int column = 0; column < gradebook.GetLength(1); column++)
        //    {
        //        Console.WriteLine(gradebook[row, column]);
        //    }
        //}


        //// STAGGED ARRAY
        //int rows = 2;
        //int[][] gradebook = new int[rows][];

        //// Student number 1
        //gradebook[0] = new int[3];
        //gradebook[0][0] = 18;
        //gradebook[0][1] = 20;
        //gradebook[0][2] = 16;

        //// Student number 2
        //gradebook[1] = new int[2];
        //gradebook[1][0] = 8;
        //gradebook[1][1] = 10;

        //// loop and calculate avg per student
        //for (int row = 0; row < gradebook.Length; row++) {
        //    Console.WriteLine($"Student {row + 1}");

        //    int amountOfGrades = gradebook[row].Length;
        //    int total = 0;
        //    foreach (int grade in gradebook[row])
        //    {
        //        total += grade;
        //        Console.WriteLine(grade);
        //    }

        //    double avg = (double)total / amountOfGrades;
        //    Console.WriteLine(avg);
        //}



        // Read 5 numbers give the total (store everything in an array)
        // I: 4
        // I: 8
        // I: 6
        // I: 10
        // I: 20
        // O: Total is 48

        //int[] grades = new int[5];

        //// populating the array
        //for (int i = 0; i < grades.Length; i ++)
        //{
        //    grades[i] = Convert.ToInt16(Console.ReadLine()); 
        //}

        //// know total
        //int total = 0;
        //for (int i = 0; i < grades.Length; i++)
        //{
        //    total = grades[i];
        //}

        //foreach (int grade in grades)
        //{
        //    total += grade;
        //}
        //Console.WriteLine($"Total is {total}");



        //
        // Best day of the week
        // Monday = 5.5
        // Tuesday = 10
        // Wednesday = 7
        // Thursday = 12
        // Friday = 15
        // Saturday = 22
        // Sunday = 10
        //
        // O: Hotest day of the week is Saturday with 22
        // O: Coldest day of the week is Monday with 5.5
        //
        //double hottest = -10000000;
        //double coldest = 10000000;
        //int hottestDay = -1;
        //int coldestDay = -1;

        //double[] temperatures ={
        //    5.5,
        //    10,
        //    7,
        //    12,
        //    15,
        //    22,
        //    10
        //};

        //string[] days =
        //{
        //    "monday",
        //    "tuesday",
        //    "wedneday",
        //    "thursday",
        //    "friday",
        //    "saturday",
        //    "sunday"
        //};

        //for (int i = 0; i< temperatures.Length; i++)
        //{
        //    if (temperatures[i] > hottest)
        //    {
        //        hottest = temperatures[i];
        //        hottestDay = i;
        //    }

        //    if (temperatures[i] < coldest)
        //    {
        //        coldest = temperatures[i];
        //        coldestDay = i;
        //    }
        //}

        //Console.WriteLine($"Coldest is {coldest} and it was a {days[coldestDay]}");
        //Console.WriteLine($"Hottest is {hottest} and it was a {days[coldestDay]}");

        //
        // Accountancy
        // Quarter1: 1500 -1000 -300
        // Quarter2: 1700 -800 -300
        // Quarter3: 5000 -1000 300
        // Quarter4: 1500 1000 -300
        //
        // O: Result quarter 1 is 200
        // O: Result quarter 2 is 600
        // O: Result quarter 3 is 4300
        // O: Result quarter 4 is 2200
        // O: Total result is 7300
        //
        double[,] accountancy = new double[4, 3];

        // Q1
        accountancy[0, 0] = 1500;
        accountancy[0, 1] = -1000;
        accountancy[0, 2] = -300;

        // Q2
        accountancy[1, 0] = 1700;
        accountancy[1, 1] = -800;
        accountancy[1, 2] = -300;

        // Q3
        accountancy[2, 0] = 5000;
        accountancy[2, 1] = -1000;
        accountancy[2, 2] = -300;
        
        // Q4
        accountancy[3, 0] = 1500;
        accountancy[3, 1] = 1000;
        accountancy[3, 2] = -300;

        // quarter
        for (int quarter = 0; quarter < accountancy.GetLength(0); quarter++)
        {
            
            double totalQuarter = 0; 
            for (int order = 0; order < accountancy.GetLength(1); order++)
            {
                totalQuarter += accountancy[quarter, order];
            }

            Console.WriteLine($"Quarter {quarter + 1} sum is {totalQuarter}");
        }

        double total = 0;
        foreach (double amount in accountancy)
        {
            total += amount;
        }
        Console.WriteLine(total);

    }
}





// Assignments












//Write a C# Sharp program to find the maximum and minimum elements in an array.
//Test Data :
//Input the number of elements to be stored in the array :3
//Input 3 elements in the array :
//element - 0 : 45
//element - 1 : 25
//element - 2 : 21
//Expected Output :
//Maximum element is : 45
//Minimum element is : 21









// Accountancy part 2
// Read files 2020.txt, 2021.txt and 2022.txt
// Give me back the final result
// O: 5900




// Chatbot



