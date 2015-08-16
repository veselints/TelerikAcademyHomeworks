// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;

class Problem_4_Number_Comparer
{
    static void Main()
    {
        Console.Write("Give us a first number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Give us a second number b = ");
        double b = double.Parse(Console.ReadLine());

        double sum = a + b;
        double difference = Math.Abs(a - b);

        Console.WriteLine("Thea greater number is {0}.", (sum + difference) / 2);
    }
}
