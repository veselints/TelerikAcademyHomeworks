namespace SizeClass
{
    using System;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
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

            set
            {
                if (value > 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.height = value;
                }
            }
        }    

        public static Size GetRotatedSize(Size inputSize, double rotationAngle)
        {
            double rotationAgleCos = Math.Cos(rotationAngle);
            double rotationAngleSin = Math.Sin(rotationAngle);
            double rotatedWidth = (rotationAgleCos * inputSize.Width) + (rotationAngleSin * inputSize.Height);
            double rotatedHiegth = (rotationAngleSin * inputSize.Width) + (rotationAgleCos * inputSize.Height);
            Size rotatedSize = new Size(rotatedWidth, rotatedHiegth);
            return rotatedSize;
        }
    }
}
