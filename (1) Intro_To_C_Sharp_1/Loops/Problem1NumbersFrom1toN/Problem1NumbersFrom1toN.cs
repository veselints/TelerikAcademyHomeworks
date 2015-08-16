// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class Problem1NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Please, give us a number n = ");
        long n = Int64.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            long currentNumber = 1 + i;
            Console.Write("{0} ", currentNumber);
        }
        Console.WriteLine();
    }
}
