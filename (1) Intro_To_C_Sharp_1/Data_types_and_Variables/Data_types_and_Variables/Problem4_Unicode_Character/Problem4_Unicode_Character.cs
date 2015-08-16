//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

using System;

class Problem4_Unicode_Character
{
    static void Main()
    {
        char unicodeCharacter = '\u002A';

        Console.WriteLine((char)unicodeCharacter);
    }
}