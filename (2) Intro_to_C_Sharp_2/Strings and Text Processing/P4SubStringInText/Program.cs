using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4SubStringInText
{
    class Program
    {
        static void Main()
        {
            Console.Write("Tell us the text we are looking in: ");
            string text = Console.ReadLine();
            Console.Write("Tell us the substring we are looking for: ");
            string subString = Console.ReadLine();
            int count = 0;
            int indexOfSubString = text.IndexOf(subString);
            while (indexOfSubString >= 0)
            {
                count++;
                indexOfSubString = text.IndexOf(subString, indexOfSubString + 1);
            }

            Console.WriteLine("{0} appears {1} times in the text.", subString, count);
        }
    }
}
