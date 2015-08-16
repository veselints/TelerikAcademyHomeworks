// Problems 1, 2, 3 and 4

// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
// Implement the ToString() to enable printing a 3D point.

// Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
// Add a static property to return the point O.

// Write a static class with a static method to calculate the distance between two points in the 3D space.

// Create a class Path to hold a sequence of points in the 3D space.
// Create a static class PathStorage with static methods to save and load paths from a text file.
// Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1to4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point3D.O);

            Path checkPath = new Path("[0,0,0][1, 3, -4]");

            checkPath.Add(Point3D.O);

            Path probs = new Path("[4,3,5][3,7,8][13,5,2]");

            var listOfPaths = new List<Path>();
            listOfPaths.Add(probs);
            listOfPaths.Add(probs);
            listOfPaths.Add(probs);
            
            Console.WriteLine(probs);

            PathStorage.SavePaths(listOfPaths, "probs");

            var secondListOfPaths = new List<Path>();

            secondListOfPaths = PathStorage.LoadPaths("probs");

            foreach (var path in secondListOfPaths)
            {
                Console.WriteLine(path);
            }
        }

    }
}
