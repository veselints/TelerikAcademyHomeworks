﻿namespace Abstraction
{
    using System;

    class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The radius must be positive number.");
                }
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
