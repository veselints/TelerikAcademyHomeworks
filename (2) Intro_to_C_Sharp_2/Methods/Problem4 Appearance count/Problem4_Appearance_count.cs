// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;

class Problem4_Appearance_count
{
    static void Main()
    {
        int[] intArray = CreateArray();

        Console.Write("Tell us the number we are looking for: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} appears {1} times in the aray.", number, CountingNumberAppearance(intArray, number));
    }

    public static int CountingNumberAppearance(int[] intArray, int number)
    {        
        int result = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] == number)
            {
                result++;
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