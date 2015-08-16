using System;
using System.Text;

namespace P23SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text in which we'll be looking for equal consecutive letters: ");
            string text = Console.ReadLine(); 
            
            StringBuilder sb = new StringBuilder();

            char previous = text[0];

            sb.Append(previous);

            for (int i = 1; i < text.Length; i++)
            {
                if (previous != text[i])
                {
                    sb.Append(text[i]);
                }

                previous = text[i];
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
