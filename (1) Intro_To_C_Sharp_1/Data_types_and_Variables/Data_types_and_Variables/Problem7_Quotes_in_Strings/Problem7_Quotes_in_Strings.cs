//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class Problem7_Quotes_in_Strings
{
    static void Main()
    {
        string quotationWithEscape = "The \"use\" of quotations causes difficulties.";
        string quotationWithAQuoted = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotationWithEscape);
        Console.WriteLine(quotationWithAQuoted);
    }
}
