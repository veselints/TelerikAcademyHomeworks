// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;

class Problem1_Decimal_to_binary
{
    static void Main()
    {
        Console.Write("Give us an integer: ");
        int input = int.Parse(Console.ReadLine());
        StringBuilder output = new StringBuilder();

        while (input > 0)
        {
            output.Append(input % 2);
            input /= 2;
        }

        string finalOutput = output.ToString();
        Console.WriteLine("The number in binary format is {0}.", finalOutput);
    }
}
