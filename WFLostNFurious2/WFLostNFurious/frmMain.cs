using System;
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
        const int TAILLECARRE = 30;
        //Valeurs pour la matrice qui genere le labyrinthe
        const int NUM_MUR = 1;
        const int NUM_ARRIVEE = 2;
        const int NUM_PERSONNAGE = 3;
        const int NUM_BORDURE = 4;

        const int POSITION_LABYRINTHE_X = 10;
        const int POSITION_LABYRINTHE_Y = 10;
        const int NOMBRE_SORTIES = 3;

        const int DUREE_UNE_SECONDE_EN_MS = 1000;

        const int POSITION_CODE_VICTOIRE_X = 0;
        const int POSITION_CODE_VICTOIRE_Y = -10;

        const int CODE_MIN = 10;
        const int CODE_MAX = 50;

        enum Direction { Haut, Bas, Gauche, Droite };

        PaintEventHandler dessinLabyrinthe;    //Variable d'affichage du labyrinthe
        Personnage raichu = new Personnage(new PointF(0, 0), (int)Direction.Haut);
        PointF positionDepartpersonnage = new Point();
        Stopwatch swTempsEcoule = new Stopwatch();
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
            
            Point positionLaby = new Point(POSITION_LABYRINTHE_X, POSITION_LABYRINTHE_Y);

            for (int i = 0; i < matriceLabyrinthe.Length; i++)
            {
                int y = (i + 1) * TAILLECARRE + positionLaby.Y;
                for (int j = 0; j < matriceLabyrinthe[i].Length; j++)
                {
                    int x = (j + 1) * TAILLECARRE + positionLaby.X;
                    if (matriceLabyrinthe[i][j] == NUM_MUR)
                    {
                        creationMur(x, y);
                    }
                    else if (matriceLabyrinthe[i][j] == NUM_ARRIVEE)
                    {
                        string[] lettresSorties = { "A", "B", "C" };

                        creationArrivee(x, y);
                        Label lbl = new Label();
                        lbl.Location = new Point(x, y);
                        lbl.Text = lettresSorties[compteurSortie];
                        lbl.AutoSize = false;
                        lbl.Size = new Size(TAILLECARRE, TAILLECARRE);
                        lbl.Font = new Font("Arial", 15);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.BackColor = Color.Transparent;
                        compteurSortie++;
                        
                        Controls.Add(lbl);
                    }
                    else if (matriceLabyrinthe[i][j] == NUM_PERSONNAGE)
                    {
                        raichu.Position = new PointF(Convert.ToSingle(x), Convert.ToSingle(y));
                        positionDepartpersonnage = raichu.Position;
                    }
                    else if (matriceLabyrinthe[i][j] == NUM_BORDURE)
                    {
                        creationBordure(x, y);
                    }
                }
            }
        }

        public void creationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            lstLabyrinthe.Add(bordure);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bordure.Paint;
        }

        public void creationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            lstLabyrinthe.Add(arrivee);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += arrivee.Paint;
        }

        public void creationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            lstLabyrinthe.Add(bloc);
            //Ajoute l'affichage de l'objet dans une variable d'image
            dessinLabyrinthe += bloc.Paint;
        }

        /// <summary>
        /// Definis la nouvelle arrivee a ateindre
        /// </summary>
        public void nouvelleArrivee()
        {
            
            int valArrive = rnd.Next(NOMBRE_SORTIES);
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
            lblTempsEcoule.Text = Convert.ToString(swTempsEcoule.ElapsedMilliseconds / DUREE_UNE_SECONDE_EN_MS);
        }

        public virtual void frmMain_Load(object sender, EventArgs e)
        {
            //Affiche le labyrinthe
            CreateLabFromGrid(matriceLabyrinthe);
            this.Paint += dessinLabyrinthe;
            this.Paint += raichu.Paint;
            nouvelleArrivee();
            
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
            tmrAvancer.Enabled = false;
            swTempsEcoule.Stop();

            this.Controls.Clear();
            this.Paint -= dessinLabyrinthe;
            this.Paint -= raichu.Paint;

            Label lbl = new Label();
            lbl.Location = new Point(POSITION_CODE_VICTOIRE_X, POSITION_CODE_VICTOIRE_Y);
            lbl.Text = "Le code est :" + Environment.NewLine + rnd.Next(CODE_MIN, CODE_MAX + 1).ToString();
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
                string instrucAcruelle = lstInstruction.ElementAt(compteurInstructionsEffectuees).ToString();
                bool collision = false;

                if (instrucAcruelle == "Avancer")
                {
                    raichu.Avancer();

                    foreach (Bloc b in lstLabyrinthe)
                    {
                        //si il n'y a pas deja eu une collision, analise chaque bloc pour voir si on collisionne (empeche le clignottement)
                        if (!collision)
                        {
                            if (new PointF(raichu.Position.X , raichu.Position.Y ) == b.Position)
                            {
                                string arriveePrecedente = lblArrivee.Text;

                                if (b.Position == arriveeDemandee.Position)
                                {
                                    //Action apres avoir gagne
                                    Gagner();

                                    btnReset_Click(sender, e);
                                    lbxInstruction.Enabled = true;
                                    enJeu = false;
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

                        switch (raichu.Orientation)
                        {
                            case (int)Direction.Gauche:
                                raichu.Orientation = (int)Direction.Droite;
                                raichu.Avancer();
                                raichu.Orientation = (int)Direction.Gauche;
                                break;
                            case (int)Direction.Droite:
                                raichu.Orientation = (int)Direction.Gauche;
                                raichu.Avancer();
                                raichu.Orientation = (int)Direction.Droite;
                                break;
                            case (int)Direction.Bas:
                                raichu.Orientation = (int)Direction.Haut;
                                raichu.Avancer();
                                raichu.Orientation = (int)Direction.Bas;
                                break;
                            case (int)Direction.Haut:
                                raichu.Orientation = (int)Direction.Bas;
                                raichu.Avancer();
                                raichu.Orientation = (int)Direction.Haut;
                                break;
                        }
                        tmrAvancer.Enabled = false;

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
                else
                {
                    if (instrucAcruelle == "Tourner à droite")
                    {
                        raichu.PivoterDroite();
                    }
                    else
                    {
                        if (instrucAcruelle == "Tourner à gauche")
                        {
                            raichu.PivoterGauche();
                        }
                    }
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
            raichu.Position = positionDepartpersonnage;
            raichu.Orientation = (int)Direction.Haut;
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
    }
}
