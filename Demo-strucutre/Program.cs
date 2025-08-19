using Demo_strucutre.models;

namespace Demo_strucutre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration avec des classes");
            PersonneClasse personne1 = new PersonneClasse();
            personne1 = new PersonneClasse("Roger", 15);
            personne1.nom = "Roger";
            PersonneClasse autreClasse = personne1;
            autreClasse.nom = "Bertrand";

            Console.WriteLine(personne1.nom);


            Console.WriteLine("Demonstration avec des structures");
            PersonneStructure personne2 = new PersonneStructure();
            //personne2 = new PersonneStructure("Roger");
            PersonneStructure autreStructure = personne2;
            autreStructure.nom = "Bertrand";

            Console.WriteLine(personne2.nom);


            //Console.WriteLine(personne2.age);
            //Console.WriteLine(personne2.EstMajeur());
            if (personne2.SePresenter(out string messagePresentation))
            {
                Console.WriteLine(messagePresentation);
            }


            int a = 5;
            int b = 10;
            EchangerValeur(a, b);
            Console.WriteLine($" a = {a}");
            Console.WriteLine($" b = {b}");

            EchangerValeurParRef(ref a, ref b);
            Console.WriteLine($" a = {a}");
            Console.WriteLine($" b = {b}");

            List<int> maListe = CreerList( 1, 2, 3 );
            foreach(int nombre in maListe)
            {
                Console.Write(nombre+ "\t");
            }
            Console.WriteLine();

        }

        // passage de paramètre par valeur (copie)
        public static void EchangerValeur(int valeur1, int valeur2)
        {
            int temp = valeur1;
            valeur1 = valeur2;
            valeur2 = temp;
        }
        // passage de paramètre par référence
        public static void EchangerValeurParRef(ref int valeur1, ref int valeur2)
        {
            int temp = valeur1;
            valeur1 = valeur2;
            valeur2 = temp;
        }

        public static List<int> CreerList (params int[] mesNombres)
        {
            return mesNombres.ToList();
        }
    }
}
