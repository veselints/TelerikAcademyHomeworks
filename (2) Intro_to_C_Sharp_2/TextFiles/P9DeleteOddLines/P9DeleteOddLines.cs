// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

using System;
using System.IO;

class P9DeleteOddLines
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("../../TextFile.txt");

        for (int index = 0; index < lines.Length; index++)
        {
            Console.WriteLine(lines[index]);
        }

        using (StreamWriter streamWriter = new StreamWriter("../../Result.txt",
            false))
        {

            for (int index = 0; index < lines.Length; index++)
            {
                if (index % 2 == 0)
                {
                    streamWriter.WriteLine(lines[index]);
                }
            }

            Console.WriteLine("Result.txt - Done");
        }
    }
}
