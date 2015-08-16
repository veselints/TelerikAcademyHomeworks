// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.

using System;

class Problem_7_Sort_3_Numbers_with_Nested_Ifs
{
    static void Main()
    {
        Console.Write("Please, give us a number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number c = ");
        double c = double.Parse(Console.ReadLine());

        if (b >= c)
        {
            if (a >= b)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else
            {
                if (a >= c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
        }
        else
        {
            if (b >= a)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
            else
            {
                if (a >= c)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
        }
    }
}

