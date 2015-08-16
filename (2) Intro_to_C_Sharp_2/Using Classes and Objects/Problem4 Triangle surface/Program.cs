// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

using System;

class Program
{
    static double result = 0;

    static void Main()
    {
        Console.WriteLine("This programme calculates the surface of a given triangle.");
        MakeChoice();
        
        Console.WriteLine("The surface of the given triangle is {0}.", result);
    }

    static double MakeChoice()
    {
        Console.WriteLine("Choose the tipe of the initial information you will enter:");
        Console.WriteLine("1 - Enter a side and an altitude to it");
        Console.WriteLine("2 - Enter three sides");
        Console.WriteLine("3 - Enter two sides and an angle between them");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter the lenght of the side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter the altitude to the side: ");
            double altitude = double.Parse(Console.ReadLine());
            SurfaceBySideAndAltitude(side, altitude);
        }
        else if (choice == 2)
        {
            Console.Write("Enter the lenght of the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the lenght of the second side: ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the lenght of the third side: ");
            double thirdSide = double.Parse(Console.ReadLine());
            SurfaceByThreeSides(firstSide, secondSide, thirdSide);
        }
        else if (choice == 3)
        {
            Console.Write("Enter the lenght of the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the lenght of the second side: ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the angle between the two sides: ");
            double angle = double.Parse(Console.ReadLine()); 
            SurfaceBySidesAndAngle(firstSide, secondSide, angle);
        }
        else 
        {
            Console.WriteLine("You have entered invalid choice!");
            MakeChoice();
        }
        return result;
    }

    static double SurfaceBySideAndAltitude(double side, double altitude)
    {
        result = side * altitude / 2;
        return result;
    }

    static double SurfaceByThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        result = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
        return result;
    }

    static double SurfaceBySidesAndAngle(double firstSide, double secondSide, double angle)
    {
        double radiansAngle = (Math.PI / 180) * angle;
        double sinAngle = Math.Sin(radiansAngle);
        result = firstSide * secondSide * sinAngle / 2;

        return result;
    }
}
