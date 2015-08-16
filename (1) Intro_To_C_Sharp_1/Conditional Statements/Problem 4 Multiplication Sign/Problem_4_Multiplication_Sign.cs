// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

using System;

class Problem_4_Multiplication_Sign
{
    static void Main()
    {
        Console.Write("Please, give us a number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            } 
            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }

        }
    }
}
