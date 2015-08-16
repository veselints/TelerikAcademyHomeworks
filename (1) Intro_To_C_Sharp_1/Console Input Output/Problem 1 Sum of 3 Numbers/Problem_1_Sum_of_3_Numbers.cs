// Write a program that reads 3 real numbers from the console and prints their sum

using System;

class Problem_1_Sum_of_3_Numbers
{
    static void Main()
    {
        Console.WriteLine("Please, give us 3 numbers.");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine()); 
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine()); 
        Console.WriteLine("The sum of the tree numbers is {0}.", a + b + c);
    }
}