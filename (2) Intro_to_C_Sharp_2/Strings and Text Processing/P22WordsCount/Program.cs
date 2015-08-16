using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();
            string[] splittedText = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool[] visited = new bool[splittedText.Length];

            for (int i = 0; i < splittedText.Length; i++)
            {
                int count = 1;

                if (visited[i] == false)
                {
                    for (int j = i; j < splittedText.Length - 1; j++)
                    {
                        if (splittedText[i] == splittedText[j + 1])
                        {
                            count++;
                            visited[j + 1] = true;
                        }
                    }
                    visited[i] = true;
                    Console.WriteLine(splittedText[i] + "-" + count + " times");
                }
            }
        }
    }
}
