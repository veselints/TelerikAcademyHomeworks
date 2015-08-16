using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1to4
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;


        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                try
                {
                    this.x = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a number");
                }
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                try
                {
                    this.y = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a number");
                }
            }
        }
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                try
                {
                    this.z = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a number");
                }
            }
        }

        public override string ToString()
        {
            return String.Format("[{0},{1},{2}]", this.x, this.y, this.z);
        }

        public Point3D(double x, double y, double z)
            :this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        private static readonly Point3D o = new Point3D (0, 0, 0);

        public static Point3D O
        {
            get
            {
                return o;
            }
        }
    }
}
