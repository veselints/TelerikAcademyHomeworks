// Write a program that prints to the console which day of the week is today.
// Use System.DateTime.

using System;

class Problem3_Day_of_week
{
    static void Main()
    {
        DateTime dayOfTheWeek = DateTime.Now;

        Console.WriteLine("Today is {0}.", dayOfTheWeek.DayOfWeek);
    }
}
