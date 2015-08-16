// Write a method that returns the last digit of given integer as an English word.

using System;

class Problem3_English_digit
{
    static void Main()
    {
        Console.Write("Tell us an integer number: ");
        int number = int.Parse(Console.ReadLine());
        LastDigitAsAWord(number);
    }

    public static void LastDigitAsAWord(int integer)
    {
        int lastDigit = integer % 10;
        switch (lastDigit)
        {
            case 0: Console.WriteLine("The last digit is zero");
                break;
            case 1: Console.WriteLine("The last digit is one");
                break;
            case 2: Console.WriteLine("The last digit is two");
                break;
            case 3: Console.WriteLine("The last digit is three");
                break;
            case 4: Console.WriteLine("The last digit is four");
                break;
            case 5: Console.WriteLine("The last digit is five");
                break;
            case 6: Console.WriteLine("The last digit is six");
                break;
            case 7: Console.WriteLine("The last digit is seven");
                break;
            case 8: Console.WriteLine("The last digit is eight");
                break;
            case 9: Console.WriteLine("The last digit is nine");
                break;
        }

    }
}
