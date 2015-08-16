﻿// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class Problem_8_Numbers_from_1_to_n
{
    static void Main()
    {
        try
        {
            Console.Write("Please, give us a integer number n = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong data format!");
        }

    }
}
