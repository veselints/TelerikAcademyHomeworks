// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class Problem11_Binary_search
{
    static void Main()
    {
        Console.Write("Tell us how many elements will bi in the array: ");
        int n = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Tell us the numbers in the array in ascending order: ");
        int[] intArray = new int[n];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(Console.ReadLine());
        }

        Console.Write("Tell us which number we are looking for: ");
        int target = Convert.ToInt32(Console.ReadLine()); 

        int mid = 0;
        int first = 0;
        int last = intArray.Length - 1;

        bool found = false;

        while (!found && first <= last)
        {
            mid = (first + last) / 2;
            if (target < intArray[mid])
            {
                last = mid - 1;
            }
            else if (target > intArray[mid])
            {
                first = mid + 1;
            }
            else
            {
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine("Item " + target + " was found at position " + mid + ".");
        }
        else
        {
            Console.WriteLine("Item " + target + " was not found.");
        }
    }
}