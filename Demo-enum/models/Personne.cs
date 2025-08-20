using Demo_enum.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_enum.models
{
    public struct Personne
    {
        public Couleur CouleurFavorite;

        public Vehicule MoyenDeTransport;

        public Personne(Couleur couleur, Vehicule vehicule)
        {
            CouleurFavorite = couleur;
            MoyenDeTransport = vehicule;
        }
    }
}
