using System;
using System.IO;

namespace week5_files_theory;
class Program
{
    static void Main(string[] args)
    {
        // Ask for filename, create file and add attendees
        string fileName = Console.ReadLine();
        StreamWriter writer = File.AppendText(fileName);

        // Ask for first attendees and go to loop, whenever stop is occuring
        // stop the program
        string attendee = Console.ReadLine();

        while (attendee != "stop")
        {
            // if they say delete and the filename
            // we are going to remove the file
            // FE: delete visitors.txt
            if (attendee.Contains("delete"))
            {
                string deletedFile = attendee.Split(' ')[1];

                if (File.Exists(deletedFile))
                {
                    File.Delete(deletedFile);
                }
            }
            writer.WriteLine(attendee);
            attendee = Console.ReadLine();
        }

        // Close connection
        writer.Close();
    }
}




//
// Writing files
//





