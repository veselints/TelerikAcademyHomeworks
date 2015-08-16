// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class Problem_13_Check_a_Bit_at_Given_Position
{
    static void Main()
    {
        Console.WriteLine("Give us an integer number N:");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Give us the position of the bit you are interested in (starting from right to left and from position 0):");
        int position = Int32.Parse(Console.ReadLine());
        int numberMooved = number >> position;

        bool numberCheck = numberMooved % 2 == 0;
        Console.WriteLine("Is the bit on the selected position 1?"); 
        Console.WriteLine(!numberCheck);
    }
}