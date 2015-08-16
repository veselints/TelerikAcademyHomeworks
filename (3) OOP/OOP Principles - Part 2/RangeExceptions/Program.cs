using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new InvalidRangeException<int>(2, 50);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            try
            {
                throw new InvalidRangeException<DateTime>(new DateTime(1981, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
