// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class Problem2_Get_largest_number
{
    static void Main()
    {
        Console.WriteLine("Give us tree integers:");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());

        int largest = GetMax(GetMax(firstInt, secondInt), thirdInt);

        Console.WriteLine("The largest integer is {0}.", largest);
    }

    public static int GetMax(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
