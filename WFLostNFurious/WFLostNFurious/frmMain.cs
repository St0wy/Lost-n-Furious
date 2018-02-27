using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        Personnage p = new Personnage(new PointF(255, 45), "haut");
        List<Bloc> labyrinthe = new List<Bloc>();

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            CreationLabyrithe();
        }

        public void CreationLabyrithe()
        {
            #region Creation Bordure
            //Creation Bordure

            for (int x = 10, y = 10; x < 520; x += 30)
            {
                creationBordure(x, y);
            }

            for (int y = 10, x = 520; y < 490; y += 30)
            {
                creationBordure(x, y);
            }

            for (int x = 520, y = 460; x >= 10; x -= 30)
            {
                creationBordure(x, y);
            }

            for (int y = 430, x = 10; y >= 10; y -= 30)
            {
                creationBordure(x, y);
            }
            #endregion


            //Creation Arrivee
            creationArrivee(250, 40);
            creationArrivee(40, 430);
            creationArrivee(490, 430);


            #region Creation Mur
            for (int x = 280, y = 40; x <= 490; x += 30)
            {
                creationMur(x, y);
            }

            for (int y = 70, x = 340; y <= 100; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 310, y = 130; x <= 340; x += 30)
            {
                creationMur(x, y);
            }

            for (int y = 70, x = 400; y <= 100; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 400, y = 130; x <= 430; x += 30)
            {
                creationMur(x, y);
            }

            for (int y = 190, x = 310; y <= 250; x += 30)
            {
                creationMur(x, y);
            }

            creationMur(280, 70);
            creationMur(460, 70);
            #endregion


        }

        public void creationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            labyrinthe.Add(bordure);
            this.Paint += bordure.Paint;
        }

        public void creationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            labyrinthe.Add(arrivee);
            this.Paint += p.Paint;
            this.Paint += arrivee.Paint;
        }

        public void creationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            labyrinthe.Add(bloc);
            this.Paint += bloc.Paint;
        }


        private void btnDroite_Click(object sender, EventArgs e)
        {
            p.PivoterDroite();
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            p.PivoterGauche();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnAvancer_Click(object sender, EventArgs e)
        {
            p.Avancer();
        }
    }
}
