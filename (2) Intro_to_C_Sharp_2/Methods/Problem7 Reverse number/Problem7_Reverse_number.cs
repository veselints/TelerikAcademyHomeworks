// Write a method that reverses the digits of given decimal number.

using System;
using System.Text;

class Problem7_Reverse_number
{
    static void Main()
    {
        Console.Write("Give us a dimal number: ");
        decimal input = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Your number with reversed digits is {0}.", ReverseDigits(input));
    }

    public static decimal ReverseDigits(decimal input)
    {
        string stringInput = Convert.ToString(input);
        StringBuilder sBResult = new StringBuilder(stringInput.Length);
        for (int i = stringInput.Length - 1; i >= 0; i--)
        {
            sBResult.Append(stringInput[i]);
        }

        string stringResult = Convert.ToString(sBResult);
        decimal result = decimal.Parse(stringResult);
        return result;
    }
}
