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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNewScore = new System.Windows.Forms.Panel();
            this.btnEnregistrerNewScore = new System.Windows.Forms.Button();
            this.lblNewScore = new System.Windows.Forms.Label();
            this.tbxNewScore = new System.Windows.Forms.TextBox();
            this.pnlTableauScores = new System.Windows.Forms.Panel();
            this.gbxScoresPetit = new System.Windows.Forms.GroupBox();
            this.dgvScoresPetit = new System.Windows.Forms.DataGridView();
            this.gbxScoresGrand = new System.Windows.Forms.GroupBox();
            this.dgvScoresGrand = new System.Windows.Forms.DataGridView();
            this.btnScoresIgnorer = new System.Windows.Forms.Button();
            this.btnScoresOk = new System.Windows.Forms.Button();
            this.gbxScoresMoyen = new System.Windows.Forms.GroupBox();
            this.dgvScoresMoyen = new System.Windows.Forms.DataGridView();
            this.lblTitreScores = new System.Windows.Forms.Label();
            this.pnlNewScore.SuspendLayout();
            this.pnlTableauScores.SuspendLayout();
            this.gbxScoresPetit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresPetit)).BeginInit();
            this.gbxScoresGrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresGrand)).BeginInit();
            this.gbxScoresMoyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresMoyen)).BeginInit();
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
            this.pnlNewScore.Size = new System.Drawing.Size(1192, 78);
            this.pnlNewScore.TabIndex = 0;
            // 
            // btnEnregistrerNewScore
            // 
            this.btnEnregistrerNewScore.Location = new System.Drawing.Point(676, 40);
            this.btnEnregistrerNewScore.Name = "btnEnregistrerNewScore";
            this.btnEnregistrerNewScore.Size = new System.Drawing.Size(150, 23);
            this.btnEnregistrerNewScore.TabIndex = 2;
            this.btnEnregistrerNewScore.Text = "Enregistrer";
            this.btnEnregistrerNewScore.UseVisualStyleBackColor = true;
            this.btnEnregistrerNewScore.Click += new System.EventHandler(this.btnEnregistrerNewScore_Click);
            // 
            // lblNewScore
            // 
            this.lblNewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewScore.Location = new System.Drawing.Point(3, 19);
            this.lblNewScore.Name = "lblNewScore";
            this.lblNewScore.Size = new System.Drawing.Size(1186, 18);
            this.lblNewScore.TabIndex = 1;
            this.lblNewScore.Text = "Entrez votre nom pour enregistrer votre score";
            this.lblNewScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxNewScore
            // 
            this.tbxNewScore.Location = new System.Drawing.Point(361, 42);
            this.tbxNewScore.Name = "tbxNewScore";
            this.tbxNewScore.Size = new System.Drawing.Size(309, 20);
            this.tbxNewScore.TabIndex = 0;
            // 
            // pnlTableauScores
            // 
            this.pnlTableauScores.Controls.Add(this.gbxScoresPetit);
            this.pnlTableauScores.Controls.Add(this.gbxScoresGrand);
            this.pnlTableauScores.Controls.Add(this.btnScoresIgnorer);
            this.pnlTableauScores.Controls.Add(this.btnScoresOk);
            this.pnlTableauScores.Controls.Add(this.gbxScoresMoyen);
            this.pnlTableauScores.Controls.Add(this.lblTitreScores);
            this.pnlTableauScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableauScores.Location = new System.Drawing.Point(0, 78);
            this.pnlTableauScores.Name = "pnlTableauScores";
            this.pnlTableauScores.Size = new System.Drawing.Size(1192, 390);
            this.pnlTableauScores.TabIndex = 1;
            this.pnlTableauScores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTableauScores_Paint);
            // 
            // gbxScoresPetit
            // 
            this.gbxScoresPetit.Controls.Add(this.dgvScoresPetit);
            this.gbxScoresPetit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxScoresPetit.Location = new System.Drawing.Point(12, 53);
            this.gbxScoresPetit.Name = "gbxScoresPetit";
            this.gbxScoresPetit.Size = new System.Drawing.Size(375, 265);
            this.gbxScoresPetit.TabIndex = 2;
            this.gbxScoresPetit.TabStop = false;
            this.gbxScoresPetit.Text = "Petit";
            this.gbxScoresPetit.Enter += new System.EventHandler(this.gbxScoresPetit_Enter);
            // 
            // dgvScoresPetit
            // 
            this.dgvScoresPetit.AllowUserToAddRows = false;
            this.dgvScoresPetit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvScoresPetit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoresPetit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScoresPetit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScoresPetit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoresPetit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoresPetit.Location = new System.Drawing.Point(6, 19);
            this.dgvScoresPetit.Name = "dgvScoresPetit";
            this.dgvScoresPetit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoresPetit.Size = new System.Drawing.Size(363, 240);
            this.dgvScoresPetit.TabIndex = 1;
            // 
            // gbxScoresGrand
            // 
            this.gbxScoresGrand.Controls.Add(this.dgvScoresGrand);
            this.gbxScoresGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxScoresGrand.Location = new System.Drawing.Point(774, 53);
            this.gbxScoresGrand.Name = "gbxScoresGrand";
            this.gbxScoresGrand.Size = new System.Drawing.Size(375, 265);
            this.gbxScoresGrand.TabIndex = 2;
            this.gbxScoresGrand.TabStop = false;
            this.gbxScoresGrand.Text = "Grand";
            this.gbxScoresGrand.Enter += new System.EventHandler(this.gbxScoresGrand_Enter);
            // 
            // dgvScoresGrand
            // 
            this.dgvScoresGrand.AllowUserToAddRows = false;
            this.dgvScoresGrand.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvScoresGrand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScoresGrand.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScoresGrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScoresGrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoresGrand.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvScoresGrand.Location = new System.Drawing.Point(6, 19);
            this.dgvScoresGrand.Name = "dgvScoresGrand";
            this.dgvScoresGrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoresGrand.Size = new System.Drawing.Size(363, 240);
            this.dgvScoresGrand.TabIndex = 1;
            this.dgvScoresGrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoresGrand_CellContentClick);
            // 
            // btnScoresIgnorer
            // 
            this.btnScoresIgnorer.Location = new System.Drawing.Point(594, 335);
            this.btnScoresIgnorer.Name = "btnScoresIgnorer";
            this.btnScoresIgnorer.Size = new System.Drawing.Size(346, 43);
            this.btnScoresIgnorer.TabIndex = 3;
            this.btnScoresIgnorer.Text = "Ignorer";
            this.btnScoresIgnorer.UseVisualStyleBackColor = true;
            this.btnScoresIgnorer.Click += new System.EventHandler(this.btnScoresIgnorer_Click);
            // 
            // btnScoresOk
            // 
            this.btnScoresOk.Location = new System.Drawing.Point(242, 335);
            this.btnScoresOk.Name = "btnScoresOk";
            this.btnScoresOk.Size = new System.Drawing.Size(346, 43);
            this.btnScoresOk.TabIndex = 2;
            this.btnScoresOk.Text = "OK";
            this.btnScoresOk.UseVisualStyleBackColor = true;
            this.btnScoresOk.Click += new System.EventHandler(this.btnScoresOk_Click);
            // 
            // gbxScoresMoyen
            // 
            this.gbxScoresMoyen.Controls.Add(this.dgvScoresMoyen);
            this.gbxScoresMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxScoresMoyen.Location = new System.Drawing.Point(393, 53);
            this.gbxScoresMoyen.Name = "gbxScoresMoyen";
            this.gbxScoresMoyen.Size = new System.Drawing.Size(375, 265);
            this.gbxScoresMoyen.TabIndex = 1;
            this.gbxScoresMoyen.TabStop = false;
            this.gbxScoresMoyen.Text = "Moyen";
            this.gbxScoresMoyen.Enter += new System.EventHandler(this.gbxScoresMoyen_Enter);
            // 
            // dgvScoresMoyen
            // 
            this.dgvScoresMoyen.AllowUserToAddRows = false;
            this.dgvScoresMoyen.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvScoresMoyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvScoresMoyen.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScoresMoyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScoresMoyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoresMoyen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvScoresMoyen.Location = new System.Drawing.Point(6, 19);
            this.dgvScoresMoyen.Name = "dgvScoresMoyen";
            this.dgvScoresMoyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoresMoyen.Size = new System.Drawing.Size(363, 240);
            this.dgvScoresMoyen.TabIndex = 1;
            this.dgvScoresMoyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoresMoyen_CellContentClick);
            // 
            // lblTitreScores
            // 
            this.lblTitreScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreScores.Location = new System.Drawing.Point(3, 3);
            this.lblTitreScores.Name = "lblTitreScores";
            this.lblTitreScores.Size = new System.Drawing.Size(1186, 23);
            this.lblTitreScores.TabIndex = 0;
            this.lblTitreScores.Text = "Tableaux des scores";
            this.lblTitreScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 468);
            this.Controls.Add(this.pnlTableauScores);
            this.Controls.Add(this.pnlNewScore);
            this.MaximizeBox = false;
            this.Name = "frmScores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmScores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScores_FormClosing);
            this.Load += new System.EventHandler(this.frmScores_Load);
            this.pnlNewScore.ResumeLayout(false);
            this.pnlNewScore.PerformLayout();
            this.pnlTableauScores.ResumeLayout(false);
            this.gbxScoresPetit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresPetit)).EndInit();
            this.gbxScoresGrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresGrand)).EndInit();
            this.gbxScoresMoyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresMoyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewScore;
        private System.Windows.Forms.Button btnEnregistrerNewScore;
        private System.Windows.Forms.Label lblNewScore;
        private System.Windows.Forms.TextBox tbxNewScore;
        private System.Windows.Forms.Panel pnlTableauScores;
        private System.Windows.Forms.GroupBox gbxScoresMoyen;
        private System.Windows.Forms.Label lblTitreScores;
        private System.Windows.Forms.Button btnScoresIgnorer;
        private System.Windows.Forms.Button btnScoresOk;
        private System.Windows.Forms.DataGridView dgvScoresMoyen;
        private System.Windows.Forms.GroupBox gbxScoresPetit;
        private System.Windows.Forms.DataGridView dgvScoresPetit;
        private System.Windows.Forms.GroupBox gbxScoresGrand;
        private System.Windows.Forms.DataGridView dgvScoresGrand;
    }
}