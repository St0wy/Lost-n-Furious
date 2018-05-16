namespace WFLostNFurious
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.tmrInvalidate = new System.Windows.Forms.Timer(this.components);
            this.btnAvancer = new System.Windows.Forms.Button();
            this.lbxInstruction = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tmrAvancer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDifficulteTaille = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.pnlTailleGrid = new System.Windows.Forms.Panel();
            this.lblTempsEcoule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInstructions.SuspendLayout();
            this.pnlTailleGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDroite
            // 
            this.btnDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDroite.Location = new System.Drawing.Point(159, 180);
            this.btnDroite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(111, 48);
            this.btnDroite.TabIndex = 4;
            this.btnDroite.Text = "→";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauche.Location = new System.Drawing.Point(37, 180);
            this.btnGauche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(111, 48);
            this.btnGauche.TabIndex = 3;
            this.btnGauche.Text = "←";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // tmrInvalidate
            // 
            this.tmrInvalidate.Enabled = true;
            this.tmrInvalidate.Interval = 16;
            this.tmrInvalidate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAvancer
            // 
            this.btnAvancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancer.Location = new System.Drawing.Point(37, 124);
            this.btnAvancer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(232, 48);
            this.btnAvancer.TabIndex = 2;
            this.btnAvancer.Text = "↑";
            this.btnAvancer.UseVisualStyleBackColor = true;
            this.btnAvancer.Click += new System.EventHandler(this.btnAvancer_Click);
            // 
            // lbxInstruction
            // 
            this.lbxInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInstruction.FormattingEnabled = true;
            this.lbxInstruction.ItemHeight = 17;
            this.lbxInstruction.Location = new System.Drawing.Point(37, 235);
            this.lbxInstruction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxInstruction.Name = "lbxInstruction";
            this.lbxInstruction.Size = new System.Drawing.Size(231, 327);
            this.lbxInstruction.TabIndex = 1;
            this.lbxInstruction.SelectedIndexChanged += new System.EventHandler(this.lbxInstruction_SelectedIndexChanged);
            this.lbxInstruction.DoubleClick += new System.EventHandler(this.lbxInstruction_DoubleClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(37, 21);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(232, 28);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tmrAvancer
            // 
            this.tmrAvancer.Interval = 500;
            this.tmrAvancer.Tick += new System.EventHandler(this.tmrAvancer_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(37, 57);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(232, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = " Taille actuelle  : ";
            // 
            // lblDifficulteTaille
            // 
            this.lblDifficulteTaille.AutoSize = true;
            this.lblDifficulteTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulteTaille.Location = new System.Drawing.Point(197, 0);
            this.lblDifficulteTaille.Name = "lblDifficulteTaille";
            this.lblDifficulteTaille.Size = new System.Drawing.Size(63, 20);
            this.lblDifficulteTaille.TabIndex = 7;
            this.lblDifficulteTaille.Text = "Moyen";
            // 
            // lblArrivee
            // 
            this.lblArrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivee.Location = new System.Drawing.Point(37, 92);
            this.lblArrivee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(232, 28);
            this.lblArrivee.TabIndex = 8;
            this.lblArrivee.Text = "lblArrivee";
            this.lblArrivee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.btnViderListe);
            this.pnlInstructions.Controls.Add(this.pnlTailleGrid);
            this.pnlInstructions.Controls.Add(this.btnPlay);
            this.pnlInstructions.Controls.Add(this.lblArrivee);
            this.pnlInstructions.Controls.Add(this.btnDroite);
            this.pnlInstructions.Controls.Add(this.btnGauche);
            this.pnlInstructions.Controls.Add(this.btnAvancer);
            this.pnlInstructions.Controls.Add(this.btnReset);
            this.pnlInstructions.Controls.Add(this.lbxInstruction);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInstructions.Location = new System.Drawing.Point(781, 0);
            this.pnlInstructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(316, 722);
            this.pnlInstructions.TabIndex = 9;
            // 
            // btnViderListe
            // 
            this.btnViderListe.Location = new System.Drawing.Point(37, 582);
            this.btnViderListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(232, 23);
            this.btnViderListe.TabIndex = 11;
            this.btnViderListe.Text = "Vider la liste";
            this.btnViderListe.UseVisualStyleBackColor = true;
            this.btnViderListe.Click += new System.EventHandler(this.btnViderListe_Click);
            // 
            // pnlTailleGrid
            // 
            this.pnlTailleGrid.Controls.Add(this.lblTempsEcoule);
            this.pnlTailleGrid.Controls.Add(this.label2);
            this.pnlTailleGrid.Controls.Add(this.lblDifficulteTaille);
            this.pnlTailleGrid.Controls.Add(this.label5);
            this.pnlTailleGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTailleGrid.Location = new System.Drawing.Point(0, 643);
            this.pnlTailleGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTailleGrid.Name = "pnlTailleGrid";
            this.pnlTailleGrid.Size = new System.Drawing.Size(316, 79);
            this.pnlTailleGrid.TabIndex = 10;
            // 
            // lblTempsEcoule
            // 
            this.lblTempsEcoule.AutoSize = true;
            this.lblTempsEcoule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsEcoule.Location = new System.Drawing.Point(197, 21);
            this.lblTempsEcoule.Name = "lblTempsEcoule";
            this.lblTempsEcoule.Size = new System.Drawing.Size(63, 20);
            this.lblTempsEcoule.TabIndex = 9;
            this.lblTempsEcoule.Text = "Moyen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = " Temps écoulé :";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 722);
            this.Controls.Add(this.pnlInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost\'n\'Furious";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlInstructions.ResumeLayout(false);
            this.pnlTailleGrid.ResumeLayout(false);
            this.pnlTailleGrid.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Timer tmrInvalidate;
        private System.Windows.Forms.Button btnAvancer;
        private System.Windows.Forms.ListBox lbxInstruction;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer tmrAvancer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDifficulteTaille;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Panel pnlTailleGrid;
        private System.Windows.Forms.Button btnViderListe;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.Label lblTempsEcoule;
        private System.Windows.Forms.Label label2;
    }
}

