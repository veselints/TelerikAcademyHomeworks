using System;

class Problem_16_Bit_Exchange_Adv
{
    static void Main()
    {
        Console.WriteLine("Give us a positive uinteger number N:");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("First sequence starting poit P:");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second sequence starting poit Q:");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lenght of the sequence K:");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (int i = 0; i < k; i++)
        {
            p = p + i;
            q = q + i;

            uint valueP = (number >> p) % 2;
            uint valueQ = (number >> q) % 2;

            if (valueP != valueQ)
            {
                if (valueP == 0)
                {
                    uint mask = Convert.ToUInt32(1 << p);
                    number = (number | mask);
                    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                }
                else
                {
                    uint mask = ~(Convert.ToUInt32(1 << p));
                    number = (number & mask);
                    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                }

                if (valueQ == 0)
                {
                    uint mask = Convert.ToUInt32(1 << q);
                    number = (number | mask);
                    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                }
                else
                {
                    uint mask = ~(Convert.ToUInt32(1 << q));
                    number = (number & mask);
                    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                }
            }
        }
        Console.WriteLine(number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
