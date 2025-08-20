using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure.models
{
    public struct Client
    {
        public string Nom;
        public Address Adresse;

        public Client(string nom, Address adresse)
        {
            Nom = nom;
            Adresse = adresse;
        }

        public string AfficherClient()
        {
            return $"{Nom} habitant le {Adresse.AfficherAddress()}";
        }
    }
}
