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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.tmrInvalidate = new System.Windows.Forms.Timer(this.components);
            this.btnAvancer = new System.Windows.Forms.Button();
            this.lbxInstruction = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tmrAvancer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlCommandes = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.lblinstructions = new System.Windows.Forms.Label();
            this.pnlCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDroite
            // 
            this.btnDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDroite.Location = new System.Drawing.Point(140, 243);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(115, 39);
            this.btnDroite.TabIndex = 4;
            this.btnDroite.Text = "Pivoter à droite";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.BtnDroite_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauche.Location = new System.Drawing.Point(22, 243);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(112, 39);
            this.btnGauche.TabIndex = 3;
            this.btnGauche.Text = "Pivoter à gauche";
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
            this.btnAvancer.Location = new System.Drawing.Point(22, 198);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(233, 39);
            this.btnAvancer.TabIndex = 2;
            this.btnAvancer.Text = "Avancer";
            this.btnAvancer.UseVisualStyleBackColor = true;
            this.btnAvancer.Click += new System.EventHandler(this.BtnAvancer_Click);
            // 
            // lbxInstruction
            // 
            this.lbxInstruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInstruction.FormattingEnabled = true;
            this.lbxInstruction.Location = new System.Drawing.Point(22, 317);
            this.lbxInstruction.Name = "lbxInstruction";
            this.lbxInstruction.Size = new System.Drawing.Size(233, 598);
            this.lbxInstruction.TabIndex = 1;
            this.lbxInstruction.SelectedIndexChanged += new System.EventHandler(this.LbxInstruction_SelectedIndexChanged);
            this.lbxInstruction.DoubleClick += new System.EventHandler(this.LbxInstruction_DoubleClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(22, 925);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(233, 38);
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
            this.btnReset.Location = new System.Drawing.Point(22, 969);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(233, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Recommencer";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // pnlCommandes
            // 
            this.pnlCommandes.Controls.Add(this.pictureBox1);
            this.pnlCommandes.Controls.Add(this.btnViderListe);
            this.pnlCommandes.Controls.Add(this.btnPlay);
            this.pnlCommandes.Controls.Add(this.btnDroite);
            this.pnlCommandes.Controls.Add(this.btnGauche);
            this.pnlCommandes.Controls.Add(this.btnAvancer);
            this.pnlCommandes.Controls.Add(this.btnReset);
            this.pnlCommandes.Controls.Add(this.lbxInstruction);
            this.pnlCommandes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCommandes.Location = new System.Drawing.Point(803, 0);
            this.pnlCommandes.Name = "pnlCommandes";
            this.pnlCommandes.Size = new System.Drawing.Size(461, 985);
            this.pnlCommandes.TabIndex = 9;
            this.pnlCommandes.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFLostNFurious.Properties.Resources.logoCFPT;
            this.pictureBox1.Location = new System.Drawing.Point(81, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnViderListe
            // 
            this.btnViderListe.Enabled = false;
            this.btnViderListe.Location = new System.Drawing.Point(22, 289);
            this.btnViderListe.Margin = new System.Windows.Forms.Padding(2);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(233, 23);
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
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStartGame.Location = new System.Drawing.Point(83, 290);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(606, 462);
            this.btnStartGame.TabIndex = 10;
            this.btnStartGame.Text = "Commencer";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.lblinstructions);
            this.pnlInstructions.Location = new System.Drawing.Point(185, 0);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(1239, 74);
            this.pnlInstructions.TabIndex = 11;
            this.pnlInstructions.Visible = false;
            // 
            // lblinstructions
            // 
            this.lblinstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstructions.Location = new System.Drawing.Point(32, 9);
            this.lblinstructions.Name = "lblinstructions";
            this.lblinstructions.Size = new System.Drawing.Size(1204, 59);
            this.lblinstructions.TabIndex = 0;
            this.lblinstructions.Text = resources.GetString("lblinstructions.Text");
            this.lblinstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pnlCommandes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cité des métiers du 20 au 26 novembre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlCommandes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel pnlCommandes;
        private System.Windows.Forms.Button btnViderListe;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Label lblinstructions;
    }
}

