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
        Personnage p = new Personnage(new PointF(255, 495), "haut");
        Bloc modele = new Arrivee();
        List<Bloc> labyrinthe = new List<Bloc>();
        bool inPlay = false;
        List<string> instruction = new List<string>();
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

        public void nouvelleArrivee()
        {
            Random rnd = new Random();
            int valArrive = rnd.Next(3);
            int tmp = 0;

            Label lblArrivee = new Label();
            lblArrivee.Location = new Point(584, 91);
            lblArrivee.Font = new Font("Arial", 13);

            foreach (Bloc m in labyrinthe)
            {
                if(m is Arrivee)
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
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {

            lbxInstruction.Items.Add("Tourner à gauche");
        }

        private void btnAvancer_Click(object sender, EventArgs e)
        {
            lbxInstruction.Items.Add("Avancer");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        public virtual void frmMain_Load(object sender, EventArgs e)
        {
            //Affiche le personnage et le labyrinthe
            this.Paint += p.Paint;
            CreationLabyrithe();
            this.Paint += image;
            nouvelleArrivee();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach(string s in lbxInstruction.Items)
            {
                instruction.Add(s);
            }

            inPlay = true;
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

                        if (dr == DialogResult.Yes)
                        {
                            btnReset_Click(sender, e);
                            inPlay = false;
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

        private void lbxInstruction_Click(object sender, EventArgs e)
        {
            if (inPlay)
            {
                
            }
        }

        private void debug_Click(object sender, EventArgs e)
        {
            frmGrandLabyrinthe frm = new frmGrandLabyrinthe();
            frm.Show();
        }

        private void lbxInstruction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxInstruction.Items.Count == 0)
            {
                btnPlay.Enabled = false;
            }
            else
            {
                btnPlay.Enabled = true;
            }
        }
    }
}
