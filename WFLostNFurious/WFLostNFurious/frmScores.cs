using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLostNFurious
{
    public partial class frmScores : Form
    {
        string difficulte = string.Empty;
        string sortieDemandee = string.Empty;
        string nomUser = string.Empty;
        long tempsEcouleMillisec = 0;

        public frmScores()
        {
            InitializeComponent();
        }

        public void SetPnlNewScoreVisible(bool visible)
        {
            if (visible)
            {
                pnlNewScore.Height = 78;
                this.Height = 507;
            }
            else
            {
                pnlNewScore.Height = 1;
                this.Height = 361;
            }
        }

        public void SetTempsEcoule(long temps)
        {
            tempsEcouleMillisec = temps;
        }

        public void SetDifficulte(string diff)
        {
            difficulte = diff;
        }

        public void SetSortieDemande(string sortie)
        {
            sortieDemandee = sortie;
        }

        private void btnEnregistrerNewScore_Click(object sender, EventArgs e)
        {
            if (tbxNewScore.Text != string.Empty)
            {
                //Enregistrer le nouveau score
            }
        }
    }
}
