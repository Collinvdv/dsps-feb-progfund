using System;
using static System.Net.Mime.MediaTypeNames;

namespace recap_niloe
{
    class Program
    {
        static void Main(string[] args)
        {

            // IF exercise
            //21.Write a program in C# Sharp to read any digit, display in the word.
            //Test Data :
            //4
            //Expected Output :
            //Four

            //int number1 = Convert.ToInt16(Console.ReadLine());

            //if (number1 == 4)
            //{
            //    Console.WriteLine("four");
            //} else if(number1 == 5)
            //{
            //    Console.WriteLine("five");
            //} else
            //{
            //    Console.WriteLine("I don't know, broooo");
            //}

            // O: 1
            // O: 2
            // ..
            // O: 10

            //for (int i = 1; i <= 1000; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // use the for loop count from
            // Ask the user the start point and the end point
            // I: 25
            // I: 39
            // O: 25
            // O: 26
            // O: 27
            // O: 28
            // ...
            // O: 39
            //int start = Convert.ToInt16(Console.ReadLine());
            //int end = Convert.ToInt16(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Give the multiplication table with 3
            // O: 1 x 3 = 3
            // O: 2 X 3 = 6..

            // O: 10 X 3 = 30
            //int baseNumber = 3;

            //for (int number = 1; number <= 10; number++)
            //{
            //    int result = number * baseNumber;
            //    Console.WriteLine($"{number} X {baseNumber} = {result}");
            //}


            // ALL THE EVEN NUMBERS FROM 0 TILL 100
            // O: 2
            // 0: 4
            // ..
            // O: 100
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //string firstname = Console.ReadLine();
            // O: 1 letter is C
            // O: 2 letter is o
            // ..
            //for (int letterIndex = 0; letterIndex < firstname.Length; letterIndex++)
            //{
            //    Console.WriteLine($"The {letterIndex} is {firstname[letterIndex]}");
            //}

            //for (int letterIndex = 0; letterIndex <= (firstname.Length - 1); letterIndex++)
            //{
            //    Console.WriteLine($"The {letterIndex} is {firstname[letterIndex]}");
            //}


            // Vowel counter assignments
            // I: Collin
            // O: 2 vowels
            //string firstname = Console.ReadLine();
            //int countOfVowels = 0;

            //for (int letterIndex = 0; letterIndex < firstname.Length; letterIndex++)
            //{
            //    char character = firstname[letterIndex];

            //    if (
            //        character == 'o' ||
            //        character == 'e' ||
            //        character == 'a' ||
            //        character == 'i' ||
            //        character == 'u'
            //    )
            //    {
            //        countOfVowels++;
            //    }
            //}

            //Console.WriteLine($"The amount of vowels is {countOfVowels}");


            // Write a program in C# Sharp to display a right angle triangle with an asterisk.
            //The pattern like :
            // I: 4
            //*
            //**
            //***
            //****
            //int amountOfRows = Convert.ToInt16(Console.ReadLine());

            //for (int row = 1; row <= amountOfRows; row++ )
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Poke");
            //string userInput = Console.ReadLine();

            //if (userInput != "stop")
            //{
            //    Console.WriteLine("poke");
            //    userInput = Console.ReadLine();
            //}



            //
            // I: 3
            // I: 10
            // I: 20
            // I: stop
            // O: Average is 11
            //

            // Starting variables 
            //string userInput = Console.ReadLine();
            //int total = 0;
            //int amountOfNumbers = 0; 

            // If user doesn't say stop, ask for numbers
            //while (userInput != "stop")
            //{
            //    // Trying to parse something, it would work then save true/false to parsingsucces
            //    // If true also number will be parsed 
            //    int number;
            //    Boolean parsingSucceeded = int.TryParse(userInput, out number);

            //    if (parsingSucceeded)
            //    {
            //        total += number;
            //        amountOfNumbers++;
            //        Console.WriteLine($"Total is {total}, and amount is {amountOfNumbers}");
            //    }

            //    // Very important to ask it again, so at some point I can exit
            //    userInput = Console.ReadLine();
            //}

            // Calculate the average
            //double avg = total / amountOfNumbers;
            //Console.WriteLine("The total is " + avg);


            // Binarary convert 111001

            string binaryNumber = "111001";

            // 2 ^ 5 = 32 * 1 = 32 -> charIndex 0, powerTo = 5
            // 2 ^ 4 = 16 * 1 = 16
            // 2 ^ 3 = 8 * 1 = 8
            // 2 ^ 2 = 4 * 0 = 0
            // 2 ^ 1 = 2 * 0 = 0
            // 2 ^ 0 = 1 * 1 = 1
            // 57 (32 + 16 + 8 + 1)
            double sum = 0;
            for (int charIndex = 0; charIndex < binaryNumber.Length; charIndex++)
            {
                char number = binaryNumber[charIndex];
                int powerTo = (binaryNumber.Length - 1) - charIndex;

                if (number == '1')
                {
                    sum += Math.Pow(2, powerTo);
                }
            }

            Console.WriteLine(sum);

        }
    }

}



 







// Binarary convert 111001



// Write a program in C# Sharp to display a number in reverse order.
//Test Data :
//Input a number: 12345
//Expected Output :
//The number in reverse order is : 54321




//  Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
//The pattern like :
//1
//12
//123





// Prime Number Finder: Develop a program that uses loops to find all prime numbers up to a number N provided by the user. A prime number is a number that is divisible only by 1 and itself.