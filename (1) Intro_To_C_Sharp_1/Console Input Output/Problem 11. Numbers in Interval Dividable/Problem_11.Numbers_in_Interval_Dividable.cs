// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class Problem_11_Numbers_in_Interval_Dividable
{
    static void Main()
    {
        try
        {
            Console.Write("Please tell us nuber a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Please tell us nuber b = ");
            int b = Int32.Parse(Console.ReadLine());

            int aDividable = a / 5;
            int bDividable = b / 5;

            int p = Math.Abs(aDividable - bDividable);

            if ((a % 5 == 0) && (b % 5 == 0))
            {
                p = p + 1;
            }

            Console.WriteLine("There are {0} numbers between a and b such that the reminder of the division by 5 is 0.", p);
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong data format!");
        }
    }
}