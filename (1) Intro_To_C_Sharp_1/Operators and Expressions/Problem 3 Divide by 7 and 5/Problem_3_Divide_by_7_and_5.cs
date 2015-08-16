// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class Problem_3_Divide_by_7_and_5
{
    static void Main()
    {
        Console.WriteLine("We are looking for a integer number which can be devided by both 5 and 7. \n\rPlease give a try and tell us a number!");
        int number = Int32.Parse(Console.ReadLine());
        if (number % 35 == 0)
        {
            Console.WriteLine("This number can be devided by both 5 and 7!");
        }
        else
        {
            Console.WriteLine("This number cannot be devided by both 5 and 7!");
        }
    }
}
