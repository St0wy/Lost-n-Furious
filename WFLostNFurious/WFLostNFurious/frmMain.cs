﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//TO DO:
//collision arrivée à traiter
//créer bouton pour enlever la dernière instruction
//vérifier la gestion de l'activation et la desactivation des boutons
//highlighter instruction en cours
namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        Personnage p = new Personnage(new PointF(255, 495), "haut");
        
        List<Bloc> labyrinthe = new List<Bloc>();
        List<int> instruction = new List<int>();
        int compteur = 0;

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
             
            lbxInstruction.Items.Add("Tourner à droite");

            instruction.Add(3);
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {

            lbxInstruction.Items.Add("Tourner à gauche");

            instruction.Add(2);
        }

        private void btnAvancer_Click(object sender, EventArgs e)
        {
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tmrAvancer.Enabled = true;
            btnDroite.Enabled = false;
            btnGauche.Enabled = false;
            btnAvancer.Enabled = false;
            btnPlay.Enabled = false;
        }

        private void tmrAvancer_Tick(object sender, EventArgs e)
        {
            string instrucAcruelle = lbxInstruction.Items[compteur].ToString();
            bool collision = false;

            
            if (instrucAcruelle == "Avancer")
            {
                p.Avancer();

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
                   
                    switch (p.Orientation)
                    {
                        case "gauche":
                            p.Orientation = "droite";
                            p.Avancer();
                            p.Orientation = "gauche";
                            break;
                        case "droite":
                            p.Orientation = "gauche";
                            p.Avancer();
                            p.Orientation = "droite";
                            break;
                        case "bas":
                            p.Orientation = "haut";
                            p.Avancer();
                            p.Orientation = "bas";
                            break;
                        case "haut":
                            p.Orientation = "bas";
                            p.Avancer();
                            p.Orientation = "haut";
                            break;
                    }
                    tmrAvancer.Enabled = false;

                    DialogResult dr = MessageBox.Show("Réessayer ?", "Vous avez perdu", MessageBoxButtons.YesNo);
                    
                    if (dr == DialogResult.Yes)
                    {
                        btnReset_Click(sender, e);
                    }
                    else
                    {
                        this.Close();
                        
                    }
                }
            }
            else
            {
                if (instrucAcruelle == "Tourner à droite")
                {
                    p.PivoterDroite();

                }
                else
                {
                    if (instrucAcruelle == "Tourner à gauche")
                    {
                        p.PivoterGauche();
                    }
                }
            }
            if (compteur == lbxInstruction.Items.Count-1)
            {
                tmrAvancer.Enabled = false;
            }
            compteur++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Clear();
            btnDroite.Enabled = true;
            btnGauche.Enabled = true;
            btnAvancer.Enabled = true;
            btnPlay.Enabled = true;
            p.Position = new PointF(255, 495);
            p.Orientation = "haut";
            compteur = 0;
        }
    }
}
