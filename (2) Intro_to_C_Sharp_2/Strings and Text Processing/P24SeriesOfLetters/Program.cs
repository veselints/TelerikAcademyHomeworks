using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the words you would like to be ordered: ");
            string words = Console.ReadLine(); 

            string[] splittedWords = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(splittedWords);

            foreach (string word in splittedWords)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
