using System;

namespace Problem9_Print_a_sequence
{
    class Problem9_Print_a_sequence
    {
        static void Main(string[] args)
        {
            for (int value = 2; value < 12; ++value)
            {
                if (value % 2 == 0)
                {
                    Console.Write("{0} ", value);
                }
                else
                {
                    Console.Write("{0} ", -value);
                }
            }
            Console.WriteLine();
        }
    }
}
