using Demo_enum.models;
using Demo_enum.enums;

namespace Demo_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Couleur couleur = default;
            Vehicule vehicule = Vehicule.Bus | Vehicule.Trotinette;
            Personne personne = new Personne(couleur, vehicule);
            Console.WriteLine(personne.CouleurFavorite);
            Console.WriteLine(personne.MoyenDeTransport);

            if (personne.MoyenDeTransport.HasFlag(Vehicule.Bus))
            {
                Console.WriteLine("Cette personne vient en bus");
            }

            foreach (string valeur in Enum.GetNames<Couleur>())
            {
                Console.WriteLine($"{valeur}");
            }
        }
    }
}
