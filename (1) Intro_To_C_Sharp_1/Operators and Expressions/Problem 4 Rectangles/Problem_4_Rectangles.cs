// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Problem_4_Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please tell us what is the width of your rectangular:");
        double rectangularWidth = double.Parse(Console.ReadLine());
        Console.WriteLine("Please tell us what is the height of your rectangular:");
        double rectangularHeight = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter of your rectangular is {0} and its area is {1}.", 2 * rectangularHeight + 2 * rectangularWidth, rectangularWidth * rectangularHeight);
    }
}