// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8ExtractSentences
{
    class Program
    {
        static void Main()
        {
            Console.Write("Tell us the text we are looking in: ");
            string text = Console.ReadLine();
            Console.Write("Tell us the word we are looking for: ");
            string word = Console.ReadLine();
            word = " " + word + " ";
            string pointWord = " " + word + ".";

            int startIndex = 0;
            int endIndex = text.IndexOf('.');
            List<string> sentances = new List<string>();

            while (endIndex != -1)
            {
                string sentance = text.Substring(startIndex, endIndex + 1 - startIndex);
                sentances.Add(sentance);
                startIndex = endIndex + 2;
                if (startIndex <= text.Length)
                {
                    endIndex = text.IndexOf('.', startIndex);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < sentances.Count; i++)
            {
                if (sentances[i].IndexOf(word) != -1 || sentances[i].IndexOf(pointWord) != -1)
                {
                    Console.WriteLine(sentances[i]);
                }
            }
            
        }
    }
}
