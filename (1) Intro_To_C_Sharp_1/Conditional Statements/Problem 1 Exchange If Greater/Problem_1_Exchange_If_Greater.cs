// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
// As a result print the values a and b, separated by a space.

using System;

class Problem_1_Exchange_If_Greater
{
    static void Main()
    {
        Console.WriteLine("Please, give us a number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, give us a number b = ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
        }

        Console.WriteLine(a + " " + b);
    }
}
