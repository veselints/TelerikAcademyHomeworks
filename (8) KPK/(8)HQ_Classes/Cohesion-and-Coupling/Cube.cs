using System;

namespace CohesionAndCoupling
{
    public class Cube
    {
        private double width;
        private double height;
        private double depth;

        public Cube(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The width must be positive number.");
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The height must be positive number.");
                }
            }
        }

        public double Depth
        {
            get { return this.depth; }
            set
            {
                if (value > 0)
                {
                    this.depth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The depth must be positive number.");
                }
            }
        }
        
        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = DistanceCalculations.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = DistanceCalculations.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = DistanceCalculations.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = DistanceCalculations.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
