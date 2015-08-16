using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1to4
{
    public static class Point3DCalculations
    {
        public static double CalculateDistanceBetweenTwoPoits(Point3D p, Point3D q)
        {
            return Math.Sqrt((p.X - q.X) * (p.X - q.X) + (p.Y - p.Y) * (p.Y - p.Y) + (p.Z - p.Z) * (p.Z - p.Z));
        }
    }
}
