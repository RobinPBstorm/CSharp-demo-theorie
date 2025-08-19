using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_strucutre.models
{
    public struct PersonneStructure
    {
        public string nom;
        public int? age;


        // le constructeur par defaut (sans paramètre) est toujours disponible
        public PersonneStructure(string nom, int age = 18)
        {
            this.nom = nom;
            this.age = age;
        }

        public bool EstMajeur()
        {
            return age >= 18;
        }

        // exemple de méthode utilisant un paramètre par défaut
        public string CouleurFavorite(string couleurParDefaut = "chartreuse")
        {
            return couleurParDefaut;
        }

        public bool SePresenter(out string presentation)
        {
            presentation = "";
            if (nom is null || age is null)
            {
                // on n'a pas les informations pour se présenter
                return false;
            }

            presentation = $"Bonjour je m'appelle {nom} et j'ai {age}";
            return true;
        }
    }
}
