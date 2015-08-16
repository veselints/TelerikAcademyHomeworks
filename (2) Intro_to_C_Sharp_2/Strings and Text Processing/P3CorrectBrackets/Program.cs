// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            Console.Write("Tell us an expression to check if the brackets are put correctly: ");
            string input = Console.ReadLine();
            int openBracket = 0;
            int closeBracket = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracket ++;
                }
                else if (input[i] == ')')
                {
                    closeBracket ++;
                }
            }

            if (openBracket != closeBracket)
            {
                Console.WriteLine("There is a mistake in the expression");
            }
            else if (input.IndexOf('(') > input.IndexOf(')'))
            {
                Console.WriteLine("There is a mistake in the expression");
            }
            else if (input.LastIndexOf('(') > input.LastIndexOf(')'))
            {
                Console.WriteLine("There is a mistake in the expression");
            }
            else
            {
                Console.WriteLine("The expression is correct!");
            }
                
        }
    }
}
