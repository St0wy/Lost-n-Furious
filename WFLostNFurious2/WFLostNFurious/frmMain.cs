﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        string difficulteLaby = "Petit";
        PaintEventHandler dessinLabyrinthe;    //Variable d'affichage du labyrinthe
        Personnage p = new Personnage(new PointF(0, 0), "haut");
        PointF positionDepartpersonnage = new Point();
        string arriveDemande = "";
        Stopwatch swTempsEcoule = new Stopwatch();

        Bloc modele = new Arrivee();
        List<Bloc> labyrinthe = new List<Bloc>();
        bool inPlay = false;
        List<string> instruction = new List<string>();
        int compteur = 0;
        
        
        int[][] tabLabPetit = new int[][] {
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 },
            new int[] { 4, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 2, 4 },
            new int[] { 4, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }
        };

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
		
        /// <summary>
        /// Supprime tous les labels de la forme
        /// </summary>
        public void DeleteLabel()
        {
            foreach (Control lbl in Controls)
            {
                if (lbl is Label)
                {
                    Controls.Remove(lbl);
                }
            }
        }

        /// <summary>
        /// Dessine un labyrinthe en fonction d'un tableau mutli-dimentionnel
        /// </summary>
        /// <param name="tabLab">Schema du labyrinthe</param>
        public void CreateLabFromGrid(int[][] tabLab)
        {
            DeleteLabel();

            int compteurSortie = 0;
            int tailleCarre = 30;
            Point positionLaby = new Point(10, 10);

            for (int i = 0; i < tabLab.Length; i++)
            {
                int y = (i + 1) * tailleCarre + positionLaby.Y;
                for (int j = 0; j < tabLab[i].Length; j++)
                {
                    int x = (j + 1) * tailleCarre + positionLaby.X;
                    if (tabLab[i][j] == 1)
                    {
                        creationMur(x, y);
                    }
                    else if (tabLab[i][j] == 2)
                    {
                        string[] lettresSorties = { "A", "B", "C" };

                        creationArrivee(x, y);
                        Label lbl = new Label();
                        lbl.Location = new Point(x, y);
                        lbl.Text = lettresSorties[compteurSortie];
                        lbl.AutoSize = false;
                        lbl.Size = new Size(tailleCarre, tailleCarre);
                        lbl.Font = new Font("Arial", 15);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.BackColor = Color.Transparent;
                        compteurSortie++;
                        
                        Controls.Add(lbl);
                    }
                    else if (tabLab[i][j] == 3)
                    {
                        p.Position = new PointF(Convert.ToSingle(x) + 5f, Convert.ToSingle(y) + 5f);
                        positionDepartpersonnage = p.Position;
                    }
                    else if (tabLab[i][j] == 4)
                    {
                        creationBordure(x, y);
                    }
                }
            }
        }

        public void creationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            labyrinthe.Add(bordure);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bordure.Paint;
        }

        public void creationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            labyrinthe.Add(arrivee);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += arrivee.Paint;
        }

        public void creationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            labyrinthe.Add(bloc);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bloc.Paint;
        }

        /// <summary>
        /// Definis la nouvelle arrivee a ateindre
        /// </summary>
        public void nouvelleArrivee()
        {
            Random rnd = new Random();
            int valArrive = rnd.Next(3);
            int tmp = 0;

            //Regarde chaque bloc du labyrinthe
            foreach (Bloc m in labyrinthe)
            {
                if (m is Arrivee)
                {
                    if (valArrive == tmp) //Prend une arrivee aleatoirement et la met dans une variable pour s'en souvenir
                    {
                        modele = m;
                    }
                    tmp++;
                }
            }


            //Met l'arrivee de facon que ce soit de droite a gauche lors du nommage de chacune
            if (valArrive == 0)
            {
                lblArrivee.Text = "Arrivée: A";
                arriveDemande = "A";
            }
            else if (valArrive == 1)
            {
                lblArrivee.Text = "Arrivée: B";
                arriveDemande = "B";

            }
            else if (valArrive == 2)
            {
                lblArrivee.Text = "Arrivée: C";
                arriveDemande = "C";
            }

            swTempsEcoule.Restart();
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Tourner à droite");
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Tourner à gauche");
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void btnAvancer_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Avancer");
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            lblTempsEcoule.Text = Convert.ToString(swTempsEcoule.ElapsedMilliseconds / 1000);
        }

        public virtual void frmMain_Load(object sender, EventArgs e)
        {
            //Affiche le labyrinthe
            CreateLabFromGrid(tabLabPetit);
            this.Paint += dessinLabyrinthe;
            this.Paint += p.Paint;
            nouvelleArrivee();


            #region SolutionCMoyen
            //Sortie C en Moyen
            for (int i = 0; i < 5; i++)
            {
                btnAvancer_Click(sender, e);
            }
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnGauche_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnGauche_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnGauche_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnGauche_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnGauche_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnGauche_Click(sender, e);
            btnAvancer_Click(sender, e);
            btnDroite_Click(sender, e);
            btnAvancer_Click(sender, e); 
            #endregion

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach (string s in lbxInstruction.Items)
            {
                instruction.Add(s);
            }

            inPlay = true;
            lbxInstruction.Enabled = false;
            lbxInstruction.Focus();
            lbxInstruction.SelectedIndex = 0;
            tmrAvancer.Enabled = true;
            btnDroite.Enabled = false;
            btnGauche.Enabled = false;
            btnAvancer.Enabled = false;
            btnViderListe.Enabled = false;
            btnPlay.Enabled = false;
            btnReset.Enabled = true;
        }

        private void tmrAvancer_Tick(object sender, EventArgs e)
        {
            bool arrive = false;

            if (instruction.Count != 0)
            {
                string instrucAcruelle = instruction.ElementAt(compteur).ToString();
                bool collision = false;

                if (instrucAcruelle == "Avancer")
                {
                    p.Avancer();

                    foreach (Bloc b in labyrinthe)
                    {
                        //si il n'y a pas deja eu une collision, analise chaque bloc pour voir si on collisionne (empeche le clignottement)
                        if (!collision)
                        {
                            if (new PointF(p.Position.X - 5, p.Position.Y - 5) == b.Position)
                            {
                                string arriveePrecedente = lblArrivee.Text;
                                if(!(b is BlocInvisible))
                                {
                                    collision = true;
                                }

                                if (b.Position == modele.Position)
                                {
                                    tmrAvancer.Enabled = false;
                                    swTempsEcoule.Stop();

                                    MessageBox.Show("Bravo tu as réussi! Tu est beau.");

                                    btnReset_Click(sender, e);
                                    lbxInstruction.Enabled = true;
                                    inPlay = false;
                                    arrive = true;

                                    while (lblArrivee.Text == arriveePrecedente)
                                    {
                                        nouvelleArrivee();
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                collision = false;
                            }
                        }
                    }

                    if (collision && !arrive)
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
                        inPlay = false;

                        if (dr == DialogResult.Yes)
                        {
                            btnReset_Click(sender, e);
                            lbxInstruction.Enabled = true;
                        }
                        else
                        {
                            btnPlay.Enabled = false;
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

                if (compteur == lbxInstruction.Items.Count - 1)
                {
                    tmrAvancer.Enabled = false;
                }

                if (!arrive) 
                {
                   if (tmrAvancer.Enabled)
                   {
                        compteur++;
                   }
                }

                if (lbxInstruction.SelectedIndex < lbxInstruction.Items.Count - 1)
                {
                    lbxInstruction.SelectedIndex += 1;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Clear();
            instruction.Clear();
            inPlay = false;
            btnPlay.Enabled = false;
            lbxInstruction.Enabled = true;
            btnDroite.Enabled = true;
            btnGauche.Enabled = true;
            btnAvancer.Enabled = true;
            btnReset.Enabled = false;
            p.Position = positionDepartpersonnage;
            p.Orientation = "haut";
            compteur = 0;
            tmrAvancer.Enabled = false;
        }

        private void lbxInstruction_DoubleClick(object sender, EventArgs e)
        {
            if (!inPlay)
            {
                lbxInstruction.Items.RemoveAt(lbxInstruction.SelectedIndex);
            }
        }

        private void lbxInstruction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxInstruction.Items.Count == 0)
            {
                btnPlay.Enabled = false;
                btnViderListe.Enabled = false;
            }
            else if (!tmrAvancer.Enabled)
            {
                btnViderListe.Enabled = true;
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                //e.Cancel = true;
        }
		
        private void btnViderListe_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            lbxInstruction.Items.Clear();
            instruction.Clear();
            btnViderListe.Enabled = false;
        }
    }
}