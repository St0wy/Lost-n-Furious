namespace WFLostNFurious
{
    partial class frmLogin
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
            this.tbxNomUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbxDifficultes = new System.Windows.Forms.GroupBox();
            this.rbtnGrand = new System.Windows.Forms.RadioButton();
            this.rbtnMoyen = new System.Windows.Forms.RadioButton();
            this.rbtnPetit = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxDifficultes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNomUser
            // 
            this.tbxNomUser.Location = new System.Drawing.Point(98, 39);
            this.tbxNomUser.Name = "tbxNomUser";
            this.tbxNomUser.Size = new System.Drawing.Size(298, 20);
            this.tbxNomUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez vous connecter et choisir une difficulté";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Location = new System.Drawing.Point(16, 42);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(76, 13);
            this.lblNomUser.TabIndex = 2;
            this.lblNomUser.Text = "Nom utilisateur";
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Location = new System.Drawing.Point(16, 68);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(71, 13);
            this.lblmdp.TabIndex = 4;
            this.lblmdp.Text = "Mot de passe";
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(98, 65);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.PasswordChar = '*';
            this.tbxMdp.Size = new System.Drawing.Size(298, 20);
            this.tbxMdp.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(19, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 41);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbxDifficultes
            // 
            this.gbxDifficultes.Controls.Add(this.rbtnGrand);
            this.gbxDifficultes.Controls.Add(this.rbtnMoyen);
            this.gbxDifficultes.Controls.Add(this.rbtnPetit);
            this.gbxDifficultes.Location = new System.Drawing.Point(19, 96);
            this.gbxDifficultes.Name = "gbxDifficultes";
            this.gbxDifficultes.Size = new System.Drawing.Size(377, 53);
            this.gbxDifficultes.TabIndex = 6;
            this.gbxDifficultes.TabStop = false;
            this.gbxDifficultes.Text = "Choisir une difficulté de labyrinthe:";
            // 
            // rbtnGrand
            // 
            this.rbtnGrand.AutoSize = true;
            this.rbtnGrand.Location = new System.Drawing.Point(293, 19);
            this.rbtnGrand.Name = "rbtnGrand";
            this.rbtnGrand.Size = new System.Drawing.Size(54, 17);
            this.rbtnGrand.TabIndex = 2;
            this.rbtnGrand.TabStop = true;
            this.rbtnGrand.Text = "Grand";
            this.rbtnGrand.UseVisualStyleBackColor = true;
            // 
            // rbtnMoyen
            // 
            this.rbtnMoyen.AutoSize = true;
            this.rbtnMoyen.Checked = true;
            this.rbtnMoyen.Location = new System.Drawing.Point(161, 19);
            this.rbtnMoyen.Name = "rbtnMoyen";
            this.rbtnMoyen.Size = new System.Drawing.Size(57, 17);
            this.rbtnMoyen.TabIndex = 1;
            this.rbtnMoyen.TabStop = true;
            this.rbtnMoyen.Text = "Moyen";
            this.rbtnMoyen.UseVisualStyleBackColor = true;
            // 
            // rbtnPetit
            // 
            this.rbtnPetit.AutoSize = true;
            this.rbtnPetit.Location = new System.Drawing.Point(30, 19);
            this.rbtnPetit.Name = "rbtnPetit";
            this.rbtnPetit.Size = new System.Drawing.Size(46, 17);
            this.rbtnPetit.TabIndex = 0;
            this.rbtnPetit.TabStop = true;
            this.rbtnPetit.Text = "Petit";
            this.rbtnPetit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxDifficultes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblmdp);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNomUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Labyrinthe - Connexion";
            this.gbxDifficultes.ResumeLayout(false);
            this.gbxDifficultes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNomUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbxDifficultes;
        private System.Windows.Forms.RadioButton rbtnGrand;
        private System.Windows.Forms.RadioButton rbtnMoyen;
        private System.Windows.Forms.RadioButton rbtnPetit;
        private System.Windows.Forms.Button btnCancel;
    }
}