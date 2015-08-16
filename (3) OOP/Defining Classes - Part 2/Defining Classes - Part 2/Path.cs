using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1to4
{
    public class Path : List<Point3D>
    {
        public Path()
        {
        }
        public Path(string line)
        {
            string[] points = line.Split(new char[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < points.Length; i++)
            {
                string[] currentPoint = points[i].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                double pointX = double.Parse(currentPoint[0]);
                double pointY = double.Parse(currentPoint[1]);
                double pointZ = double.Parse(currentPoint[2]);
                this.Add(new Point3D(pointX, pointY, pointZ));
            }
        }

        public override string ToString()
        {
            string result = null;
            foreach (Point3D point in this)
            {
                result = result + point;
            }
            return result;
        }
    }
}
