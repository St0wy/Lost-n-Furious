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
using System.IO;

namespace WFLostNFurious
{
    public partial class frmScores : Form
    {
        List<string[]> lstScoresMoyen = new List<string[]>();
        List<string[]> lstScoresPetit = new List<string[]>();
        List<string[]> lstScoresGrand = new List<string[]>();

        string difficulte = string.Empty;
        string sortieDemandee = string.Empty;
        string nomUser = string.Empty;
        long tempsEcouleSec = 0;

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
            tempsEcouleSec = temps / 1000;
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
                bool saveOK = false;
                string chaineNewScore = string.Empty;
                nomUser = tbxNewScore.Text;

                btnScoresIgnorer.Enabled = false;
                

                chaineNewScore = string.Format("{0:dd.MM.yy}", DateTime.Now) + ";" + nomUser + ";" + sortieDemandee + ";" + tempsEcouleSec;

                if (difficulte == "Petit")
                {
                    saveScores("scoresPetit.txt", chaineNewScore, dgvScoresPetit, lstScoresPetit);

                    saveOK = true;
                }
                else if (difficulte == "Moyen")
                {
                    saveScores("scoresMoyen.txt", chaineNewScore, dgvScoresMoyen, lstScoresMoyen);

                    saveOK = true;
                }
                else
                {
                    saveScores("scoresGrand.txt", chaineNewScore, dgvScoresGrand, lstScoresGrand);

                    saveOK = true;
                }

                if (saveOK)
                {
                    btnEnregistrerNewScore.Enabled = false;
                    this.AcceptButton = btnScoresOk;
                    MessageBox.Show("Score enregistré avec succès!");
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème, le score n'a pas pu être enregistré...");
                }
                
            }
        }

        private void saveScores(string fichier, string chaineScore, DataGridView dgv, List<string[]> lstTabS)
        {
            if (!File.Exists(fichier))
            {
                var myfile = File.Create(fichier);
                myfile.Close();
            }

            List<string> lst = new List<string>();
            lst = RemplirListeAvecFichier(fichier);
            StreamWriter writer = new StreamWriter(fichier);

            lst.Add(chaineScore);
            RemplirLstTabStringAvecLstString(lst, lstTabS);
            dgv.Rows.Clear();
            RemplirDGVavecLstTabString(dgv, lstTabS);

            foreach (string line in lst)
            {
                writer.WriteLine(line);
            }

            writer.Close();
        }

        private void frmScores_Load(object sender, EventArgs e)
        {
            List<string> lstScoresPetitTemp = new List<string>();
            List<string> lstScoresMoyenTemp = new List<string>();
            List<string> lstScoresGrandTemp = new List<string>();

            RemplirLstTabStringAvecLstString(RemplirListeAvecFichier("scoresPetit.txt"), lstScoresPetit);
            RemplirLstTabStringAvecLstString(RemplirListeAvecFichier("scoresMoyen.txt"), lstScoresMoyen);
            RemplirLstTabStringAvecLstString(RemplirListeAvecFichier("scoresGrand.txt"), lstScoresGrand);

            SetDisplayDataGridView(dgvScoresPetit);
            SetDisplayDataGridView(dgvScoresMoyen);
            SetDisplayDataGridView(dgvScoresGrand);

            RemplirDGVavecLstTabString(dgvScoresPetit, lstScoresPetit);
            RemplirDGVavecLstTabString(dgvScoresMoyen, lstScoresMoyen);
            RemplirDGVavecLstTabString(dgvScoresGrand, lstScoresGrand);

            if (pnlNewScore.Visible)
            {
                this.AcceptButton = btnEnregistrerNewScore;
            }
        }

        private List<string> RemplirListeAvecFichier(string fichier)
        {
            if (!File.Exists(fichier))
            {
                var myfile = File.Create(fichier); 
                myfile.Close();
            }

            StreamReader reader = new StreamReader(fichier);
            List<string> lst = new List<string>();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                lst.Add(line);
            }

            reader.Close();

            return lst;
        }

        private void RemplirLstTabStringAvecLstString(List<string> lst, List<string[]> lstTabS)
        {
            lstTabS.Clear();

            foreach (string s in lst)
            {
                string[] scoreLine = new string[4];

                scoreLine = s.Split(';');

                lstTabS.Add(scoreLine);
            }
        }

        public void SetDisplayDataGridView(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            //dgvScoresMoyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 4;

            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Black;

            dgv.Columns[0].Name = "Date";
            dgv.Columns[1].Name = "Nom";
            dgv.Columns[2].Name = "Sortie";
            dgv.Columns[3].Name = "Temps en Sec";

            dgv.Columns[0].Width = 60;
            dgv.Columns[1].Width = 110;
            dgv.Columns[2].Width = 50;
            dgv.Columns[3].Width = 120;

            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[0].DefaultCellStyle.Padding = new Padding(3, 1, 1, 2);
            dgv.Columns[1].DefaultCellStyle.Padding = new Padding(3, 1, 1, 2);
            dgv.Columns[3].DefaultCellStyle.Padding = new Padding(2, 1, 1, 3);

            dgv.Sort(dgv.Columns[3], ListSortDirection.Ascending);
        }

        private void RemplirDGVavecLstTabString(DataGridView dgv, List<string[]> lst)
        {
            foreach (string[] tabS in lst)
            {
                dgv.Rows.Add(tabS);
            }

            dgv.Sort(dgv.Columns[3], ListSortDirection.Ascending);
        }

        private void btnScoresOk_Click(object sender, EventArgs e)
        {
            if (btnEnregistrerNewScore.Enabled)
            {
                MessageBox.Show("Vous n'avez pas enregistré votre score");
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnScoresIgnorer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void pnlTableauScores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbxScoresGrand_Enter(object sender, EventArgs e)
        {

        }

        private void gbxScoresMoyen_Enter(object sender, EventArgs e)
        {

        }

        private void gbxScoresPetit_Enter(object sender, EventArgs e)
        {

        }

        private void dgvScoresGrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvScoresMoyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
