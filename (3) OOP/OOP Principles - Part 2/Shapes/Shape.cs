using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                try
                {
                    if (value <= 0)
	                {
		                 throw new ArgumentOutOfRangeException("The width shold be positive number!");
	                }
                    else
	                {
                        this.width = value;
	                }
                }
                catch (ArgumentException e)
                {
                    
                    throw new ArgumentException(e.Message);
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException("The width shold be positive number!");
                    }
                    else
                    {
                        this.height = value;
                    }
                }
                catch (ArgumentException e)
                {

                    throw new ArgumentException(e.Message);
                }
            }
        }

        public abstract double CalculateSurface();

    }
}
