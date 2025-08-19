using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_strucutre.models
{
    public class PersonneClasse
    {
        public string nom;
        public int age;

        // le constructeur par defaut (sans paramètre) n'est plus accessible
        // on doit donc le réécrire explicitment pour pouvoir l'employer
        public PersonneClasse() 
        { 
        }
        public PersonneClasse(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

        public bool EstMajeur()
        {
            return age >= 18;
        }
    }
}
