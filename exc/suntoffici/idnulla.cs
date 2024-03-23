using System;
using System.IO;

class ReadFromFile
{
    public static void Main()
    {
        string path = @"C:\example.txt";

        // Read the file as one string.
        string text = File.ReadAllText(path);

        // Display the file contents to the console. Variable text is a string.
        Console.WriteLine("Contents of example.txt = {0}", text);
    }
}
