using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "Student_data.txt"; 

        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Display student data
            Console.WriteLine("Student Data:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }
    }
}