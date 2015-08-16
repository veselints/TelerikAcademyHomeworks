// Write a program that finds the sequence of maximal sum in given array.

using System;

class Problem8_Maximal_sum
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

        int result = int.MinValue;
        int sum = 0;
        int tempStart = 0;

        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            sum += intArray[i];
            if (sum > result)
            {
                result = sum;
                startIndex = tempStart;
                endIndex = i;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = i + 1;
            }
        }

        Console.WriteLine("The maximun sum is: {0}", sum);
        Console.WriteLine("The start index of the sequence is: {0}", startIndex);
        Console.WriteLine("The end index of the sequence is: {0}", endIndex);
    }
}
