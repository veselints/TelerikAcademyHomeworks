﻿// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;

class P6SaveSortedNames
{
    static void Main()
    {
        SaveSortedList(GetList());
    }

    private static void SaveSortedList(List<String> listOfNames)
    {
        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            for (int index = 0; index < listOfNames.Count; index++)
            {
                writer.WriteLine(listOfNames[index]);
            }

            Console.WriteLine("output.txt - Done");
        }
    }

    private static List<String> GetList()
    {
        using (StreamReader reader = new StreamReader("../../TextFile.txt"))
        {
            List<string> listOfNames = new List<string>();
            int lineNumber = 0;

            string line = reader.ReadLine();
            char[] separators = new char[] { ' ', '|' };

            while (line != null)
            {
                string[] pointCoords = line.Split(separators,
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in pointCoords)
                {
                    listOfNames.Add(item);
                }

                lineNumber++;
                line = reader.ReadLine();
            }

            listOfNames.Sort();

            return listOfNames;
        }
    }
}
