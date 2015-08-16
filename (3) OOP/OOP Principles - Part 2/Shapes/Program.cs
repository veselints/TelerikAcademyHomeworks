// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
// Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
// Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
// Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapeArray = new Shape[]
            {
                new Square(4.555),
                new Rectangle(4.555, 3),
                new Square(3),
                new Rectangle(55.5, 3),
                new Triangle(455.5, 78.3),
                new Square(55),
                new Triangle(5.55, 3),
                new Triangle(5, 33.3),
                new Triangle(4.555, 3.3)
            };

            for (int i = 0; i < shapeArray.Length; i++)
            {
                Console.WriteLine(shapeArray[i].CalculateSurface());
            }
        }
    }
}
