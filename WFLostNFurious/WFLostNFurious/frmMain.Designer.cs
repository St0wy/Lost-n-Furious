namespace WFLostNFurious
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer tmrPaint;
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFichierAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDifficulteTaille = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.pnlTailleGrid = new System.Windows.Forms.Panel();
            this.menuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAideAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAideAide = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
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
            this.lbxInstruction.Size = new System.Drawing.Size(231, 361);
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
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.menuAide});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1097, 28);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichierAdmin,
            this.menuFichierQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(64, 24);
            this.menuFichier.Text = "Fichier";
            // 
            // menuFichierAdmin
            // 
            this.menuFichierAdmin.Name = "menuFichierAdmin";
            this.menuFichierAdmin.Size = new System.Drawing.Size(303, 26);
            this.menuFichierAdmin.Text = "Mode Admin - Changer difficulté";
            this.menuFichierAdmin.Click += new System.EventHandler(this.menuFichierAdmin_Click);
            // 
            // menuFichierQuitter
            // 
            this.menuFichierQuitter.Name = "menuFichierQuitter";
            this.menuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFichierQuitter.Size = new System.Drawing.Size(303, 26);
            this.menuFichierQuitter.Text = "Quitter";
            this.menuFichierQuitter.Click += new System.EventHandler(this.menuFichierQuitter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = " Taille actuelle: ";
            // 
            // lblDifficulteTaille
            // 
            this.lblDifficulteTaille.AutoSize = true;
            this.lblDifficulteTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulteTaille.Location = new System.Drawing.Point(197, 12);
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
            this.pnlInstructions.Controls.Add(this.pnlTailleGrid);
            this.pnlInstructions.Controls.Add(this.btnPlay);
            this.pnlInstructions.Controls.Add(this.lblArrivee);
            this.pnlInstructions.Controls.Add(this.btnDroite);
            this.pnlInstructions.Controls.Add(this.btnGauche);
            this.pnlInstructions.Controls.Add(this.btnAvancer);
            this.pnlInstructions.Controls.Add(this.btnReset);
            this.pnlInstructions.Controls.Add(this.lbxInstruction);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInstructions.Location = new System.Drawing.Point(781, 28);
            this.pnlInstructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(316, 694);
            this.pnlInstructions.TabIndex = 9;
            // 
            // pnlTailleGrid
            // 
            this.pnlTailleGrid.Controls.Add(this.lblDifficulteTaille);
            this.pnlTailleGrid.Controls.Add(this.label5);
            this.pnlTailleGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTailleGrid.Location = new System.Drawing.Point(0, 630);
            this.pnlTailleGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTailleGrid.Name = "pnlTailleGrid";
            this.pnlTailleGrid.Size = new System.Drawing.Size(316, 64);
            this.pnlTailleGrid.TabIndex = 10;
            // 
            // menuAide
            // 
            this.menuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAideAbout,
            this.menuAideAide});
            this.menuAide.Name = "menuAide";
            this.menuAide.Size = new System.Drawing.Size(52, 24);
            this.menuAide.Text = "Aide";
            // 
            // menuAideAbout
            // 
            this.menuAideAbout.Name = "menuAideAbout";
            this.menuAideAbout.Size = new System.Drawing.Size(181, 26);
            this.menuAideAbout.Text = "A Propos";
            this.menuAideAbout.Click += new System.EventHandler(this.menuAideAbout_Click);
            // 
            // menuAideAide
            // 
            this.menuAideAide.Name = "menuAideAide";
            this.menuAideAide.Size = new System.Drawing.Size(181, 26);
            this.menuAideAide.Text = "Aide";
            this.menuAideAide.Click += new System.EventHandler(this.menuAideAide_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 722);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost\'n\'Furious";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlInstructions.ResumeLayout(false);
            this.pnlTailleGrid.ResumeLayout(false);
            this.pnlTailleGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuFichierAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuFichierQuitter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDifficulteTaille;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Panel pnlTailleGrid;
        private System.Windows.Forms.ToolStripMenuItem menuAide;
        private System.Windows.Forms.ToolStripMenuItem menuAideAbout;
        private System.Windows.Forms.ToolStripMenuItem menuAideAide;
    }
}

