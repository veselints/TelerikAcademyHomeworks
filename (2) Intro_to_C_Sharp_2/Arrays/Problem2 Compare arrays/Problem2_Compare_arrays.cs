// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class Problem2_Compare_arrays
{    
    static void Main()
    {
        Console.Write("Give us the lenght of the two arrays: ");
        int n = Int32.Parse(Console.ReadLine());
        
        int[] firstArray = new int[n];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = Int32.Parse(Console.ReadLine());
        }

        int[] secondArray = new int[n];
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("firstArray[{0}] = secondArray[{0}]", i);
            }
            else
            {
                Console.WriteLine("firstArray[{0}] != secondArray[{0}]", i);
            }
        }

    }
}