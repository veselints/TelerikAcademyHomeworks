// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class Problem_7_Sum_of_5_Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers, separated by a space: ");
        string[] fiveNum = Console.ReadLine().Split(' ');
        double sum = 0;

        if (fiveNum.Length > 5)
        {
            Console.WriteLine("You have entered more than five numbers!");
        }
        else
        {

            for (int i = 0; i < 5; i++)
            {
                sum += Convert.ToDouble(fiveNum[i]);
            }
            Console.WriteLine("Sum is = {0}", sum);
        }
    }
}
