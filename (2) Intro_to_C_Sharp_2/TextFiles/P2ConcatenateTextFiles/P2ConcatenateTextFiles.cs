// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class P2ConcatenateTextFiles
{
    static void Main(string[] args)
    {
        using (var output = File.Create("../../Result.txt"))
        {
            foreach (var file in new[] { "../../FileOne.txt", 
                    "../../FileTwo.txt" })
            {
                using (var input = File.OpenRead(file))
                {
                    input.CopyTo(output);
                }
            }
        }

        StreamReader reader = new StreamReader("../../Result.txt");

        using (reader)
        {
            int lineNumber = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;

                Console.WriteLine(line);

                line = reader.ReadLine();
            }
        }
    }
}
