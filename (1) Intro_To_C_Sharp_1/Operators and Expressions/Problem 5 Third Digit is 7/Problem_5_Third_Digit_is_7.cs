// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class Problem_5_Third_Digit_is_7
{
    static void Main()
    {
        Console.WriteLine("We are looking for numbers which have 7 as their third digit. Please give us a number!");
        int number = Int32.Parse(Console.ReadLine());
        int numberCheck = (number / 100) % 10;
        bool check = numberCheck == 7;
        Console.WriteLine(check);
    }
}