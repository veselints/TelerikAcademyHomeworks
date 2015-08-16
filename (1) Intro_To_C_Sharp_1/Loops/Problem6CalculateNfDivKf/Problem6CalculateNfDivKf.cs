// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;

class Problem6CalculateNfDivKf
{
    static void Main()
    {
        Console.Write("Please, give us a number n = ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Please, give us a number k = ");
        int k = Int32.Parse(Console.ReadLine());
        long result = 1;

        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine("N!/!K = {0}", result);
    }
}
