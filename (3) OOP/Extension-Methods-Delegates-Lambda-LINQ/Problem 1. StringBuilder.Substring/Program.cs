// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_StringBuilder_Substring
{
    public static class Extentions
    {
        static void Main(string[] args)
        {
            StringBuilder testSB = new StringBuilder();
            testSB.Append("To have or not to have.. this is the question");

            StringBuilder testResult = testSB.Substring(10, 12);

            Console.WriteLine(testResult);
        }

        public static StringBuilder Substring(this StringBuilder input, int index, int lenght)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                for (int i = index; i < index + lenght + 1; i++)
                {
                    result.Append(input[i]);
                }
                return result;
            }
            catch (IndexOutOfRangeException exeption)
            {
                throw new IndexOutOfRangeException(exeption.Message);
            }
        }
    }
}
