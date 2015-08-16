// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class Problem5Calculate
{
    static void Main()
    {
        Console.Write("Please, give us a number n = ");
        double n = Double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number x = ");
        double x = Double.Parse(Console.ReadLine());

        double xAtPowerN = 1.00;
        double factorial = 1.00;
        double s = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xAtPowerN *= x;
            s += (factorial / xAtPowerN);
        }
        Console.WriteLine("{0 :F5}", s);
    }
}
