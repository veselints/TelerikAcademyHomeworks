// Write an expression that calculates trapezoid's area by given sides a and b and height h

using System;

class Problem_9_Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Give us the lenght of the first side of the trapezoid.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Give us the lenght of the second side of the trapezoid.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Give us the lenght of the height of the trapezoid.");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is {0}.", (a + b) / 2 *h);
    }
}
