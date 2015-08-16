// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.IO;

class P4CompareTextFiles
{
    static void Main()
    {
        string[] linesOne = File.ReadAllLines("../../FileOne.txt");
        string[] linesTwo = File.ReadAllLines("../../FileTwo.txt");

        int maxLength = Math.Max(linesOne.Length, linesTwo.Length);
        int minLength = Math.Min(linesOne.Length, linesTwo.Length);

        for (int line = 0; line < maxLength; line++)
        {
            if (line < minLength)
            {
                if (linesOne[line].Equals(linesTwo[line]))
                {
                    Console.WriteLine("At line {0} : lines from the files are equal.", line);
                }
                else
                {
                    Console.WriteLine("At line {0} : lines from the files are not equal.", line);
                }
            }
            else
            {
                Console.WriteLine("Line {0} : doesnt exits in {1} file.", line,
                                                linesOne.Length == minLength ? "first" : "second");
            }
        }
    }
}
