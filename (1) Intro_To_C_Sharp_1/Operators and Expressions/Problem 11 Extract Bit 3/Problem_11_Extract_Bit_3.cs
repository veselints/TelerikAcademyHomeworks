// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

using System;

class Problem_11_Extract_Bit_3
{
    static void Main()
    {
        Console.WriteLine("Give us an integer number:");
        int number = Int32.Parse(Console.ReadLine());
        int numberMooved = number >> 3;

        bool numberCheck = numberMooved % 2 == 0;
        if (numberCheck)
            Console.WriteLine("The bit #3 is 0");
        else
            Console.WriteLine("The bit #3 is 1");
    }
}