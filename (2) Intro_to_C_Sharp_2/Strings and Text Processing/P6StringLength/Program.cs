// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6StringLength
{
    class Program
    {
        static void Main()
        {
            Console.Write("Tell us the text: ");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                text = text.Substring(0, 20);
            }
            else
            {
                text = text.PadRight(20, '*');
            }
            Console.WriteLine(text);
        }
    }
}
