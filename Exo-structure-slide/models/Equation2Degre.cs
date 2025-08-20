using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure_slide.models
{
    public struct Equation2Degre
    {
        // a x^2 + b x + c = 0
        public double A; 
        public double B;
        public double C;

        public Equation2Degre( double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double CalculDeterminant()
        {
            // b² - 4ac
            return Math.Pow(B, 2) - 4 * A * C;
        }

        public bool Resoudre(out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;

            double determinant = CalculDeterminant();
            if (determinant < 0)
            {
                return false;
            }
            else if (determinant == 0)
            {
                x1 = (B * -1) / (2 * A);
                x2 = x1;

                return true;
            }
            else
            {
                x1 = ((B * -1) - Math.Sqrt(determinant)) / (2 * A);
                x2 = ((B * -1) + Math.Sqrt(determinant)) / (2 * A);
                return true;
            }
        }
    }
}
