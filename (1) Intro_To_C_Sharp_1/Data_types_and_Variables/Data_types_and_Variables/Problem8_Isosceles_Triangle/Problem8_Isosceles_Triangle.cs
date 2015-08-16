//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
// ©

// © ©

// ©   ©

// © © © ©

using System;
using System.Text;

class Problem8_Isosceles_Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
            
        char copyrightSymbol = '\u00A9';

        Console.WriteLine("   " + copyrightSymbol);
        Console.WriteLine("  " + copyrightSymbol + " " + copyrightSymbol);
        Console.WriteLine(" " + copyrightSymbol + "   " + copyrightSymbol);
        Console.WriteLine(copyrightSymbol + " " + copyrightSymbol + " " + copyrightSymbol + " " + copyrightSymbol);
    }
}

