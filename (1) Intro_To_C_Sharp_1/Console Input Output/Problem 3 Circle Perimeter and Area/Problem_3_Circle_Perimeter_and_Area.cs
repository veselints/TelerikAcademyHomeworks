// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class Problem_3_Circle_Perimeter_and_Area
{
    static void Main()
    {
        Console.Write("Please, give us the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * 22 / 7 * radius;
        double area = 22 / 7 * radius * radius;

        Console.WriteLine("The perimeter of the circle is {0}.", perimeter, 0.00);
        Console.WriteLine("The area of the circle is {0}.", area, 0.00);
    }
}
