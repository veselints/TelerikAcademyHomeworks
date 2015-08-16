// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;

class Problem1_Leap_year
{
    static void Main()
    {
        Console.Write("Give us a year: ");
        string stringYear = Console.ReadLine();
        DateTime year = new DateTime(int.Parse(stringYear), 1, 1);
        int intYear = year.Year;

        if (intYear % 4 == 0)
        {
            Console.WriteLine("The year {0} is a leap one.", year.ToString("yyyy"));
        }
        else
        {
            Console.WriteLine("The year {0} is not a leap one.", year.ToString("yyyy"));
        }
    }
}