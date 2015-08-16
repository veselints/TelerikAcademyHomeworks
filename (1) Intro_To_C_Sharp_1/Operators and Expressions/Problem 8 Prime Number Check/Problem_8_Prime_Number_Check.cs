// Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;

class Problem_8_Prime_Number_Check
{
    static void Main()
    {
        Console.WriteLine("Please, give us a positive integer number n (n <= 100). We will check whether it is prime.");
        int n = Int32.Parse(Console.ReadLine());

        if (n > 100 || n <= 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            bool result = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result = false;
                }
            }
            Console.WriteLine(result);
        }
    }
}
