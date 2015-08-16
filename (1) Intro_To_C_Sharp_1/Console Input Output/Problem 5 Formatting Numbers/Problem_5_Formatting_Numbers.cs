// Write a program that reads 3 numbers:
//    integer a (0 <= a <= 500)
//    floating-point b
//    floating-point c
// The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//    The number b should be printed with 2 digits after the decimal point, right aligned
//    The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class Problem_5_Formatting_Numbers
{
    static void Main()
    {
        GoHere:
        try
        {
            Console.Write("Give us a integer number between 0 and 500 a = ");
            int a = Int32.Parse(Console.ReadLine());
            if (a < 0 || a > 500)
            {
                Console.WriteLine("The number \"a\" must be between 0 and 500!");
                goto GoHere;
            }
            else
            {
                Console.Write("Give us a floating-point number b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Give us a floating-point number c = ");
                double c = double.Parse(Console.ReadLine());
                string aAsAString = Convert.ToString(a, 2);

                Console.Write("{0, -10 :X} ", a);
                Console.Write("|");
                Console.Write(aAsAString.PadLeft(10, '0'));
                Console.Write("|");
                Console.Write("{0, 10 :F2}", b);
                Console.Write("|");
                Console.Write("{0, -10 :F3}", c);
                Console.WriteLine("|");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong data format!");
        }
    }
}