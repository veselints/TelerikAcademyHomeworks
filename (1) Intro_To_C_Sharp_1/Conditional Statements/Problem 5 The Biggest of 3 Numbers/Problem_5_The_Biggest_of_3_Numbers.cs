// Write a program that finds the biggest of three numbers.

using System;

class Problem_5_The_Biggest_of_3_Numbers
{
    static void Main()
    {
        Console.Write("Please, give us a number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, give us a number c = ");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest number is \"A\"");
            }
            else if (a < c)
            {
                Console.WriteLine("The biggest number is \"C\"");
            }
            else
            {
                Console.WriteLine("The biggest numbers are \"A\" and \"C\".");
            }
        }
        else if (a < b)
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number is \"B\"");
            }
            else if (b < c)
            {
                Console.WriteLine("The biggest number is \"C\"");
            }
            else
            {
                Console.WriteLine("The biggest numbers are \"B\" and \"C\".");
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine("The biggest numbers are \"A\" and \"B\".");
            }
            else if (a < c)
            {
                Console.WriteLine("The biggest number is \"C\"");
            }
            else
            {
                Console.WriteLine("The three numbers are equal!");
            }
        }
    }
}
