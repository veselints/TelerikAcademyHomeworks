//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console

using System;

class Problem5_Boolean_Variable
{
    static void Main()
    {
        Console.WriteLine("Are you a female? True/False");
        bool isFimale = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine(isFimale);
    }
}