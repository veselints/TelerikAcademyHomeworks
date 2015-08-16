// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;

class Problem6_First_larger_than_neighbours
{
    static void Main()
    {
        int[] intArray = CreateArray();

        Console.WriteLine("The index of the first element in array that is larger than its neighbours is {0}.", FirstLargerThanNeighbours(intArray));
    }

    public static int FirstLargerThanNeighbours(int[] intArray)
    {
        int result = -1;
        for (int i = 0; i < intArray.Length; i++)
        {
            if ((i - 1 >= 0) && (i + 2 <= intArray.Length))
            {
                if ((intArray[i] > intArray[i - 1]) && (intArray[i] > intArray[i + 1]))
                {
                    result = i;
                    break;
                }
            }
            else if ((i - 1 < 0) && (i + 2 <= intArray.Length))
            {
                if (intArray[i] > intArray[i + 1])
                {
                    result = i;
                    break;
                }
            }
            else if ((i - 1 >= 0) && (i + 2 > intArray.Length))
                if (intArray[i] > intArray[i - 1])
                {
                    result = i;
                    break;
                }
        }
        return result;
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
}