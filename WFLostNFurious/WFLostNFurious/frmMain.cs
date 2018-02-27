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
        List<Bloc> labyrinthe = new List<Bloc>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Personnage p = new Personnage(new PointF(200, 100), "avancer", "bas");
            this.Paint += p.Paint;
            CreationLabyrithe();
            DoubleBuffered = true;
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
            for (int x = 40, y = 40; x <= 240; x += 30)
            {
                creationMur(x, y);
            }
            for (int x = 40, y = 70; y < 40; y++)
            {

            }
            #endregion


            Invalidate();
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
            this.Paint += arrivee.Paint;
        }

        public void creationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            labyrinthe.Add(bloc);
            this.Paint += bloc.Paint;
        }
    }
}
