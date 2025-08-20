using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure.models
{
    public struct Parcours2D
    {
        public List<Point2D> points;

        public Parcours2D (List<Point2D> points)
        {
            this.points = points;
        }
        public Parcours2D (params Point2D[] points)
        {
            this.points = points.ToList();
        }

        public double CalculDistanceTotal()
        {
            if (points.Count() < 2)
            {
                return 0d;
            }

            double distanceTotal = 0d;

            for (int i = 1; i < points.Count(); i++)
            {
                distanceTotal += points[i].DistancePoint(points[i - 1]);
            }
            distanceTotal += points[points.Count() - 1].DistancePoint(points[0]);

            return distanceTotal;
        }
    }
}
