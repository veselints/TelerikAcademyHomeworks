// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class Problem5_Workdays
{
    static List<DateTime> publicHolydays;
    static void Main()
    {
        publicHolydays = new List<DateTime>()
            {new DateTime(2015, 3, 2),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
            new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),
            new DateTime(2015, 5, 16),new DateTime(2015, 6, 13),new DateTime(2015, 6, 15)};

        DateTime currentDateTime = DateTime.Now;
        DateTime currentDate = currentDateTime.Date;
        Console.Write("Tell us future date: ");
        DateTime futureDate = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine(CountWorkdays(currentDate, futureDate));
    }

    private static string CountWorkdays(DateTime startDate, DateTime endDate)
    {
        int workDays = 0;
        int holydays = 0;
        int weekends = 0;
        DateTime current = startDate.AddDays(1);

        while (current <= endDate)
        {
            if (publicHolydays.Contains(current))
                ++holydays;
            else if ((int)current.DayOfWeek == 0 || (int)current.DayOfWeek == 6)
                ++weekends;
            else
                ++workDays;

            current = current.AddDays(1);
        }

        return String.Format(@"
Holydays:   {0}
Weekends:   {1}
Workdays:   {2}
", holydays, weekends, workDays);
    }
}
