using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLostNFurious
{
    class Personnage
    {
        const int TAILLE_BLOC_X = 30;
        const int TAILLE_BLOC_Y = 30;

        enum Direction { Haut, Bas, Gauche, Droite};

        private PointF position;
        private int orientation;

        public PointF Position { get => position; set => position = value; }
        public int Orientation { get => orientation; set => orientation = value; }

        public Personnage(PointF position , int orientation)
        {
            // Initialisation des variables d'instances
            this.Position = position;
            this.Orientation = orientation;

            this.Position = new PointF(position.X, position.Y);
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            Image droite = Properties.Resources.raichuDroite;
            Image gauche = Properties.Resources.raichuGauche;
            Image haut = Properties.Resources.raichuHaut;
            Image bas = Properties.Resources.raichuBas;

            switch (Orientation)
            {
                case (int)Direction.Gauche:
                    e.Graphics.DrawImage(gauche, Position.X, Position.Y, TAILLE_BLOC_X, TAILLE_BLOC_Y);
                    break;
                case (int)Direction.Droite:
                    e.Graphics.DrawImage(droite, Position.X, Position.Y, TAILLE_BLOC_X, TAILLE_BLOC_Y);
                    break;
                case (int)Direction.Bas:
                    e.Graphics.DrawImage(bas, Position.X, Position.Y, TAILLE_BLOC_X, TAILLE_BLOC_Y);
                    break;
                case (int)Direction.Haut:
                    e.Graphics.DrawImage(haut, Position.X, Position.Y, TAILLE_BLOC_X, TAILLE_BLOC_Y);
                    break;
            }
        }

        public void PivoterDroite()
        {
            switch (Orientation)
            {
                case (int)Direction.Gauche:
                    Orientation = (int)Direction.Haut;
                    break;
                case (int)Direction.Droite:
                    Orientation = (int)Direction.Bas;
                    break;
                case (int)Direction.Bas:
                    Orientation = (int)Direction.Gauche;
                    break;
                case (int)Direction.Haut:
                    Orientation = (int)Direction.Droite;
                    break;
            }
        }
        public void PivoterGauche()
        {
            switch (Orientation)
            {
                case (int)Direction.Gauche:
                    Orientation = (int)Direction.Bas;
                    break;
                case (int)Direction.Droite:
                    Orientation = (int)Direction.Haut;
                    break;
                case (int)Direction.Bas:
                    Orientation = (int)Direction.Droite;
                    break;
                case (int)Direction.Haut:
                    Orientation = (int)Direction.Gauche;
                    break;
            }
        }

        public void Avancer()
        {
            switch (Orientation)
            {
                case (int)Direction.Gauche:
                    this.Position = new PointF(Position.X - 30, Position.Y);
                    break;
                case (int)Direction.Droite:
                    this.Position = new PointF(Position.X + 30, Position.Y);
                    break;
                case (int)Direction.Bas:
                    this.Position = new PointF(Position.X, Position.Y + 30);
                    break;
                case (int)Direction.Haut:
                    this.Position = new PointF(Position.X, Position.Y - 30);
                    break;
            }
        }
    }
}
