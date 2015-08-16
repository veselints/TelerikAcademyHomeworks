// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
// the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below.

using System;

class Problem3MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Please, give us a number n = ");
        long n = Int64.Parse(Console.ReadLine());
        Console.WriteLine("Give us {0} numbers.", n);

        long input;
        long sum = 0;
        long maxValue = long.MinValue;
        long minValue = long.MaxValue;

        for (long i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter the {0} number", i);
            input = Int64.Parse(Console.ReadLine());
            sum += input;
            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
        }
        double average = (double)sum / (double)n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3 :F2}", minValue, maxValue, sum, average);
    }
}