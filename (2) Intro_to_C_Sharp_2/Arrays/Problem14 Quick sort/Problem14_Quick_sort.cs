// Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class Problem14_Quick_sort
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

        if (intArray.Length == 1)
        {
            Console.WriteLine(intArray[0]);
        }
        else
        {
            QuickSort(intArray, 0, intArray.Length - 1);
            Console.WriteLine("After sorting: {0}", string.Join(", ", intArray));
        }
    }

    static void QuickSort(int[] numbers, int left, int right)
    {
        int pivot;

        if (left < right)
        {
            pivot = Partition(numbers, left, right);

            if (pivot > 1)
            {
                QuickSort(numbers, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(numbers, pivot + 1, right);
            }
        }
    }
    private static int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];

        while (true)
        {
            while (numbers[left] < pivot)
            {
                ++left;
            }
            while (numbers[right] > pivot)
            {
                --right;
            }

            if (numbers[right] == numbers[left] && numbers[left] == pivot)
            {
                ++left;
            }

            if (left < right)
            {
                numbers[left] ^= numbers[right];
                numbers[right] ^= numbers[left];
                numbers[left] ^= numbers[right];
            }
            else
            {
                return right;
            }
        }
    }
}