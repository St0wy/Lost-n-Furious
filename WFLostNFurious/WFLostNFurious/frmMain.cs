using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        //Propriete
        enum Direction { Haut, Bas, Gauche, Droite };

        string codeAAfficher;
        Personnage personnageRaichu;
        List<Bloc> lstLabyrinthe;
        List<string> lstInstruction;

        //Constructeur
        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;

            personnageRaichu = new Personnage(new PointF(0, 0), (int)Direction.Haut);
            lstLabyrinthe = new List<Bloc>();
            lstInstruction = new List<string>();
            codeAAfficher = Jeu.RecevoirCode("http://127.0.0.1/testCSharp/testcSharp.php");
        }

        

        /// <summary>
        /// Dessine un labyrinthe en fonction d'un tableau mutli-dimentionnel
        /// </summary>
        /// <param name="matriceLabyrinthe">Schema du labyrinthe</param>
        public void CreateLabFromGrid(int[][] matriceLabyrinthe)
        {
            int compteurSortie = 0;

            Point positionLaby = new Point(Jeu.POSITION_LABYRINTHE_X, Jeu.POSITION_LABYRINTHE_Y);

            for (int i = 0; i < matriceLabyrinthe.Length; i++)
            {
                int y = (i + 1) * Jeu.TAILLE_BLOC_Y + positionLaby.Y;
                for (int j = 0; j < matriceLabyrinthe[i].Length; j++)
                {
                    int x = (j + 1) * Jeu.TAILLE_BLOC_X + positionLaby.X;
                    if (matriceLabyrinthe[i][j] == Jeu.NUM_MUR)
                    {
                        CreationMur(x, y);
                    }
                    else if (matriceLabyrinthe[i][j] == Jeu.NUM_ARRIVEE)
                    {
                        string[] lettresSorties = { "A", "B", "C" };

                        CreationArrivee(x, y);
                        Label lbl = new Label()
                        {
                            Location = new Point(x, y),
                            Text = lettresSorties[compteurSortie],
                            AutoSize = false,
                            Size = new Size(Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y),
                            Font = new Font("Arial", 15),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.Transparent,
                            ForeColor = Color.Black,
                        };
                        compteurSortie++;

                        Controls.Add(lbl);
                    }
                    else if (matriceLabyrinthe[i][j] == Jeu.NUM_PERSONNAGE)
                    {
                        personnageRaichu.Position = new PointF(Convert.ToSingle(x), Convert.ToSingle(y));
                        personnageRaichu.PositionDepart = personnageRaichu.Position;
                    }
                    else if (matriceLabyrinthe[i][j] == Jeu.NUM_BORDURE)
                    {
                        CreationBordure(x, y);
                    }
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Cree une bordure
        /// </summary>
        /// <param name="x">Position X de la bordure</param>
        /// <param name="y">Position Y de la bordure</param>
        public void CreationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            lstLabyrinthe.Add(bordure);
        }

        /// <summary>
        /// Cree une arrivee
        /// </summary>
        /// <param name="x">Position X de la bordure</param>
        /// <param name="y">Position Y de la bordure</param>
        public void CreationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            lstLabyrinthe.Add(arrivee);
        }

        /// <summary>
        /// Cree un mur
        /// </summary>
        /// <param name="x">Position X de la bordure</param>
        /// <param name="y">Position Y de la bordure</param>
        public void CreationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            lstLabyrinthe.Add(bloc);
        }

        

        /// <summary>
        /// Vide l'interface et met le code de victoire au milieu de l'ecran
        /// </summary>
        private void Gagner()
        {
            //Cache l'interface
            Controls.Clear();

            //Affiche le code
            Label lblCode = new Label()
            {
                Location = new Point(Jeu.POSITION_CODE_VICTOIRE_X, Jeu.POSITION_CODE_VICTOIRE_Y),
                Text = $"Le code est :{Environment.NewLine}{codeAAfficher}",
                AutoSize = false,
                Size = new Size(this.Width, this.Height),
                Font = new Font("Arial", 75),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            this.Controls.Add(lblCode);
        }
        
        private void BtnDroite_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add(Jeu.PIVOTER_DROITE);
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void BtnGauche_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add(Jeu.PIVOTER_GAUCHE);
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void BtnAvancer_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add(Jeu.AVANCER);
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            foreach (string s in lbxInstruction.Items)
            {
                lstInstruction.Add(s);
            }

            Jeu.EstEnJeu = true;
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

        private void TmrAvancer_Tick(object sender, EventArgs e)
        {
            bool arrive = false;

            if (lstInstruction.Count != 0)
            {
                string instructionActuelle = lstInstruction.ElementAt(Jeu.CompteurInstructionsEffectuees).ToString();
                bool collision = false;

                if (instructionActuelle == Jeu.AVANCER)
                {
                    personnageRaichu.Avancer();

                    foreach (Bloc b in lstLabyrinthe)
                    {
                        //si il n'y a pas deja eu une collision, analyse chaque bloc pour voir si on collisionne (empeche le clignottement)
                        if (!collision)
                        {
                            if (personnageRaichu.Position == b.Position)    //Verifie s'il y a une collision
                            {
                                collision = true;
                                tmrAvancer.Enabled = false;

                                if (b.Position == Jeu.ArriveeDemandee.Position) //Verifie que le personnage est sur une arrivee
                                {
                                    //Action apres avoir gagne
                                    Gagner();

                                    Restart();
                                    lbxInstruction.Enabled = true;
                                    Jeu.EstEnJeu = false;
                                    arrive = true;

                                    break;
                                }
                            }
                            else
                            {
                                collision = false;
                            }
                        }
                    }

                    //TODO: faire quand on bouge pas perdu : quand il arrive a derniere instruction et que il bouge plus : perdu
                    if (collision && !arrive)
                    {
                        Defaite();
                    }

                }
                else if (instructionActuelle == Jeu.PIVOTER_DROITE)
                {
                    personnageRaichu.PivoterDroite();
                }
                else if (instructionActuelle == Jeu.PIVOTER_GAUCHE)
                {
                    personnageRaichu.PivoterGauche();
                }

                if (Jeu.CompteurInstructionsEffectuees == lbxInstruction.Items.Count - 1)
                {
                    tmrAvancer.Enabled = false;
                    //si une fois arrivé à la fin des instructions, le personnage n'est pas arrivé
                    if (!arrive)
                    {
                        Defaite();
                    }
                }

                if (!arrive)
                {
                    if (tmrAvancer.Enabled)
                    {
                        Jeu.CompteurInstructionsEffectuees++;
                    }
                }

                if (lbxInstruction.SelectedIndex < lbxInstruction.Items.Count - 1)
                {
                    lbxInstruction.SelectedIndex += 1;
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Dit eu jeu que la partie est finie et affiche une fenêtre + change le fond en rouge pour prévenir l'utilisateur
        /// </summary>
        private void Defaite()
        {
            this.BackColor = Color.Red;

            DialogResult dr = MessageBox.Show("Vous avez perdu", "Réessayez", MessageBoxButtons.OK);
            Jeu.EstEnJeu = false;

            if (dr == DialogResult.OK)
            {
                this.BackColor = SystemColors.Control;
                Restart();
                lbxInstruction.Enabled = true;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Restart();
        }

        /// <summary>
        /// Recommence la partie, la liste se vide et le personnage se remet au debut
        /// </summary>
        private void Restart()
        {
            //Ergonomie des boutons
            lbxInstruction.Items.Clear();
            lstInstruction.Clear();
            Jeu.EstEnJeu = false;
            btnPlay.Enabled = false;
            lbxInstruction.Enabled = true;
            btnDroite.Enabled = true;
            btnGauche.Enabled = true;
            btnAvancer.Enabled = true;
            btnReset.Enabled = false;
            Jeu.CompteurInstructionsEffectuees = 0;
            tmrAvancer.Enabled = false;

            //Raichu se remet au départ
            personnageRaichu.Respawn();
            
        }

        private void LbxInstruction_DoubleClick(object sender, EventArgs e)
        {
            if (!Jeu.EstEnJeu)
            {
                lbxInstruction.Items.RemoveAt(lbxInstruction.SelectedIndex);
            }
        }

        private void LbxInstruction_SelectedIndexChanged(object sender, EventArgs e)
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


        /// <summary>
        /// Si on veut empecher la fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

        private void BtnViderListe_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            lbxInstruction.Items.Clear();
            lstInstruction.Clear();
            btnViderListe.Enabled = false;
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;

            //Affiche les controles
            pnlCommandes.Visible = true;
            pnlInstructions.Visible = true;
            //Affiche le labyrinthe
            CreateLabFromGrid(Jeu.MatriceLabyrinthe);
            Jeu.NouvelleArrivee(lstLabyrinthe);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Bloc bloc in lstLabyrinthe)
            {
                if(bloc is Arrivee)
                {
                    if((bloc as Arrivee).IsActive)
                    {
                        e.Graphics.FillRectangle(Brushes.Red, bloc.X, bloc.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.Black, bloc.X, bloc.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                    }
                }
                else if(bloc is Bordure)
                {
                    e.Graphics.FillRectangle(Brushes.LightBlue, bloc.X, bloc.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Black, bloc.X, bloc.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                }
            }

            Image droite = Properties.Resources.raichuDroite;
            Image gauche = Properties.Resources.raichuGauche;
            Image haut = Properties.Resources.raichuHaut;
            Image bas = Properties.Resources.raichuBas;

            switch (personnageRaichu.Orientation)
            {
                case (int)Direction.Gauche:
                    e.Graphics.DrawImage(gauche, personnageRaichu.Position.X, personnageRaichu.Position.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                    break;
                case (int)Direction.Droite:
                    e.Graphics.DrawImage(droite, personnageRaichu.Position.X, personnageRaichu.Position.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                    break;
                case (int)Direction.Bas:
                    e.Graphics.DrawImage(bas, personnageRaichu.Position.X, personnageRaichu.Position.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                    break;
                case (int)Direction.Haut:
                    e.Graphics.DrawImage(haut, personnageRaichu.Position.X, personnageRaichu.Position.Y, Jeu.TAILLE_BLOC_X, Jeu.TAILLE_BLOC_Y);
                    break;
            }
        }
    }

}
