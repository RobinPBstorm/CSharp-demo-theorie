using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure.models
{
    public struct Point2D
    {
        public double X;
        public double Y;

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceOrigine() 
        {
            return CalculDistance(new Point2D(0d, 0d));
        }

        public double DistancePoint(Point2D point2)
        {
            return CalculDistance(point2);
        }
        private double CalculDistance(Point2D point2)
        {
            // distance = racine carré((x2 -x1) ^2 + (y2 - y1) ^ 2)
            double dx = point2.X - X;
            double dy = point2.Y - Y;

            return Math.Sqrt(Math.Pow(dx,2) + Math.Pow(dy,2));

        }
    }
}
