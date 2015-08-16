// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned uinteger.

using System;

class Problem_15_Bits_Exchange
{
    static void Main()
    {
        Console.WriteLine("Give us a positive uinteger number N:");
        uint number = Convert.ToUInt32(Console.ReadLine());

        uint value3 = (number >> 3) % 2;
        uint value4 = (number >> 4) % 2;
        uint value5 = (number >> 5) % 2;
        uint value24 = (number >> 24) % 2;
        uint value25 = (number >> 25) % 2;
        uint value26 = (number >> 26) % 2;

        if (value3 != value24)
        {
            if (value3 == 0)
            {
                uint mask3 = 8;
                number = (number | mask3);
            }
            else
            {
                uint mask3 = 4294967287;
                number = (number & mask3);
            }

            if (value24 == 0)
            {
                uint mask3 = 16777216;
                number = (number | mask3);
            }
            else
            {
                uint mask3 = 4278190079;
                number = (number & mask3);
            }
        }

        if (value4 != value25)
        {
            if (value4 == 0)
            {
                uint mask = 16;
                number = (number | mask);
            }
            else
            {
                uint mask = 4294967279;
                number = (number & mask);
            }

            if (value25 == 0)
            {
                uint mask = 33554432;
                number = (number | mask);
            }
            else
            {
                uint mask = 4261412863;
                number = (number & mask);
            }
        }

        if (value5 != value26)
        {
            if (value5 == 0)
            {
                uint mask = 32;
                number = (number | mask);
            }
            else
            {
                uint mask = 4294967263;
                number = (number & mask);
            }

            if (value26 == 0)
            {
                uint mask = 67108864;
                number = (number | mask);
            }
            else
            {
                uint mask = 4227858431;
                number = (number & mask);
            }
        }

        Console.WriteLine(number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
