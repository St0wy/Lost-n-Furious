using System;
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
// Gerer les click dans la listbox pendant le Play --> Ya deja event click tout en bas
namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        PaintEventHandler image;    //Variable d'affichage du labyrinthe
        Personnage p = new Personnage(new PointF(0, 0), "haut");

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

        int[][] tabLabMoyen = new int[][] {
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 },
            new int[] { 4, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 4 },
            new int[] { 4, 2, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 2, 4 },
            new int[] { 4, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }
        };

        int[][] tabLabGrand = new int[][] {
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 },
            new int[] { 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 4 },
            new int[] { 4, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 1, 0, 0, 0, 1, 0, 6, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 6, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 4 },
            new int[] { 4, 2, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 2, 4 },
            new int[] { 4, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 4 },
            new int[] { 4, 1, 1, 0, 1, 1, 1, 1, 1, 0, 6, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 4 },
            new int[] { 4, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 4 },
            new int[] { 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4 },
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }
        };

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
		
        public void CreateLabFromGrid(int[][] tabLab)
        {
            for (int i = 0; i < tabLab.Length; i++)
            {
                int y = (i + 1) * 30 + 10;
                for (int j = 0; j < tabLab[i].Length; j++)
                {
                    int x = (j + 1) * 30 + 10;
                    if (tabLab[i][j] == 1)
                    {
                        creationMur(x, y);
                    }
                    else if (tabLab[i][j] == 2)
                    {
                        creationArrivee(x, y);
                    }
                    else if (tabLab[i][j] == 3)
                    {
                        p.Position = new PointF(Convert.ToSingle(x) + 5f, Convert.ToSingle(y) + 5f);
                    }
                }
            }
        }

        public void creationBordure(int x, int y)
        {
            var bordure = new Bordure(x, y);
            labyrinthe.Add(bordure);
            //Ajoute l'affichage de l'objet dans une variable d'image
            image += bordure.Paint;
        }

        public void creationArrivee(int x, int y)
        {
            var arrivee = new Arrivee(x, y);
            labyrinthe.Add(arrivee);
            //Ajoute l'affichage de l'objet dans une variable d'image
            image += arrivee.Paint;
        }

        public void creationMur(int x, int y)
        {
            var bloc = new Bloc(x, y);
            labyrinthe.Add(bloc);
            //Ajoute l'affichage de l'objet dans une variable d'image
            image += bloc.Paint;
        }

        public void nouvelleArrivee()
        {
            Random rnd = new Random();
            int valArrive = rnd.Next(3);
            int tmp = 0;

            Label lblArrivee = new Label();
            lblArrivee.Location = new Point(779, 116);
            lblArrivee.Font = new Font("Arial", 13);

            foreach (Bloc m in labyrinthe)
            {
                if (m is Arrivee)
                {
                    if (valArrive == tmp)
                    {
                        modele = m;
                    }
                    tmp++;
                }
            }
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
            this.Controls.Add(lblArrivee);
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Tourner à droite");

            btnPlay.Enabled = true;
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Tourner à gauche");

            btnPlay.Enabled = true;
        }

        private void btnAvancer_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Avancer");

            btnPlay.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        public virtual void frmMain_Load(object sender, EventArgs e)
        {
            //Affiche le labyrinthe
            CreateLabFromGrid(tabLabMoyen);
            this.Paint += image;
            this.Paint += p.Paint;
            nouvelleArrivee();

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
            btnPlay.Enabled = false;
            btnReset.Enabled = true;
        }

        private void tmrAvancer_Tick(object sender, EventArgs e)
        {
            if (instruction.Count != 0)
            {
                string instrucAcruelle = instruction.ElementAt(compteur).ToString();
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
								if (b == modele)
								{
									tmrAvancer.Enabled = false;
									MessageBox.Show("Bravo! Tu as a gagné. Tu es beau.");
									btnReset_Click(sender, e);
									nouvelleArrivee();
									inPlay = false;
                                    lbxInstruction.Enabled = true;
									break;
								}
							}
                            if (new PointF(p.Position.X - 5, p.Position.Y - 5) == b.Position)
                            {
                                collision = true;
                                if (b == modele)
                                {
                                    tmrAvancer.Enabled = false;
                                    MessageBox.Show("Bravo! Tu as a gagné. Tu es beau.");
                                    btnReset_Click(sender, e);
                                    nouvelleArrivee();
                                    inPlay = false;
                                    break;
                                }
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
                compteur++;

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
            p.Position = new PointF(255, 495);
            p.Orientation = "haut";
            compteur = 0;
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
            }
        }

        private void menuFichierAdmin_Click(object sender, EventArgs e)
        {
            string difficulteLaby = "";
            frmLogin frmLog = new frmLogin();
			
            if (DialogResult.OK == frmLog.ShowDialog())
            {
                difficulteLaby = frmLog.GetDifficulte();

                this.Paint -= image;
                image = null;
                //vider variable image


                if (difficulteLaby == "Grand")
                {
                    //appeler creation labyrinthe grand
                    CreateLabFromGrid(tabLabGrand);
                    nouvelleArrivee();
                    lblDifficulteTaille.Text = "Grand";
                    btnReset_Click(sender, e);
                }
                else if (difficulteLaby == "Moyen")
                {
                    //appeler creation labyrinthe moyen
                    CreateLabFromGrid(tabLabMoyen);
                    nouvelleArrivee();
                    lblDifficulteTaille.Text = "Moyen";
                    btnReset_Click(sender, e);
                }
                else if (difficulteLaby == "Petit")
                {
                    //appeler creation labyrinthe petit
                    CreateLabFromGrid(tabLabPetit);
                    nouvelleArrivee();
                    lblDifficulteTaille.Text = "Petit";
                    btnReset_Click(sender, e);
                }

                this.Paint += image;
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
