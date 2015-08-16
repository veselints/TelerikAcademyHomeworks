using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_Timer
{
    public delegate void TimerDelegate();

    class Timer
    {
        static void Main(string[] args)
        {
            TimerDelegate testDelegate = SecondChange;
            testDelegate();
        }

        public static void SecondChange()
        {
            int second = DateTime.Now.Second;
            int counter = 0;
            
            while (counter < 10)
            {
                int secondNow = DateTime.Now.Second;
                if (secondNow != second)
                {
                    Console.WriteLine("Time is going away...");
                    second = secondNow;
                    counter++;
                }
            } 

        }
    }
}
