// Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us the text we should reverse: ");
            string text = Console.ReadLine();
            char punctuation = text[text.Length - 1];
            StringBuilder inText = new StringBuilder();
            
            for (int i = 0; i < text.Length - 1; i++)
            {
                inText.Append(text[i]);
            }

            text = inText.ToString();

            char[] separator = {' '};
            string[] inputText = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder editedText = new StringBuilder();

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                editedText.Append(inputText[i]);
                if (i > 0)
                {
                    editedText.Append(' ');
                }
                else
                {
                    editedText.Append(punctuation);
                }
            }

            text = editedText.ToString();

            Console.WriteLine(text);
        }
    }
}
