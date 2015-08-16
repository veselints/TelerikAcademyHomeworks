
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class Problem_6_Quadratic_Equation
{
    static void Main()
    {
        Console.WriteLine("We are trying to solve the quadratic equation ax2 + bx + c = 0. Please, help us!");
        Console.Write("Give us a number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Give us a number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Give us a number c = ");
        double c = double.Parse(Console.ReadLine());

        double squareRoot = Math.Sqrt(b * b - 4 * a * c);
        double x1 = (-b + squareRoot) / 2 / a;
        double x2 = (-b - squareRoot) / 2 / a;

        if (Double.IsNaN(x1) && Double.IsNaN(x2))
        {
            Console.WriteLine("The equation has no real roots");
        }
        else
        {
            if (Double.IsNaN(x1))
            {
                Console.WriteLine("The solution of the equation is {0}.", x2);
            }
            if (Double.IsNaN(x2))
            {
                Console.WriteLine("The solution of the equation is {0}.", x1);
            }
            Console.WriteLine("The solutions of the equation are {0} and {1}.", x1, x2);
        }
    }
}
