// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class Problem_10_Fibonacci_Numbers
{
    static void Main()
    {
        try
        {
            Console.WriteLine("We will tell you the first \"n\" numbers of the Fibonacci line. Tell us how many numbers you want to be printed: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Plase, give us a positive integer number!");
                return;
            }

            int firstNumber = 0;
            int secondNumber = 1;
            int sum;

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ", firstNumber);

                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong data format!");
        }
    }
}