//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class Problem12_Null_Values_Arithmetic
{
    static void Main()
    {
        int? integerValue = null;
        double? doubleValue = null;

        Console.WriteLine(integerValue);
        Console.WriteLine(doubleValue);

        int secondInt = (int)integerValue + 5;
        double secondDouble = (double)doubleValue + 5.01;

        Console.WriteLine(secondInt);
        Console.WriteLine(secondDouble);
    }
}

//Кодът дава грешка. Не позволява към променливи със стойност null да бъдат прибавяни стойности.
