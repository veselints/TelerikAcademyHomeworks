// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;

class Problem9_Sorting_array
{
    public static int startIndex = 0;
    public static int maxElementIndex = 0;
    public static int tempElement = 0;
    
    static void Main()
    {
        int[] intArray = CreateArray();

        int[] sortedArray = SortDescendingArray(intArray);

        PrintArray(sortedArray);
    }

    public static int[] SortDescendingArray(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            tempElement = intArray[MaxElementOfArray(intArray)];
            intArray[MaxElementOfArray(intArray)] = intArray[i];
            intArray[i] = tempElement;
            startIndex = i + 1;
        }

        return intArray;
    }

    public static int MaxElementOfArray(int[] intArray)
    {
        int result = int.MinValue;

        for (int i = startIndex; i < intArray.Length; i++)
        {
            if (intArray[i] > result)
            {
                maxElementIndex = i;
                result = intArray[i];
            }
        }
        return maxElementIndex;
    }

    public static int[] CreateArray()
    {
        Console.Write("Give us the lenght of the array: ");
        int n = Int32.Parse(Console.ReadLine());
        int[] intArray = new int[n];
        Console.WriteLine("Tell us the numbers in the array: ");
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(Console.ReadLine());
        }
        return intArray;
    }

    public static void PrintArray(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
    }
}
