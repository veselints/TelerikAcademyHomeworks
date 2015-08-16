// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class Problem_10_Inside_Circle_Outside_Rectangle
{
    static void Main()
    {
        Console.WriteLine("Check if a your point in within our circle and outside our rectangular");
        Console.Write("Give us the X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Give us the Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        bool inCircle = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5;

        bool outRectangularHeight = (y > 1 || y < -1);
        bool outRectangularWidth = (x > 5 || x < -1);
        bool outRectangular = (outRectangularHeight || outRectangularWidth);

        Console.WriteLine(outRectangular && inCircle);
    }
}
