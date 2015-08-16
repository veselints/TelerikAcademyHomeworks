using System;

namespace Problem16_Print_a_long_sequence
{
    class Problem16_Print_a_long_sequence
    {
        static void Main(string[] args)
        {
            for (int value = 2; value < 1002; ++value)
            {
                if (value % 2 == 0)
                {
                    Console.Write("{0}, ", value);
                }
                else
                {
                    Console.Write("{0}, ", -value);
                }
            }
            Console.WriteLine();
        }
    }
}
