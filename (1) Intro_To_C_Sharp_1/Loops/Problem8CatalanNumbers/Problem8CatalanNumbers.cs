using System;

class Problem8CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());

        long divident = 1;
        long divider = 1;
        if (n > 0 && n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                divident *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }
            long result = divident / divider;
            Console.WriteLine("The {0} Catalan number is: {1}", n, result);
        }
        else
        {
            Console.WriteLine("The number must be bigger than zero");
        }
    }
}