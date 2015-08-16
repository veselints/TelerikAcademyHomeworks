using System;

class Problem_10_Beer_Time
{
    static void Main()
    {
        try
        {
            Console.Write("Check if it is beer time! Tell us the time in format \"hh:mm tt\": ");
            DateTime pointedTime = DateTime.Parse(Console.ReadLine());
            TimeSpan time = pointedTime.TimeOfDay;
            TimeSpan start = new TimeSpan(3, 0, 0);
            TimeSpan end = new TimeSpan(13, 0, 0);

            Console.WriteLine(time);

            if (start <= time && end >= time)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}