//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class P2EnterNumbers
{
    static int min = 1;
    static int max = 100;
    const int count = 10;


    static void Main()
    {
        try
        {
            for (int i = 0; i < count; i++)
            {
                min = ReadInteger();
            }
        }
        catch (FormatException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }

    private static int ReadInteger()
    {
        Console.Write("Enter number in range [{0}...{1}]: ", min + 1, max - 1);
        int number = int.Parse(Console.ReadLine());

        if (number <= min || number >= max)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }
}
