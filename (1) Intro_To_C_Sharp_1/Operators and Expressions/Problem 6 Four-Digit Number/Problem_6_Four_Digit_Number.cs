// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class Problem_6_Four_Digit_Number
{
    static void Main()
    {
        Console.WriteLine("Please, give us a four digit number. Note that the first digit should be different than 0.");
        int givenNumber = Int32.Parse(Console.ReadLine());
        if (((givenNumber / 1000) % 10 == 0) || ((givenNumber / 10000) > 0))
        {
            Console.WriteLine("This is an invalid number!");
        }
        else
        {
            int d = givenNumber % 10;
            int c = (givenNumber / 10) % 10;
            int b = (givenNumber / 100) % 10;
            int a = (givenNumber / 1000) % 10;

            Console.WriteLine("The sum of the digits of the number is {0}.", a + b + c + d);
            Console.WriteLine("The digits in reversed order are " + d + c + b + a + ".");
            Console.WriteLine("The same number with the last digit on the first position is " + d + a + b + c + ".");
            Console.WriteLine("The same number with the second and the third digits exchanged is " + a + c + b + d + ".");
        }
    }
}
