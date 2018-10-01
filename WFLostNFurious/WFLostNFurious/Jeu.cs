using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLostNFurious
{
    static class Jeu
    {
        //Propriete
        #region const
        public const int NUM_MUR = 1;
        public const int NUM_ARRIVEE = 2;
        public const int NUM_PERSONNAGE = 3;
        public const int NUM_BORDURE = 4;

        public const string AVANCER = "Avancer";
        public const string PIVOTER_GAUCHE = "Pivoter à gauche";
        public const string PIVOTER_DROITE = "Pivoter à droite";

        public const int POSITION_LABYRINTHE_X = 400;
        public const int POSITION_LABYRINTHE_Y = 10;
        public const int NOMBRE_SORTIES = 3;
        public const int DUREE_UNE_SECONDE_EN_MS = 1000;
        public const int POSITION_CODE_VICTOIRE_X = 0;
        public const int POSITION_CODE_VICTOIRE_Y = -10;

        public const int CODE_MIN = 10;
        public const int CODE_MAX = 50;

        public const int TAILLE_BLOC_X = 70;
        public const int TAILLE_BLOC_Y = 70;

        public const string CODE_DE_BASE = "F";
        #endregion
        static bool estEnJeu;
        static Bloc arriveeDemandee;
        static Random rnd;

        //Champs
        static public bool EstEnJeu { get => estEnJeu; set => estEnJeu = value; }
        static public Bloc ArriveeDemandee { get => arriveeDemandee; set => arriveeDemandee = value; }
        public static Random Rnd { get => rnd; set => rnd = value; }

        //Constructeur
        static Jeu()
        {
            EstEnJeu = false;
            ArriveeDemandee = new Arrivee();
            Rnd = new Random();
        }

        //Methodes
        /// <summary>
        /// Definit la nouvelle arrivee a atteindre
        /// </summary>
        static public void NouvelleArrivee(List<Bloc> lstLabyrinthe)
        {
            int valArrive = Rnd.Next(Jeu.NOMBRE_SORTIES);
            int tmp = 0;

            //Regarde chaque bloc du labyrinthe
            foreach (Bloc m in lstLabyrinthe)
            {
                if (m is Arrivee)
                {
                    if (valArrive == tmp) //Prend une arrivee aleatoirement et la met dans une variable pour s'en souvenir
                    {
                        arriveeDemandee = m;
                        (arriveeDemandee as Arrivee).Activate();
                    }
                    tmp++;
                }
            }
        }
    }
}
