// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class Problem_9_Sum_of_n_Numbers
{
    static void Main()
    {
        try
        {
            Console.Write("Please, give us a integer number n = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} numbers, separated by a space: ", n);
            string[] numbers = Console.ReadLine().Split(' ');
            double sum = 0;

            if (numbers.Length != n)
            {
                Console.WriteLine("You have not entered {0} numbers!", n);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sum += Convert.ToDouble(numbers[i]);
                }
                Console.WriteLine("Sum is = {0}", sum);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong data format!");
        }
    }
}
