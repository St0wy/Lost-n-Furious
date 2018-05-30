using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLostNFurious
{
    static class GameConstant
    {
        public const int NUM_MUR = 1;
        public const int NUM_ARRIVEE = 2;
        public const int NUM_PERSONNAGE = 3;
        public const int NUM_BORDURE = 4;
        
        public const int POSITION_LABYRINTHE_X = 10;
        public const int POSITION_LABYRINTHE_Y = 10;
        public const int NOMBRE_SORTIES = 3;
        
        public const int DUREE_UNE_SECONDE_EN_MS = 1000;
        
        public const int POSITION_CODE_VICTOIRE_X = 0;
        public const int POSITION_CODE_VICTOIRE_Y = -10;
        
        public const int CODE_MIN = 10;
        public const int CODE_MAX = 50;
        
        public const int TAILLE_BLOC_X = 70;
        public const int TAILLE_BLOC_Y = 70;

        public const string IP_CIBLE = "127.0.0.1";
        public const int PORT_CIBLE = 1081;
        public const int PORT_HOTE = 1080;

        public const int TAG_ARRIVEE = 1;
    }
}
