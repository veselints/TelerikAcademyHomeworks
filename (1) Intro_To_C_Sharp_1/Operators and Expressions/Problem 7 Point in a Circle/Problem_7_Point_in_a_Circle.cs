// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

using System;

class Problem_7_Point_in_a_Circle
{
    static void Main()
    {
        Console.WriteLine("We are looking for poits that are located within a circle with radius = 2.");
        Console.WriteLine("Please give us the coordinates of a poit to check whether it is within the circle.");
        Console.Write("Give us a X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Give us a Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        double rPoint = Math.Sqrt(x*x + y*y);
        bool check = (rPoint <= 2);

        Console.WriteLine(check);
    }
}