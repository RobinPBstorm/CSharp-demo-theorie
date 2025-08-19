using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Exo_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 1 – Stocker une liste de prénoms
            //Console.WriteLine("Exercice 1");
            //List<string> prenoms = new List<string>();

            //string choixUtilisateur;
            //do
            //{
            //    Console.WriteLine("Veuillez entrer un prénom (tapper fin pour arrêter):");
            //    choixUtilisateur = Console.ReadLine();

            //    if (choixUtilisateur.ToLower() != "fin")
            //    {
            //        prenoms.Add(choixUtilisateur);
            //    }

            //} while (choixUtilisateur.ToLower() != "fin");

            //Console.WriteLine("Voici les prénoms rentrés:");
            //foreach (string prenom in prenoms)
            //{
            //    Console.Write($"{prenom}\t");
            //}
            #endregion

            #region Exercice 2 – Somme et moyenne d'une liste de notes
            //Console.WriteLine("Exercice2");

            //List<int> notes = new List<int>();

            //string choixUtilisateur2;
            //do
            //{
            //    Console.WriteLine("Proposez une note entre 0 et 20 (-1 pour finir):");
            //    choixUtilisateur2 = Console.ReadLine();

            //    if (int.TryParse(choixUtilisateur2, out int note))
            //    {
            //        if (note == -1)
            //        {
            //            Console.WriteLine("Au revoir");
            //        }
            //        else if (note >= 0 && note <= 20)
            //        {
            //            notes.Add(note);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Votre proposition n'est pas valide");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Vous n'avez pas rentrer un nombre");
            //    }

            //} while (choixUtilisateur2 != "-1");

            //int max = 0;
            //float moyenne = 0;
            //foreach (int note in notes)
            //{
            //    if (note > max)
            //    {
            //        max = note;
            //    }
            //    moyenne += note;
            //}
            //moyenne /= notes.Count();
            //Console.WriteLine($"La moyenne est de {moyenne} et le max est {max}");
            #endregion

            #region Exercice 3 – Tableau de noms trié
            //Console.WriteLine("Exercice 3");
            //List<string> prenoms3 = new List<string>();

            //string choixUtilisateur;
            //do
            //{
            //    Console.WriteLine("Veuillez entrer un prénom:");
            //    choixUtilisateur = Console.ReadLine();

            //    prenoms3.Add(choixUtilisateur);

            //} while (prenoms3.Count() < 5);

            //Console.WriteLine("Voici les prénoms rentrés:");

            //prenoms3.Sort();

            //foreach (string prenom in prenoms3)
            //{
            //    Console.Write($"{prenom}\t");
            //}
            #endregion

            #region Exercice 4 – Dictionnaire des capitales
            //Console.WriteLine("Exerice4");

            //Dictionary<string, string> capitals = new Dictionary<string, string>()
            //{
            //    { "belgique", "bruxelles" },
            //    { "france", "paris" },
            //    { "mexique", "mexico" },
            //    { "angleterre", "londres" },
            //    { "allemagne", "berlin" }
            //};

            //Console.WriteLine("Donnez moi un pays:");
            //string choixUtiliateur4 = Console.ReadLine();

            //if (capitals.TryGetValue(choixUtiliateur4.ToLower(),out string capitalTrouve))
            //{
            //    Console.WriteLine($"{capitalTrouve} est la capial de {choixUtiliateur4}.");
            //}
            //else
            //{
            //    Console.WriteLine("Je ne connais pas ce Pays!");
            //}
            #endregion

            #region Exercice 5 – Gestion de file d'attente
            //Console.WriteLine("Exercice 5");

            //Queue<string> fileAttente = new Queue<string>();

            //string choixUtilisateur5;
            //do
            //{
            //    Console.WriteLine("- - - - -");
            //    Console.WriteLine("1 - Ajouter une Personne");
            //    Console.WriteLine("2 - Servir une Personne");
            //    Console.WriteLine("3 - Afficher la file d'attente");
            //    choixUtilisateur5 = Console.ReadLine();

            //    switch (choixUtilisateur5)
            //    {
            //        case "1":
            //            Console.WriteLine("Donnez le nom de la personne qui s'ajoute à la file:");
            //            string nom = Console.ReadLine();
            //            fileAttente.Enqueue(nom);
            //            break;
            //        case "2":
            //            if (fileAttente.TryDequeue(out string personneSuivante))
            //            {
            //                Console.WriteLine($"On sert {personneSuivante}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Il n'y a personne dans la file");
            //            }
            //            break;
            //        case "3":
            //            if (fileAttente.Count() > 0)
            //            {
            //                Console.WriteLine("Actuellement en train d'attendre");
            //                foreach (string prenom in fileAttente)
            //                {
            //                    Console.Write($"{prenom}\t");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Il n'y a personne dans la file");
            //            }

            //            break;
            //        default:
            //            Console.WriteLine("Au revoir");
            //            break;
            //    }

            //} while (choixUtilisateur5 == "1" || choixUtilisateur5 == "2" || choixUtilisateur5 == "3");
            #endregion

            #region Exercice 6 – Ctrl + z / ctrl + y simplifié
            //Console.WriteLine("Exercice 6");

            //Stack<string> actions = new Stack<string>();

            //string choixUtilisateur6;
            //do
            //{
            //    Console.WriteLine("- - - - -");
            //    Console.WriteLine("1 - Ajouter une action");
            //    Console.WriteLine("2 - Annuler la dernière action");
            //    Console.WriteLine("3 - Voir l'action en cours");
            //    choixUtilisateur6 = Console.ReadLine();

            //    switch (choixUtilisateur6)
            //    {
            //        case "1":
            //            Console.WriteLine("Quelle est l'action à effectuer?");
            //            string action = Console.ReadLine();

            //            actions.Push(action);
            //            break;
            //        case "2":
            //            if (actions.TryPop(out string actionAnnulee))
            //            {
            //                Console.WriteLine($"{actionAnnulee} a été annulé");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Il n'y a plus d'action dans la liste");
            //            }
            //            break;
            //        case "3":
            //            if (actions.TryPeek(out string actionTrouvee))
            //            {
            //                Console.WriteLine($"l'action en cours est {actionTrouvee}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Il n'y a plus d'action dans la liste");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Au revoir");
            //            break;
            //    }

            //} while (choixUtilisateur6 == "1" || choixUtilisateur6 == "2" || choixUtilisateur6 == "3");
            #endregion

            #region Exercice 7 – Supprimer les doublons dans une liste
            //Console.WriteLine("Exercice 7");
            //List<string> mots = new List<string>();
            ////HashSet<string> mots = new HashSet<string>();

            //string choixUtilisateur;
            //do
            //{
            //    Console.WriteLine("Veuillez entrer un mot (tapper fin pour arrêter):");
            //    choixUtilisateur = Console.ReadLine();

            //    if (choixUtilisateur.ToLower() != "fin")
            //    {
            //        mots.Add(choixUtilisateur);
            //    }

            //} while (choixUtilisateur.ToLower() != "fin");

            //Console.WriteLine("Voici les mots rentrés:");

            ////List<string> motsDisctincts = mots.Distinct().ToList();
            //HashSet<string> motsDisctincts = mots.ToHashSet();

            //foreach (string mot in motsDisctincts)
            //{
            //    Console.Write($"{mot}\t");
            //}
            #endregion

            #region Exercice 8 : Statistique de mot dans une phrase
            Console.WriteLine("Exercice 8");

            Dictionary<string, int> occurenceMot = new Dictionary<string, int>();

            Console.WriteLine("Proposez une phrase à analyser:");
            string phrase = Console.ReadLine();
            string clean = Regex.Replace(phrase, @"[^\w\sàâäéèêëîïôöùûüç]", "").ToLower();

            List<string> mots = clean.Split(" ").ToList();

            foreach (string mot in mots)
            {
                if (occurenceMot.ContainsKey(mot))
                {
                    occurenceMot[mot]++;
                }
                else
                {
                    occurenceMot[mot] = 1;
                }
            }

            foreach (string mot in occurenceMot.OrderByDescending(x => x.Value).ToDictionary().Keys)
            {
                Console.WriteLine($"{mot} : {occurenceMot[mot]}");
            }

            #endregion
        }
    }
}
