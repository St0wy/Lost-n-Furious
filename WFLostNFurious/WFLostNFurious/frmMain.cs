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

namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        enum Direction { Haut, Bas, Gauche, Droite };

        PaintEventHandler dessinLabyrinthe;    //Variable d'affichage du labyrinthe
        PointF positionDepartPersonnage;
        static Random rnd = new Random();
        Personnage personnageRaichu;
        Bloc arriveeDemandee;
        List<Bloc> lstLabyrinthe;
        List<string> lstInstruction;
        int compteurInstructionsEffectuees;
        int codeAAfficher;
        bool recommencer;
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

            positionDepartPersonnage = new Point();
            personnageRaichu = new Personnage(new PointF(0, 0), (int)Direction.Haut);
            arriveeDemandee = new Arrivee();
            lstLabyrinthe = new List<Bloc>();
            lstInstruction = new List<string>();
            compteurInstructionsEffectuees = 0;
            codeAAfficher = 0;
            recommencer = false;
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
                        positionDepartPersonnage = personnageRaichu.Position;
                    }
                    else if (matriceLabyrinthe[i][j] == Jeu.NUM_BORDURE)
                    {
                        CreationBordure(x, y);
                    }
                }
            }
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
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bordure.Paint;
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
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += arrivee.Paint;
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
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bloc.Paint;
        }

        /// <summary>
        /// Definit la nouvelle arrivee a atteindre
        /// </summary>
        public void NouvelleArrivee()
        {
            int valArrive = rnd.Next(Jeu.NOMBRE_SORTIES);
            int tmp = 0;

            //Regarde chaque bloc du labyrinthe
            foreach (Bloc m in lstLabyrinthe)
            {
                if (m is Arrivee)
                {
                    if (valArrive == tmp) //Prend une arrivee aleatoirement et la met dans une variable pour s'en souvenir
                    {
                        arriveeDemandee = m;
                        (arriveeDemandee as Arrivee).Activate();
                    }
                    tmp++;
                }
            }
        }

        /// <summary>
        /// Vide l'interface et met le code de victoire au milieu de l'ecran
        /// </summary>
        private void Gagner()
        {
            //Cache l'interface
            this.Paint -= dessinLabyrinthe;
            this.Paint -= personnageRaichu.Paint;
            Controls.Clear();

            //Affiche le code
            Label lblCode = new Label()
            {
                Location = new Point(Jeu.POSITION_CODE_VICTOIRE_X, Jeu.POSITION_CODE_VICTOIRE_Y),
                Text = $"Le code est :{Environment.NewLine}{codeAAfficher.ToString()}",
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
            lbxInstruction.Items.Add("Tourner à droite");
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void BtnGauche_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Tourner à gauche");
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void BtnAvancer_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Avancer");
            lbxInstruction.SelectedIndex = lbxInstruction.Items.Count - 1;
            btnPlay.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
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
                string instructionActuelle = lstInstruction.ElementAt(compteurInstructionsEffectuees).ToString();
                bool collision = false;

                if (instructionActuelle == "Avancer")
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

                                if (b.Position == arriveeDemandee.Position) //Verifie que le personnage est sur une arrivee
                                {
                                    //Action apres avoir gagne
                                    Gagner();

                                    BtnReset_Click(sender, e);
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

        private void Defaite()
        {
            //changer le dialog car raspberry
            DialogResult dr = MessageBox.Show("Réessayer ?", "Vous avez perdu", MessageBoxButtons.YesNo);
            Jeu.EstEnJeu = false;

            if (dr == DialogResult.Yes)
            {
                Restart();
                lbxInstruction.Enabled = true;
            }
            else
            {
                btnPlay.Enabled = false;
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
            compteurInstructionsEffectuees = 0;
            tmrAvancer.Enabled = false;

            //Raichu se remet au départ
            //personnageRaichu.Respawn(positionDepartpersonnage);
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

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {

        }

        //Si on veut empecher la fermeture de l'application
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
            CreateLabFromGrid(matriceLabyrinthe);
            this.Paint += dessinLabyrinthe;
            this.Paint += personnageRaichu.Paint;
            NouvelleArrivee();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

}
