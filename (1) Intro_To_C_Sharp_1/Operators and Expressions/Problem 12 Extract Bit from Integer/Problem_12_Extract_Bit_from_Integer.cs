// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class Problem_12_Extract_Bit_from_Integer
{
    static void Main()
    {
        Console.WriteLine("Give us an integer number N:");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Give us the position of the bit you are interested in (starting from right to left and from position 0):");
        int position = Int32.Parse(Console.ReadLine()); 
        int numberMooved = number >> position;

        bool numberCheck = numberMooved % 2 == 0;
        if (numberCheck)
            Console.WriteLine("The bit on the selected position is 0");
        else
            Console.WriteLine("The bit on the selected position is 1");
    }
}

