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
        //Valeurs pour la matrice qui genere le labyrinthe
        

        enum Direction { Haut, Bas, Gauche, Droite };

        PaintEventHandler dessinLabyrinthe;    //Variable d'affichage du labyrinthe
        Personnage personnageRaichu = new Personnage(new PointF(0, 0), (int)Direction.Haut);
        PointF positionDepartpersonnage = new Point();
        Random rnd = new Random();

        Bloc arriveeDemandee = new Arrivee();
        List<Bloc> lstLabyrinthe = new List<Bloc>();
        bool enJeu = false;
        List<string> lstInstruction = new List<string>();
        int compteurInstructionsEffectuees = 0;


        int[][] matriceLabyrinthe = new int[][] {
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
        };  //Matrice du labyrinthe

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
        /// <param name="matriceLabyrinthe">Schema du labyrinthe</param>
        public void CreateLabFromGrid(int[][] matriceLabyrinthe)
        {
            DeleteLabel();
            int compteurSortie = 0;

            Point positionLaby = new Point(GameConstant.POSITION_LABYRINTHE_X, GameConstant.POSITION_LABYRINTHE_Y);

            for (int i = 0; i < matriceLabyrinthe.Length; i++)
            {
                int y = (i + 1) * GameConstant.TAILLE_BLOC_Y + positionLaby.Y;
                for (int j = 0; j < matriceLabyrinthe[i].Length; j++)
                {
                    int x = (j + 1) * GameConstant.TAILLE_BLOC_X + positionLaby.X;
                    if (matriceLabyrinthe[i][j] == GameConstant.NUM_MUR)
                    {
                        CreationMur(x, y);
                    }
                    else if (matriceLabyrinthe[i][j] == GameConstant.NUM_ARRIVEE)
                    {
                        string[] lettresSorties = { "A", "B", "C" };

                        CreationArrivee(x, y);
                        Label lbl = new Label();
                        lbl.Location = new Point(x, y);
                        lbl.Text = lettresSorties[compteurSortie];
                        lbl.AutoSize = false;
                        lbl.Size = new Size(GameConstant.TAILLE_BLOC_X, GameConstant.TAILLE_BLOC_Y);
                        lbl.Font = new Font("Arial", 15);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.BackColor = Color.Transparent;
                        compteurSortie++;

                        Controls.Add(lbl);
                    }
                    else if (matriceLabyrinthe[i][j] == GameConstant.NUM_PERSONNAGE)
                    {
                        personnageRaichu.Position = new PointF(Convert.ToSingle(x), Convert.ToSingle(y));
                        positionDepartpersonnage = personnageRaichu.Position;
                    }
                    else if (matriceLabyrinthe[i][j] == GameConstant.NUM_BORDURE)
                    {
                        CreationBordure(x, y);
                    }
                }
            }
        }

        public void CreationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            lstLabyrinthe.Add(bordure);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bordure.Paint;
        }

        public void CreationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            lstLabyrinthe.Add(arrivee);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += arrivee.Paint;
        }

        public void CreationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            lstLabyrinthe.Add(bloc);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bloc.Paint;
        }

        /// <summary>
        /// Definis la nouvelle arrivee a ateindre
        /// </summary>
        public void NouvelleArrivee()
        {

            int valArrive = rnd.Next(GameConstant.NOMBRE_SORTIES);
            int tmp = 0;

            //Regarde chaque bloc du labyrinthe
            foreach (Bloc m in lstLabyrinthe)
            {
                if (m is Arrivee)
                {
                    if (valArrive == tmp) //Prend une arrivee aleatoirement et la met dans une variable pour s'en souvenir
                    {
                        arriveeDemandee = m;
                    }
                    tmp++;
                }
            }

            //Met l'arrivee de facon que ce soit de droite a gauche lors du nommage de chacune
            if (valArrive == 0)
            {
                lblArrivee.Text = "Arrivée: A";
            }
            else if (valArrive == 1)
            {
                lblArrivee.Text = "Arrivée: B";
            }
            else if (valArrive == 2)
            {
                lblArrivee.Text = "Arrivée: C";
            }

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
        }

        private void CommencerPartie()
        {
            //Affiche les controles
            pnlInstructions.Visible = true;
            //Affiche le labyrinthe
            CreateLabFromGrid(matriceLabyrinthe);
            this.Paint += dessinLabyrinthe;
            this.Paint += personnageRaichu.Paint;
            NouvelleArrivee();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach (string s in lbxInstruction.Items)
            {
                lstInstruction.Add(s);
            }

            enJeu = true;
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

        private void Gagner()
        {
            this.Controls.Clear();
            this.Paint -= dessinLabyrinthe;
            this.Paint -= personnageRaichu.Paint;

            Label lbl = new Label();
            lbl.Location = new Point(GameConstant.POSITION_CODE_VICTOIRE_X, GameConstant.POSITION_CODE_VICTOIRE_Y);
            lbl.Text = "Le code est :" + Environment.NewLine + rnd.Next(GameConstant.CODE_MIN, GameConstant.CODE_MAX + 1).ToString();
            lbl.AutoSize = false;
            lbl.Size = new Size(this.Width, this.Height);
            lbl.Font = new Font("Arial", 50);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BackColor = Color.Transparent;
            this.Controls.Add(lbl);

        }

        private void tmrAvancer_Tick(object sender, EventArgs e)
        {
            bool arrive = false;

            if (lstInstruction.Count != 0)
            {
                string instructionActuelle = lstInstruction.ElementAt(compteurInstructionsEffectuees).ToString();
                bool collision = false;

                if (instructionActuelle == "Avancer")
                {
                    personnageRaichu.Avancer();

                    foreach (Bloc b in lstLabyrinthe)
                    {
                        //si il n'y a pas deja eu une collision, analise chaque bloc pour voir si on collisionne (empeche le clignottement)
                        if (!collision)
                        {
                            if (personnageRaichu.Position == b.Position)    //Verifie s'il y a une collision
                            {
                                string arriveePrecedente = lblArrivee.Text;
                                collision = true;
                                tmrAvancer.Enabled = false;

                                if (b.Position == arriveeDemandee.Position) //Verifie qui le personnage est sur une arrivee
                                {
                                    //Action apres avoir gagne
                                    Gagner();

                                    btnReset_Click(sender, e);
                                    lbxInstruction.Enabled = true;
                                    enJeu = false;
                                    arrive = true;

                                    while (lblArrivee.Text == arriveePrecedente)
                                    {
                                        NouvelleArrivee();
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

                        /**switch (personnageRaichu.Orientation)
                        *{
                        *    case (int)Direction.Gauche:
                        *        personnageRaichu.Orientation = (int)Direction.Droite;
                        *        personnageRaichu.Avancer();
                        *        personnageRaichu.Orientation = (int)Direction.Gauche;
                        *        break;
                        *    case (int)Direction.Droite:
                        *        personnageRaichu.Orientation = (int)Direction.Gauche;
                        *        personnageRaichu.Avancer();
                        *        personnageRaichu.Orientation = (int)Direction.Droite;
                        *        break;
                        *    case (int)Direction.Bas:
                        *        personnageRaichu.Orientation = (int)Direction.Haut;
                        *        personnageRaichu.Avancer();
                        *        personnageRaichu.Orientation = (int)Direction.Bas;
                        *        break;
                        *    case (int)Direction.Haut:
                        *        personnageRaichu.Orientation = (int)Direction.Bas;
                        *        personnageRaichu.Avancer();
                        *        personnageRaichu.Orientation = (int)Direction.Haut;
                        *        break;
                        *}
                        *tmrAvancer.Enabled = false;
                        */

                        DialogResult dr = MessageBox.Show("Réessayer ?", "Vous avez perdu", MessageBoxButtons.YesNo);
                        enJeu = false;

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
                else if (instructionActuelle == "Tourner à droite")
                {
                    personnageRaichu.PivoterDroite();
                }
                else if (instructionActuelle == "Tourner à gauche")
                {
                    personnageRaichu.PivoterGauche();
                }

                if (compteurInstructionsEffectuees == lbxInstruction.Items.Count - 1)
                {
                    tmrAvancer.Enabled = false;
                }

                if (!arrive)
                {
                    if (tmrAvancer.Enabled)
                    {
                        compteurInstructionsEffectuees++;
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
            lstInstruction.Clear();
            enJeu = false;
            btnPlay.Enabled = false;
            lbxInstruction.Enabled = true;
            btnDroite.Enabled = true;
            btnGauche.Enabled = true;
            btnAvancer.Enabled = true;
            btnReset.Enabled = false;
            personnageRaichu.Position = positionDepartpersonnage;
            personnageRaichu.Orientation = (int)Direction.Haut;
            compteurInstructionsEffectuees = 0;
            tmrAvancer.Enabled = false;
        }

        private void lbxInstruction_DoubleClick(object sender, EventArgs e)
        {
            if (!enJeu)
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
            lstInstruction.Clear();
            btnViderListe.Enabled = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            CommencerPartie();
        }
    }
}
