using System;

namespace Problem15_Age_after_10_years
{
    class Problem15_Age_after_10_years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday? (dd.mm.yyyy)");

            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate - birthDate;
            double differenceDays = difference.TotalDays;

            int currentDays= Convert.ToInt32(differenceDays);
            int currentAge = currentDays / 365;
            int ageAfter10Years = currentAge + 10;

            Console.WriteLine("Your current age is {0}.", currentAge);
            Console.WriteLine("Your age after 10 years will be {0}.", ageAfter10Years);
        }
    }
}
