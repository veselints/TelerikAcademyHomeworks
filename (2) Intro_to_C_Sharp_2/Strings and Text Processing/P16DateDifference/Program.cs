//  Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give us a date in the format day.month.year: ");
            DateTime a = DateTime.Parse(Console.ReadLine());
            Console.Write("Give us a second date in the format day.month.year: ");
            DateTime b = DateTime.Parse(Console.ReadLine());

            TimeSpan days;

            if (a >= b)
            {
                days = a - b;
            }
            else
            {
                days = b - a;
            }

            string firstDate = a.ToString("dd.MM.yyyy");
            string secondDate = b.ToString("dd.MM.yyyy");

            Console.WriteLine("There are {0} days between {1} and {2}", days.Days, firstDate, secondDate);
        }
    }
}
