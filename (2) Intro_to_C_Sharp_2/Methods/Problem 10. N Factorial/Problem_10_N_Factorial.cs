using System;
using System.Numerics;

class Problem_10_N_Factorial
{
    static void Main()
    {
        Console.Write("Tell us a number from 1 to 100: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0 || 101 > number)
        {
            BigInteger factorialResult = CalculateFactorial(number);
            Console.WriteLine(factorialResult);
        }
        else
        {
            Console.WriteLine("You have entered invalid input!");
        }
    }

    public static BigInteger CalculateFactorial(int number)
    {
        BigInteger result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
