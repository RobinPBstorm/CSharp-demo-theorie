using Exo_structure.models;

namespace Exo_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partie 1 : struct Point2D
            //Point2D pointA = new Point2D(5.5d, -1.5d);
            //Point2D pointB = new Point2D(8d, 19d);
            //Console.WriteLine(pointA.DistancePoint(pointB));

            // Partie 2 : Collection de Point2D
            //Parcours2D monParcours = new Parcours2D(
            //    new List<Point2D>()
            //    {
            //        new Point2D (2d, 2d),
            //        new Point2D (5d, 5d),
            //        new Point2D (5d, -7d)
            //    }
            //);
            //// Si on emploit le 2em constructeur
            ////Parcours2D monParcours = new Parcours2D(
            ////    new Point2D(2d, 2d),
            ////    new Point2D(5d, 5d),
            ////    new Point2D(5d, -7d)
            ////);

            //double distanceTotal = monParcours.CalculDistanceTotal();
            //Console.WriteLine(distanceTotal);

            // Partie3 : structure imbriquée
            Address monAddress = new Address("Rue du centre", "Gosselie", 6041);
            Console.WriteLine(monAddress.AfficherAddress());

            Client monClient = new Client("Dupont Kévin", monAddress);
            Console.WriteLine(monClient.AfficherClient());
        }
    }
}
