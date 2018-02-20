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
            CreationLabyrithe();
            DoubleBuffered = true;
        }

        public void CreationLabyrithe()
        {
            #region Creation Bordure
            //Creation Bordure
            int x = 10, y = 10;

            for (int i = 0; i < 17; i++)
            {
                creationBordure(x, y);
                x += 30;
            }



            for (int i = 0; i < 17; i++)
            {
                creationBordure(x, y);
                y += 30;
            }

            for (int i = 0; i < 17; i++)
            {
                creationBordure(x, y);
                x -= 30;
            }

            for (int i = 0; i < 17; i++)
            {
                creationBordure(x, y);
                y -= 30;
            }
            #endregion

            //Creation Arrivee
            creationArrivee(250, 40);
            creationArrivee(40, 430);
            Invalidate();
            //Bloc mur = new Bloc(10, 50);
            //mur.Paint(sender, e);
            //
            //Bloc mur2 = new Bloc(10, 30);
            //mur2.Paint(sender, e);
            //
            //Arrivee arrivee1 = new Arrivee(70, 70);
            //arrivee1.Paint(sender, e);
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
    }
}
