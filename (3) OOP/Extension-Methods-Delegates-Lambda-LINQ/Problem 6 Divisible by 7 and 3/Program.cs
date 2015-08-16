// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_Divisible_by_7_and_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] testArray = { 5, 7261, 543, 82, 63, 42, 89, 4103840, 41241, 42 };
            
            long[] firstCheck = DIvisibleBy7and3(testArray).ToArray();
            foreach (var number in firstCheck)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            long[] linqCheck = DIvisibleBy7and3Linq(testArray).ToArray();
            foreach (var number in linqCheck)
            {
                Console.WriteLine(number);
            }
        }

        static IEnumerable<long> DIvisibleBy7and3(IEnumerable<long> inputArray)
        {
            IEnumerable<long> result =
                from number in inputArray
                where number % 21 == 0
                select number;

            return result;
        }

        static IEnumerable<long> DIvisibleBy7and3Linq(IEnumerable<long> inputArray)
        {
            IEnumerable<long> result = inputArray.Where(number => number % 21 == 0);
            return result;
        }
    }
}
