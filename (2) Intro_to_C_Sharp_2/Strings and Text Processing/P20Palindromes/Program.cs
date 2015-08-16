using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text in which we should look for Palindromes: ");
            string text = Console.ReadLine();

            string[] splitted = text.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in splitted)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome && word.Length > 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
