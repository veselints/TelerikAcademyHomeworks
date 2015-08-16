// Write an expression that checks if given integer is odd or even.

using System;

class Problem_1_Odd_or_Even_Integers
{
    static void Main()
    {
        Console.WriteLine("Please, give us a number!");
        int number = Int32.Parse(Console.ReadLine());
        int dividedNumber = number % 2;

        if (dividedNumber == 1)
        {
            Console.WriteLine("Your number is odd.");
        }
        else
        {
            Console.WriteLine("Your number is even.");
        }
    }
}
