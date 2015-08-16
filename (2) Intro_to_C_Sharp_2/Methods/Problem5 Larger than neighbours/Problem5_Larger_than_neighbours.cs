// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class Problem5_Larger_than_neighbours
{
    static void Main()
    {
        int[] intArray = CreateArray();

        Console.Write("Tell us the position of the number you want to check: ");
        int position = int.Parse(Console.ReadLine());

        if (LargerThanNeighbours(intArray, position))
        {
            Console.WriteLine("The number at position {0} is larger than its neighbours.", position);
        }
        else
        {
             Console.WriteLine("The number at position {0} is not larger than its neighbours.", position);
        }      
    }

    public static bool LargerThanNeighbours(int[] intArray, int position)
    {
        bool result = false;

        if ((position - 1 >= 0) && (position + 2 <= intArray.Length))
        {
            if ((intArray[position] > intArray[position - 1]) && (intArray[position] > intArray[position + 1]))
            {
                result = true;
            }
        }
        else if ((position - 1 < 0) && (position + 2 <= intArray.Length))
        {
            if (intArray[position] > intArray[position + 1])
            {
                result = true;
            }
        }
        else if ((position - 1 >= 0) && (position + 2 > intArray.Length))
            if (intArray[position] > intArray[position - 1])
            {
                result = true;
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
