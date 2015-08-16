// Write a program that finds the most frequent number in an array.

using System;

class Problem9_Frequent_number
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
        
        Array.Sort(intArray);

        int maxFrequency = 0;
        int currentFrequency;
        int? number = null;
        int index = 0;
        int currentNumber = intArray[0];

        while (index < intArray.Length)
        {
            currentFrequency = 0;
            while (currentNumber == intArray[index])
            {
                currentFrequency++;
                index++;
                if (index == intArray.Length)
                {
                    break;
                }
            }
            if (currentFrequency > maxFrequency)
            {
                maxFrequency = currentFrequency;
                number = currentNumber;
            }
            if (index < intArray.Length)
            {
                currentNumber = intArray[index];
            }
        }

        Console.WriteLine("The most frequent number is {0}. It appears {1} times in the array.", number, maxFrequency);
    }
}
