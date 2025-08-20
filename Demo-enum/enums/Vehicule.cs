using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_enum.enums
{
    [Flags] // rajoute des fonctions pour ce type d'enum et change l'affichage des valeurs
    public enum Vehicule
    {
        // Chaque valeur de l'enum est associé à une exposant de 2
        None =       0b_0000_0000, // 0
        Voiture =    0b_0000_0001, // 1
        Bus =        0b_0000_0010, // 2
        Moto =       0b_0000_0100, // 4
        Trotinette = 0b_0000_1000, // 8
        Velo =       0b_0001_0000 // 16
    }
}
