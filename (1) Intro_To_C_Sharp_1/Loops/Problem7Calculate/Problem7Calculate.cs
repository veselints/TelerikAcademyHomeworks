using System;

class Problem7Calculate
{
    static void Main()
    {
        Console.Write("Enter value of N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value of K = ");
        int k = int.Parse(Console.ReadLine());

        long fact1 = 1;
        long fact2 = 1;
        for (int i = k + 1; i <= n; i++)
        {
            fact1 *= i;
        }
        for (int j = 1; j <= (n - k); j++)
        {
            fact2 *= j;
        }
        long result = fact1 / fact2;
        Console.WriteLine("N! / K!(N-K)! = {0}", result);
    }
}
