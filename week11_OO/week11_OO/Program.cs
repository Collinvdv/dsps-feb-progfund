namespace week11_OO;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string aRandomBandName = CreateBandName();
        Console.WriteLine(aRandomBandName);
    }

    static string CreateBandName()
    {
        string word1 = RandomWord();
        string word2 = RandomWord("file2.txt");
        string word3 = RandomWord("file3.txt");
        string word4 = RandomWord("file4.txt");

        return $"{word1} {word2} {word3} {word4}";
    }

    static string RandomWord(string file = "file1.txt")
    {
        string[] words = File.ReadAllLines(file);

        Random rdn = new Random();
        int randomWordIndex = rdn.Next(0, words.Length);

        return words[randomWordIndex];
    }
}

//
// Recap methods: band name generator
// List 1: 
// List 2: 
// List 3: 
//



