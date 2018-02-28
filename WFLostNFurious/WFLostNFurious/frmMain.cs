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
        Personnage p = new Personnage(new PointF(255, 495), "haut");
        
        List<Bloc> labyrinthe = new List<Bloc>();
        List<int> instruction = new List<int>();

        

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void CreationLabyrithe()
        {
            #region Creation Bordure
            //Creation Bordure

            for (int x = 10, y = 10; x <= 520; x += 30)
            {
                creationBordure(x, y);
            }

            for (int x = 520, y = 10; y <= 520; y += 30)
            {
                creationBordure(x, y);
            }

            for (int x = 520, y = 520; x >= 10; x -= 30)
            {
                creationBordure(x, y);
            }

            for (int y = 520, x = 10; y >= 10; y -= 30)
            {
                creationBordure(x, y);
            }
            #endregion

            //Creation Arrivee
            creationArrivee(250, 40);
            creationArrivee(40, 430);
            creationArrivee(490, 430);

            creationMur(40, 40);

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

            for (int y = 190, x = 310; y <= 250; y += 30)
            {
                creationMur(x, y);
            }

            for (int y = 190, x = 370; y <= 280; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 400, y = 190; x <= 460; x += 30)
            {
                creationMur(x, y);
            }

            for (int y = 70, x = 490; y <= 400; y += 30)
            {
                creationMur(x, y);
            }

            for (int y = 460, x = 490; y <= 490; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 310, y = 490; x <= 460; x += 30)
            {
                creationMur(x, y);
            }

            for (int y = 430, x = 280; y <= 490; y += 30)
            {
                creationMur(x, y);
            }

            for (int y = 280, x = 430; y <= 340; y += 30)
            {
                creationMur(x, y);
            }

            for (int y = 310, x = 310; y <= 340; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 340, y = 340; x <= 400; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 280, y = 370; x <= 370; x += 30)
            {
                creationMur(x, y);
            }

            for (int y = 400, x = 340; y <= 430; y += 30)
            {
                creationMur(x, y);
            }

            for (int y = 400, x = 370; y <= 460; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 430, y = 400; x <= 460; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 400, y = 220; x <= 430; x += 30)
            {
                creationMur(x, y);
            }

            creationMur(280, 70);
            creationMur(460, 70);

            for (int x = 40, y = 70; y <= 420; y += 30)
            {
                creationMur(x, y);
            }

            creationMur(40, 460);

            for (int x = 40, y = 490; x <= 220; x += 30)
            {
                creationMur(x, y);
            }
            creationMur(430, 430);

            for (int x = 70, y = 460; x < 130; x += 30)
            {
                creationMur(x, y);
            }

            creationMur(70, 370);
            creationMur(100, 430);

            for (int x = 130, y = 460; y >= 340; y -= 30)
            {
                creationMur(x, y);
            }

            for (int x = 100, y = 310; x < 280; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 190, y = 460; y >= 430; y -= 30)
            {
                creationMur(x, y);
            }

            for (int x = 220, y = 460; y >= 430; y -= 30)
            {
                creationMur(x, y);
            }

            creationMur(220, 340);

            for (int x = 190, y = 370; x <= 220; x += 30)
            {
                creationMur(x, y);
            }

            creationMur(130, 280);

            for (int x = 70, y = 220; y <= 250; y += 30)
            {
                creationMur(x, y);
            }

            for (int x = 100, y = 160; y <= 220; y += 30)
            {
                creationMur(x, y);
            }

            creationMur(130, 220);

            for (int x = 190, y = 250; x <= 250; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 190, y = 190; x <= 280; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 160, y = 160; x <= 190; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 190, y = 130; x <= 250; x += 30)
            {
                creationMur(x, y);
            }

            creationMur(220, 100);

            for (int x = 100, y = 70; x <= 160; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 70, y = 40; x <= 220; x += 30)
            {
                creationMur(x, y);
            }

            for (int x = 100, y = 100; x <= 130; x += 30)
            {
                creationMur(x, y);
            }

            #endregion
        }
        PaintEventHandler image;    //Variable d'affichage du labyrinthe

        public void creationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            labyrinthe.Add(bordure);
            //Ajoute l'affichage de l'objet dans une variable d'image
            image += bordure.Paint;
            //this.Paint += bordure.Paint;
        }

        public void creationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            labyrinthe.Add(arrivee);
            //Ajoute l'affichage de l'objet dans une variable d'image
            image += arrivee.Paint;
            //this.Paint += arrivee.Paint;
        }

        public void creationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            labyrinthe.Add(bloc);
            //Ajoute l'affichage de l'objet dans une variable d'image
            image += bloc.Paint;
            //this.Paint += bloc.Paint;
        }


        private void btnDroite_Click(object sender, EventArgs e)
        {
            p.PivoterDroite();
             
            lbxInstruction.Items.Add("Tourner à droite");

            instruction.Add(3);
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            p.PivoterGauche();

            lbxInstruction.Items.Add("Touner à gauche");

            instruction.Add(2);
        }

        private void btnAvancer_Click(object sender, EventArgs e)
        {
            p.Avancer();

            bool collision = false;

            //Analise tous les blocs
            foreach (Bloc b in labyrinthe)
            {
                //si il n'y a pas deja eu une collision, analise chaque bloc pour voir si on collision (empeche le clignottement)
                if (!collision)
                {
                    if (new PointF(p.Position.X - 5, p.Position.Y - 5) == b.Position)
                    {
                        collision = true;
                    }
                    else
                    {
                        collision = false;
                    }
                }
            }
            if (collision)
            {
                this.Text = "Collision";
            }
            else
            {
                this.Text = "Non";
            }

            lbxInstruction.Items.Add("Avancer");

            instruction.Add(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Affiche le personnage et le labyrinthe
            this.Paint += p.Paint;
            CreationLabyrithe();
            this.Paint += image;
        }
    }
}
