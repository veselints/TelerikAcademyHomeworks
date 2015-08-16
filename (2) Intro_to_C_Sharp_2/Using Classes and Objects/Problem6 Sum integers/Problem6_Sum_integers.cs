// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;


class Problem6_Sum_integers
{
    static void Main()
    {
        Console.WriteLine("Give us a sequence of positive integer values, separated by spaces:");
        string numbers = Console.ReadLine();

        string[] stringNumbersArray = numbers.Split(' ');

        int[] intNumbersArray = Array.ConvertAll(stringNumbersArray, s => int.Parse(s));

        int sumOfNumbers = 0;

        for (int i = 0; i < intNumbersArray.Length; i++)
        {
            sumOfNumbers += intNumbersArray[i];
        }

        Console.WriteLine("The sum of all numbers is {0}.", sumOfNumbers);
    }
}
