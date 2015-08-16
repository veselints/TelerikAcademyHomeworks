// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell us the text we are looking in: ");
            string text = Console.ReadLine();
            Console.Write("Tell us which are the forbidden words: ");
            string fBWords = Console.ReadLine();
            char[] pauses = {' ', ','};
            string[] forbiddenWords = fBWords.Split(pauses, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder editedText = new StringBuilder(text);
            for (int i = 0; i < forbiddenWords.Length; i++)
			{
                string replaceSymbol = "".PadLeft(forbiddenWords[i].Length, '*');
                editedText.Replace(forbiddenWords[i], replaceSymbol);
			}

            string output = editedText.ToString();

            Console.WriteLine(output);
        }
    }
}
