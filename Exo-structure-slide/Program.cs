using Exo_structure_slide.models;
using System.Diagnostics.CodeAnalysis;

namespace Exo_structure_slide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partie 1 : tableau de Point
            //Point?[,] tableau = new Point?[5,5];

            ////tableau[0, 0] = new Point(0, 0);
            ////tableau[1, 1] = new Point(1, 1);
            ////tableau[2, 2] = new Point(2, 2);
            ////tableau[3, 3] = new Point(3, 3);
            ////tableau[4, 4] = new Point(4, 4);


            //for (int i = 0; i < tableau.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tableau.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            tableau[i, j] = new Point(i, j);
            //        }
            //    }
            //}

            //for (int i = 0; i < tableau.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tableau.GetLength(1); j++)
            //    {
            //        if (tableau[i,j] is null)
            //        {
            //            Console.Write("\t");
            //        }
            //        else
            //        {
            //            Console.Write(tableau[i,j].Value.AffichagePoint());
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // Partie 2 & 3 Fahrenheit et Celsius
            //Fahrenheit fahrenheit = new Fahrenheit(32);
            //Console.WriteLine(fahrenheit.AffichageFahrenheit());
            //Console.WriteLine(fahrenheit.ToCelsius().AffichageCelsius());

            //Celsius celsius = new Celsius(0);
            //Console.WriteLine(celsius.AffichageCelsius());
            //Console.WriteLine(celsius.ToFahrenheit().AffichageFahrenheit());

            // Partie 4 Equation 2em degré
            Equation2Degre equation = new Equation2Degre(1, -5, 6);
            double x1, x2;
            if (equation.Resoudre(out x1,out x2))
            {
                Console.WriteLine($"{x1} {x2}");
            }
            else
            {
                Console.WriteLine("Il n'y a pas de réponse");
            }
        }
    }
}
