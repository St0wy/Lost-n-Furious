namespace WFLostNFurious
{
    partial class frmScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNewScore = new System.Windows.Forms.Panel();
            this.pnlTableauScores = new System.Windows.Forms.Panel();
            this.tbxNewScore = new System.Windows.Forms.TextBox();
            this.lblNewScore = new System.Windows.Forms.Label();
            this.btnEnregistrerNewScore = new System.Windows.Forms.Button();
            this.lblTitreScores = new System.Windows.Forms.Label();
            this.gbxScoresMoyen = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnScoresOk = new System.Windows.Forms.Button();
            this.btnScoresIgnorer = new System.Windows.Forms.Button();
            this.pnlNewScore.SuspendLayout();
            this.pnlTableauScores.SuspendLayout();
            this.gbxScoresMoyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewScore
            // 
            this.pnlNewScore.Controls.Add(this.btnEnregistrerNewScore);
            this.pnlNewScore.Controls.Add(this.lblNewScore);
            this.pnlNewScore.Controls.Add(this.tbxNewScore);
            this.pnlNewScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewScore.Location = new System.Drawing.Point(0, 0);
            this.pnlNewScore.Name = "pnlNewScore";
            this.pnlNewScore.Size = new System.Drawing.Size(421, 78);
            this.pnlNewScore.TabIndex = 0;
            // 
            // pnlTableauScores
            // 
            this.pnlTableauScores.Controls.Add(this.btnScoresIgnorer);
            this.pnlTableauScores.Controls.Add(this.btnScoresOk);
            this.pnlTableauScores.Controls.Add(this.gbxScoresMoyen);
            this.pnlTableauScores.Controls.Add(this.lblTitreScores);
            this.pnlTableauScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableauScores.Location = new System.Drawing.Point(0, 78);
            this.pnlTableauScores.Name = "pnlTableauScores";
            this.pnlTableauScores.Size = new System.Drawing.Size(421, 390);
            this.pnlTableauScores.TabIndex = 1;
            // 
            // tbxNewScore
            // 
            this.tbxNewScore.Location = new System.Drawing.Point(16, 41);
            this.tbxNewScore.Name = "tbxNewScore";
            this.tbxNewScore.Size = new System.Drawing.Size(237, 20);
            this.tbxNewScore.TabIndex = 0;
            // 
            // lblNewScore
            // 
            this.lblNewScore.AutoSize = true;
            this.lblNewScore.Location = new System.Drawing.Point(13, 13);
            this.lblNewScore.Name = "lblNewScore";
            this.lblNewScore.Size = new System.Drawing.Size(219, 13);
            this.lblNewScore.TabIndex = 1;
            this.lblNewScore.Text = "Entrez votre nom pour enregistrer votre score";
            // 
            // btnEnregistrerNewScore
            // 
            this.btnEnregistrerNewScore.Location = new System.Drawing.Point(259, 39);
            this.btnEnregistrerNewScore.Name = "btnEnregistrerNewScore";
            this.btnEnregistrerNewScore.Size = new System.Drawing.Size(150, 23);
            this.btnEnregistrerNewScore.TabIndex = 2;
            this.btnEnregistrerNewScore.Text = "Enregistrer";
            this.btnEnregistrerNewScore.UseVisualStyleBackColor = true;
            this.btnEnregistrerNewScore.Click += new System.EventHandler(this.btnEnregistrerNewScore_Click);
            // 
            // lblTitreScores
            // 
            this.lblTitreScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreScores.Location = new System.Drawing.Point(3, 7);
            this.lblTitreScores.Name = "lblTitreScores";
            this.lblTitreScores.Size = new System.Drawing.Size(415, 23);
            this.lblTitreScores.TabIndex = 0;
            this.lblTitreScores.Text = "Tableaux des scores";
            this.lblTitreScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxScoresMoyen
            // 
            this.gbxScoresMoyen.Controls.Add(this.textBox1);
            this.gbxScoresMoyen.Location = new System.Drawing.Point(12, 45);
            this.gbxScoresMoyen.Name = "gbxScoresMoyen";
            this.gbxScoresMoyen.Size = new System.Drawing.Size(397, 265);
            this.gbxScoresMoyen.TabIndex = 1;
            this.gbxScoresMoyen.TabStop = false;
            this.gbxScoresMoyen.Text = "Moyen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 240);
            this.textBox1.TabIndex = 0;
            // 
            // btnScoresOk
            // 
            this.btnScoresOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnScoresOk.Location = new System.Drawing.Point(12, 335);
            this.btnScoresOk.Name = "btnScoresOk";
            this.btnScoresOk.Size = new System.Drawing.Size(120, 43);
            this.btnScoresOk.TabIndex = 2;
            this.btnScoresOk.Text = "OK";
            this.btnScoresOk.UseVisualStyleBackColor = true;
            // 
            // btnScoresIgnorer
            // 
            this.btnScoresIgnorer.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnScoresIgnorer.Location = new System.Drawing.Point(289, 335);
            this.btnScoresIgnorer.Name = "btnScoresIgnorer";
            this.btnScoresIgnorer.Size = new System.Drawing.Size(120, 43);
            this.btnScoresIgnorer.TabIndex = 3;
            this.btnScoresIgnorer.Text = "Ignorer";
            this.btnScoresIgnorer.UseVisualStyleBackColor = true;
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 468);
            this.Controls.Add(this.pnlTableauScores);
            this.Controls.Add(this.pnlNewScore);
            this.MaximizeBox = false;
            this.Name = "frmScores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmScores";
            this.pnlNewScore.ResumeLayout(false);
            this.pnlNewScore.PerformLayout();
            this.pnlTableauScores.ResumeLayout(false);
            this.gbxScoresMoyen.ResumeLayout(false);
            this.gbxScoresMoyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewScore;
        private System.Windows.Forms.Button btnEnregistrerNewScore;
        private System.Windows.Forms.Label lblNewScore;
        private System.Windows.Forms.TextBox tbxNewScore;
        private System.Windows.Forms.Panel pnlTableauScores;
        private System.Windows.Forms.GroupBox gbxScoresMoyen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitreScores;
        private System.Windows.Forms.Button btnScoresIgnorer;
        private System.Windows.Forms.Button btnScoresOk;
    }
}