// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class Problem_14_Modify_a_Bit_at_Given_Position
{
    static void Main()
    {
        Console.WriteLine("Give us an integer number N:");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Give us the position of the bit you are interested in (starting from right to left and from position 0):");
        int position = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Give us preferred value for the chosen bit (0 or 1): ");
        int value = Int32.Parse(Console.ReadLine());
        
        int mask = 1 << position;
        int finalNumber;

        if (value == 0)
        {
            mask = ~ (1 << position);
            finalNumber = (number & mask);
        }
        else
        {
            finalNumber = (number | mask);
        }

        Console.WriteLine(finalNumber);
        Console.WriteLine(Convert.ToString(finalNumber, 2).PadLeft(32, '0'));
    }
}
