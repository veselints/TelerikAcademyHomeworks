// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class Problem10_Find_sum_in_array
{
    static void Main()
    {
        Console.Write("Tell us how many elements will bi in the array: ");
        int n = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Tell us the numbers in the array: ");
        int[] intArray = new int[n];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(Console.ReadLine());
        }
        
        int currentSum;

        Console.Write("Tell us the sum we are looking for: ");
        int sum = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            currentSum = intArray[i];
            for (int j = i + 1; j <= n; j++)
            {
                if (currentSum == sum)
                {
                    for (int k = 0; k < j - i; k++)
                    {
                        Console.Write("{0}, ", intArray[i + k]);
                    }
                }
                if (currentSum > sum || j == n)
                {
                    break;
                }
                currentSum = currentSum + intArray[j];
            }
        }
    }
}
