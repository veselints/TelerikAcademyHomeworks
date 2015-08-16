using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double heght, double width)
        : base (heght, width)
        {}

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width / 2;
            return surface;
        }
    }
}
