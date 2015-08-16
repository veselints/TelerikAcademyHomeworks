// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class Problem7_Selection_sort
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

        int position = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            int smaller = int.MaxValue;
            for (int j = 0 + i; j < intArray.Length; j++)
            {
                if (intArray[j] < smaller)
                {
                    smaller = intArray[j];
                    position = j;
                }
            }
            intArray[position] = intArray[i];
            intArray[i] = smaller;
        }
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write("{0}, ", intArray[i]);
        }
    }
}
