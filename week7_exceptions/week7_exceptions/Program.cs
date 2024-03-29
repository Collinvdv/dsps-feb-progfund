using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading;
using System.IO;

namespace week7_exceptions;

class Program
{
    static void Main(string[] args)
    {
        // 1. Variables & Expressions
        // decleration = creating a varicale 
        //string firstname = "Collin";
        //string lastname = "Van der Vorst";
        //firstname = "Lisa";

        // concatenation
        //string fullname = firstname + " " + lastname;
        //int age = Convert.ToInt32(Console.ReadLine());
        //age = age - 1;
        //age = age + 1;
        //age += 1;
        //age++;
        //age = age * 2;
        //age = age / 3;

        //double length = 1.93;
        //char grade = Convert.ToChar(Console.Read());
        //grade = Char.ToUpper(grade);
        //Console.WriteLine(grade);

        //bool isTeacher = true;

        // Expressions
        //Console.WriteLine(5 != 10);

        // Conditional
        //int age = Convert.ToInt16(Console.ReadLine());

        //if (age >= 18 && age < 67)
        //{
        //    Console.WriteLine("you need to work");
        //} else if (age > 67)
        //{
        //    Console.WriteLine("You are retired");
        //} else if (age < 18)
        //{
        //    Console.WriteLine("Enjoy life");
        //}


        // Switch
        //string fruit = Console.ReadLine();

        //if (fruit == "orange")
        //{
        //    Console.WriteLine("fanta");
        //} else if (fruit == "lemon")
        //{
        //    Console.WriteLine("Sprite");
        //} else
        //{
        //    Console.WriteLine(" I can not find a soda");
        //}

        //switch (fruit)
        //{
        //    case "orange":
        //        Console.WriteLine("fanta");
        //        break;
        //    case "lemon":
        //        Console.WriteLine("sprite");
        //        break;
        //    default:
        //        Console.WriteLine("I can not find the soda"):
        //        break;
        //}

        // 4. loops
        //for (int i = 1; i <= 1000; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //string commando = Console.ReadLine();

        //while (commando != "stop")
        //{
        //    commando = Console.ReadLine();
        //}

        //StreamReader donkeyText = File.OpenText("donkey.txt");
        //string line = donkeyText.ReadLine();

        //while (line != null)
        //{
        //    Console.WriteLine(line);
        //    line = donkeyText.ReadLine();
        //}
        //donkeyText.Close();

        //StreamWriter writer = File.CreateText("attendance.txt");
        //writer.WriteLine("Collin");
        //writer.Close();

        //string[] students = new string[ 3 ];
        //string[] teachers = {
        //    "Collin",
        //    "Charlie"
        //};
        //students[0] = "Marley";
        //students[1] = "Collin";
        //students[2] = "Mohammed";

        //for(int i = 0; i < students.Length; i++)
        //{
        //    Console.WriteLine(students[i]);
        //}

        //02 Odd

        //Read in an integer.Print true if the number is odd, otherwise print false.


        //Input/Output
        //input:
        //9
        //output:
        //True

        //input:
        //-4
        //output:
        //False

        //int number = Convert.ToInt16(Console.ReadLine());

        //if (number % 2 == 0)
        //{
        //    Console.WriteLine("True");
        //} else
        //{
        //    Console.WriteLine("False");
        //}

        //03 Largest
        //int number1 = Convert.ToInt16(Console.ReadLine());
        //int number2 = Convert.ToInt16(Console.ReadLine());
        //int number3 = Convert.ToInt16(Console.ReadLine());

        //if(number1 >= number2 && number1 >= number3)
        //{
        //    Console.WriteLine(number1);
        //} else if (number2 >= number1 && number2 >= number3)
        //{
        //    Console.WriteLine(number2);
        //} else
        //{
        //    Console.WriteLine(number3);


        //04 Roman to decimal

        //Read in a roman numeral n and convert it to a decimal number.
        //(M = 1000,
        //D = 500, C = 100, L = 50, X = 10, V = 5 and I = 1)

        //Example: n = DXII --> 500 + 10 + 1 + 1 = 512 
        //(tip: work with the length of a word and ElementAt())

        //Input/Output
        //input:
        //DXII
        //output:
        //512

        //input:
        //MDCCXXXIIII
        //output:
        //1734

        //string roman = Console.ReadLine().ToUpper(); // DXII
        //int result = 0;
        //for (int i = 0; i < roman.Length; i++)
        //{
        //    switch (roman[i])
        //    {
        //        case 'M':
        //            result += 1000;
        //            break;
        //        case 'D':
        //            result += 500;
        //            break;
        //        case 'C':
        //            result += 100;
        //            break;
        //        case 'L':
        //            result += 50;
        //            break;
        //        case 'X':
        //            result += 10;
        //            break;
        //        case 'V':
        //            result += 5;
        //            break;
        //        case 'I':
        //            result += 1;
        //            break;
        //    }
        //}

        //Console.WriteLine(result);



        // 5. Files Harry Potter
        // Read in file HarryPotter.csv
        // O: How many phrases has following character?
        // I: Hagrid
        // O: ???
        StreamReader reader = File.OpenText("Harry Potter 1.csv");

        int count = 0;
        string line = reader.ReadLine();
        string givenCharacter = Console.ReadLine(); // Hagrid

        while (line != null)
        {
            string character = line.Split(';')[0];

            if (givenCharacter.ToUpper() == character.ToUpper())
            {
                count++;
            }

            line = reader.ReadLine();
        }

        Console.WriteLine(count);

    }




}

//
// Recap 

// 2. Conditional statements
// 3. Loops
// 4. Files
// 5. Array

























// 6. Flip
//Read in a square matrix and flip it horizontally.

//Note: use of Linq-library or Array-library is forbidden!
//Input/Output
//input:
//*-*
//*-*
//***
//output:
//***
//*-*
//*-*


//input:
//ab
//ba
//output:
//ba
//ab