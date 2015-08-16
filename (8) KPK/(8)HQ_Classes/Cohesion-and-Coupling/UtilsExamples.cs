namespace CohesionAndCoupling
{
    using System;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileNameManipulation.GetFileExtension("example"));
            Console.WriteLine(FileNameManipulation.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameManipulation.GetFileExtension("example.new.pdf"));
            Console.WriteLine(FileNameManipulation.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameManipulation.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameManipulation.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceCalculations.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceCalculations.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cube exampleCube = new Cube(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", exampleCube.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", exampleCube.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", exampleCube.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", exampleCube.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", exampleCube.CalculateDiagonalYZ());
        }
    }
}
