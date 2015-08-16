// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and
// using the method Array.BinSearch() finds the largest number in the array which is ≤ K

using System;

class Problem4_Binary_search
{
    static void Main()
    {
        Console.Write("Give us the lenght of the array: ");
        int n = Int32.Parse(Console.ReadLine());

        Console.Write("Tell us which is the number k that we ar looking for: ");
        int k = Int32.Parse(Console.ReadLine());

        int[] intArray = new int[n];

        Console.WriteLine("Tell us the numbers in the array: ");
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(Console.ReadLine());
        }
        Array.Sort(intArray);

        while (Array.BinarySearch(intArray, k) < 0)
        {
            k--;
        }

        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
    }
}