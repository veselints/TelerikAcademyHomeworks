// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class Problem6_Maximal_K_sum
{
    static void Main()
    {
        Console.Write("Tell us how many elements will bi in the array: ");
        int n = Int32.Parse(Console.ReadLine());

        Console.Write("Tell us the number of consecutive elements of wich we are looking for the maximal sum: ");
        int k = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Tell us the numbers in the array: "); 
        int[] intArray = new int[n]; 
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(Console.ReadLine());
        }

        int sum = 0;
        int newSum = 0;
        int startingElement = 0;

        for (int i = 0; i < intArray.Length - k + 1; i++)
        {
            for (int j = 0; j < k; j++)
            {
                newSum = newSum + intArray[i + j];
            }
            if (newSum >= sum)
            {
                sum = newSum;
                startingElement = i;
            }
            newSum = 0;
        }

        Console.WriteLine("The maximal sum is {0}.", sum);
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(intArray[startingElement + i]);
        }

    }
}
