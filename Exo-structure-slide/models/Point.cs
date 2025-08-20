using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure_slide.models
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point (int ligne, int colonne)
        {
            X = colonne;
            Y = ligne;
        }

        public string AffichagePoint()
        {
            return $"X : {X} -Y : {Y} ";
        }
    }
}
