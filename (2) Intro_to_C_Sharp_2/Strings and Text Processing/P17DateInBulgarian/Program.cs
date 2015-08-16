using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace P17DateInBulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Give us a date in the format day.month.year hour:minute:second : "); 
            DateTime date = DateTime.Parse(Console.ReadLine());
            date = date.AddHours(6.5);

            string dayOfWeek = "today";

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Friday: dayOfWeek = "петък";
                    break;
                case DayOfWeek.Monday: dayOfWeek = "понеделник";
                    break;
                case DayOfWeek.Saturday: dayOfWeek = "събота";
                    break;
                case DayOfWeek.Sunday: dayOfWeek = "неделя";
                    break;
                case DayOfWeek.Thursday: dayOfWeek = "четвъртък";
                    break;
                case DayOfWeek.Tuesday: dayOfWeek = "вторник";
                    break;
                case DayOfWeek.Wednesday: dayOfWeek = "сряда";
                    break;
            }

            Console.WriteLine("{0}, {1}", date.ToString("dd.MM.yyyy HH:mm:ss"), dayOfWeek);
        }
    }
}
