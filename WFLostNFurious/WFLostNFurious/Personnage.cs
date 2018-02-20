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
        PointF depart;
        string mouv;

        public PointF Depart { get => depart; }


        public Personnage(PointF depart, string mouvement, string orient)
        {
            // Initialisation des variables d'instances
            this.depart = depart;
            this.mouv = orient;

            if (mouvement == "avancer")
            {
                switch (orient)
                {
                    case "gauche":
                        this.depart = new PointF(depart.X - 30, depart.Y);
                        break;
                    case "droite":
                        this.depart = new PointF(depart.X + 30, depart.Y);
                        break;
                    case "bas":
                        this.depart = new PointF(depart.X, depart.Y + 30);
                        break;
                    case "haut":
                        this.depart = new PointF(depart.X, depart.Y - 30);
                        break;
                }
            }
            else
            {
                this.depart = new PointF(depart.X, depart.Y);
            }

        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, depart.X, depart.Y, 20, 20);

            switch (mouv)
            {
                case "gauche":
                    e.Graphics.DrawLine(Pens.Black, depart.X + 10, depart.Y + 10, depart.X - 5, depart.Y + 10);
                    break;
                case "droite":
                    e.Graphics.DrawLine(Pens.Black, depart.X + 10, depart.Y + 10, depart.X + 25, depart.Y + 10);
                    break;
                case "bas":
                    e.Graphics.DrawLine(Pens.Black, depart.X + 10, depart.Y + 10, depart.X + 10, depart.Y + 25);
                    break;
                case "haut":
                    e.Graphics.DrawLine(Pens.Black, depart.X + 10, depart.Y + 10, depart.X + 10, depart.Y - 5);
                    break;
            }

        }

    }
}
