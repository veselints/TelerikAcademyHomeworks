// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell us the string we should convert to Unicode character literals: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                string character = text[i].ToString();
                Console.Write("\\u{0:x4}", (int)text[i]);
            }
            Console.WriteLine();
        }
    }
}
