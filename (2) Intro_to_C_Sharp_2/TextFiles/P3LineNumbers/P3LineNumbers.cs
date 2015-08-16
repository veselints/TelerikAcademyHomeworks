// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

class P3LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../TextFile.txt"))
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            using (StreamWriter writer = new StreamWriter("../../Result.txt", false))
            {
                while (line != null)
                {
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        writer.WriteLine("{0} : {1}", lineNumber, line);
                        lineNumber++;
                    }

                    line = reader.ReadLine();
                }
            }
        }



        using (StreamReader readerResult = new StreamReader("../../Result.txt"))
        {
            int lineNumber = 0;

            string line = readerResult.ReadLine();

            while (line != null)
            {
                lineNumber++;

                Console.WriteLine(line);

                line = readerResult.ReadLine();
            }
        }
    }
}