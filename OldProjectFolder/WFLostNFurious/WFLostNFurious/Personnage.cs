﻿using System;
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
        private PointF position;
        private string orientation;

        public PointF Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public string Orientation
        {
            get
            {
                return orientation;
            }
            set
            {
                orientation = value;
            }
        }

        public Personnage(PointF pos , string orient)
        {
            // Initialisation des variables d'instances
            this.position = pos;
            this.orientation = orient;

            this.position = new PointF(pos.X, pos.Y);
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawEllipse(Pens.Black, position.X, position.Y, 20, 20);
            Image droite = Properties.Resources.raichuDroite;
            Image gauche = Properties.Resources.raichuGauche;
            Image haut = Properties.Resources.raichuHaut;
            Image bas = Properties.Resources.raichuBas;
           

            switch (orientation)
            {
                case "gauche":
                    e.Graphics.DrawImage(gauche, position.X - 10, position.Y - 10);
                    //e.Graphics.DrawLine(Pens.Black, position.X + 10, position.Y + 10, position.X - 5, position.Y + 10);
                    break;
                case "droite":
                    e.Graphics.DrawImage(droite, position.X - 10, position.Y - 10);
                    //e.Graphics.DrawLine(Pens.Black, position.X + 10, position.Y + 10, position.X + 25, position.Y + 10);
                    break;
                case "bas":
                    e.Graphics.DrawImage(bas, position.X - 10, position.Y - 10);
                    //e.Graphics.DrawLine(Pens.Black, position.X + 10, position.Y + 10, position.X + 10, position.Y + 25);
                    break;
                case "haut":
                    e.Graphics.DrawImage(haut, position.X - 10, position.Y - 10);
                    //e.Graphics.DrawLine(Pens.Black, position.X + 10, position.Y + 10, position.X + 10, position.Y - 5);
                    break;
            }

        }

        public void PivoterDroite()
        {
            switch (orientation)
            {
                case "gauche":
                    orientation = "haut";
                    break;
                case "droite":
                    orientation = "bas";
                    break;
                case "bas":
                    orientation = "gauche";
                    break;
                case "haut":
                    orientation = "droite";
                    break;
            }
        }
        public void PivoterGauche()
        {
            switch (orientation)
            {
                case "gauche":
                    orientation = "bas";
                    break;
                case "droite":
                    orientation = "haut";
                    break;
                case "bas":
                    orientation = "droite";
                    break;
                case "haut":
                    orientation = "gauche";
                    break;
            }
        }

        public void Avancer()
        {
            switch (orientation)
            {
                case "gauche":
                    this.position = new PointF(position.X - 30, position.Y);
                    break;
                case "droite":
                    this.position = new PointF(position.X + 30, position.Y);
                    break;
                case "bas":
                    this.position = new PointF(position.X, position.Y + 30);
                    break;
                case "haut":
                    this.position = new PointF(position.X, position.Y - 30);
                    break;
            }
        }

    }
}
