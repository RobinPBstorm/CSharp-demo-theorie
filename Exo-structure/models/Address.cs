using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure.models
{
    public struct Address
    {
        public string Rue;
        public string Ville;
        public int CodePostal;

        public Address(string rue, string ville, int codePostal)
        {
            Rue = rue;
            Ville = ville;
            CodePostal = codePostal;
        }

        public string AfficherAddress()
        {
            return $"{Rue} à {Ville} {CodePostal}";
        }

    }
}
