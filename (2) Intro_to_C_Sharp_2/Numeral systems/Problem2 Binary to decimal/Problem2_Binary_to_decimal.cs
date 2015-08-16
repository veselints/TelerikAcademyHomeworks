// Write a program to convert binary numbers to their decimal representation.

using System;

class Problem2_Binary_to_decimal
{
    static void Main()
    {
        Console.Write("Give us a binary number: ");
        
        
       // (1 × 102) + (0 × 101) + (4 × 100)

       int input = int.Parse(Console.ReadLine());

       int temp = 0;
        int output = 0;
        int counter = 0;

        while (input > 0)
        {
            temp = input % 10;
            input /= 10;
            output = output + temp * Convert.ToInt32(Math.Pow(2, counter));
            counter++;
        }

        Console.WriteLine("The number in decimal format is {0}.", output);
    }
}
