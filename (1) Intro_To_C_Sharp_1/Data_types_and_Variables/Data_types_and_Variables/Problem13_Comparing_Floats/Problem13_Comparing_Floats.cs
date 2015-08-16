//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class Problem13_Comparing_Floats
{
    static void Main()
    {
        double a = 5.3;
        double b = 6.01;
        Console.Write("Is \"a\" equal to \"b\"? - ");
        double abDifference = Math.Abs(a - b);
        bool abEqual = (abDifference < 0.000001);
        Console.WriteLine( abEqual);

        double c = 5.00000001;
        double d = 5.00000003;
        Console.Write("Is \"c\" equal to \"d\"? - ");
        double cdDifference = Math.Abs(c - d);
        bool cdEqual = (cdDifference < 0.000001);
        Console.WriteLine(cdEqual);

        double e = 5.00000005;
        double f = 5.00000001;
        Console.Write("Is \"e\" equal to \"f\"? - ");
        double efDifference = Math.Abs(e - f);
        bool efEqual = (efDifference < 0.000001);
        Console.WriteLine(efEqual);

        double g = -0.0000007;
        double h = 0.00000007;
        Console.Write("Is \"g\" equal to \"h\"? - ");
        double ghDifference = Math.Abs(g - h);
        bool ghEqual = (ghDifference < 0.000001);
        Console.WriteLine(ghEqual);

        double i = -4.999999;
        double j = -4.999998;
        Console.Write("Is \"i\" equal to \"j\"? - ");
        double ijDifference = Math.Abs(i - j);
        bool ijEqual = (ijDifference < 0.000001);
        Console.WriteLine(ijEqual);

        double k = 4.999999;
        double l = 4.999998;
        Console.Write("Is \"k\" equal to \"l\"? - ");
        double klDifference = Math.Abs(k - l);
        bool klEqual = (klDifference < 0.000001);
        Console.WriteLine(klEqual);
    }
}
