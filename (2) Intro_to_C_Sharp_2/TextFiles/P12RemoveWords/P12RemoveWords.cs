// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;


class P12RemoveWords
{
    static void Main()
    {
        try
        {
            string listedWords = @"\b" + String.Join("|",
                File.ReadAllLines("../../Words.txt")) + @"\b";

            using (StreamReader streamReader = new StreamReader("../../TextFile.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter("../../Result.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {

                        streamWriter.WriteLine(Regex.Replace(line,
                            listedWords, String.Empty));

                        line = streamReader.ReadLine();
                    }

                    Console.WriteLine("Result.txt - Done !");
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
