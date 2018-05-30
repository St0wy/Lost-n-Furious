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
            this.lblArrivee = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDroite
            // 
            this.btnDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDroite.Location = new System.Drawing.Point(119, 146);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(83, 39);
            this.btnDroite.TabIndex = 4;
            this.btnDroite.Text = "→";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.BtnDroite_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauche.Location = new System.Drawing.Point(28, 146);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(83, 39);
            this.btnGauche.TabIndex = 3;
            this.btnGauche.Text = "←";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.Click += new System.EventHandler(this.BtnGauche_Click);
            // 
            // tmrInvalidate
            // 
            this.tmrInvalidate.Enabled = true;
            this.tmrInvalidate.Interval = 16;
            this.tmrInvalidate.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnAvancer
            // 
            this.btnAvancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancer.Location = new System.Drawing.Point(28, 101);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(174, 39);
            this.btnAvancer.TabIndex = 2;
            this.btnAvancer.Text = "↑";
            this.btnAvancer.UseVisualStyleBackColor = true;
            this.btnAvancer.Click += new System.EventHandler(this.BtnAvancer_Click);
            // 
            // lbxInstruction
            // 
            this.lbxInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInstruction.FormattingEnabled = true;
            this.lbxInstruction.Location = new System.Drawing.Point(28, 191);
            this.lbxInstruction.Name = "lbxInstruction";
            this.lbxInstruction.Size = new System.Drawing.Size(174, 706);
            this.lbxInstruction.TabIndex = 1;
            this.lbxInstruction.SelectedIndexChanged += new System.EventHandler(this.LbxInstruction_SelectedIndexChanged);
            this.lbxInstruction.DoubleClick += new System.EventHandler(this.LbxInstruction_DoubleClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(28, 17);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(174, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // tmrAvancer
            // 
            this.tmrAvancer.Interval = 500;
            this.tmrAvancer.Tick += new System.EventHandler(this.TmrAvancer_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(28, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblArrivee
            // 
            this.lblArrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivee.Location = new System.Drawing.Point(28, 75);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(174, 23);
            this.lblArrivee.TabIndex = 8;
            this.lblArrivee.Text = "lblArrivee";
            this.lblArrivee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.btnViderListe);
            this.pnlInstructions.Controls.Add(this.btnPlay);
            this.pnlInstructions.Controls.Add(this.lblArrivee);
            this.pnlInstructions.Controls.Add(this.btnDroite);
            this.pnlInstructions.Controls.Add(this.btnGauche);
            this.pnlInstructions.Controls.Add(this.btnAvancer);
            this.pnlInstructions.Controls.Add(this.btnReset);
            this.pnlInstructions.Controls.Add(this.lbxInstruction);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInstructions.Location = new System.Drawing.Point(1027, 0);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(237, 985);
            this.pnlInstructions.TabIndex = 9;
            this.pnlInstructions.Visible = false;
            // 
            // btnViderListe
            // 
            this.btnViderListe.Location = new System.Drawing.Point(28, 911);
            this.btnViderListe.Margin = new System.Windows.Forms.Padding(2);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(174, 63);
            this.btnViderListe.TabIndex = 11;
            this.btnViderListe.Text = "Vider la liste";
            this.btnViderListe.UseVisualStyleBackColor = true;
            this.btnViderListe.Click += new System.EventHandler(this.BtnViderListe_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(344, 242);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(589, 532);
            this.btnStartGame.TabIndex = 10;
            this.btnStartGame.Text = "Commencer";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pnlInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost\'n\'Furious";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlInstructions.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Button btnViderListe;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.Button btnStartGame;
    }
}

