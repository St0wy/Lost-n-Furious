namespace WFEnvoisServeur
{
    partial class frmEnvoisServeur
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxRecieve = new System.Windows.Forms.TextBox();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 135);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(12, 25);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(127, 20);
            this.tbxIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "port";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(12, 66);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(127, 20);
            this.tbxPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "message";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(12, 109);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(127, 20);
            this.tbxMessage.TabIndex = 5;
            // 
            // tbxRecieve
            // 
            this.tbxRecieve.Location = new System.Drawing.Point(145, 25);
            this.tbxRecieve.Multiline = true;
            this.tbxRecieve.Name = "tbxRecieve";
            this.tbxRecieve.Size = new System.Drawing.Size(127, 133);
            this.tbxRecieve.TabIndex = 7;
            // 
            // btnSTOP
            // 
            this.btnSTOP.Location = new System.Drawing.Point(12, 164);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(127, 92);
            this.btnSTOP.TabIndex = 8;
            this.btnSTOP.Text = "STOPI";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.BtnSTOP_Click);
            // 
            // frmEnvoisServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 340);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.tbxRecieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIp);
            this.Controls.Add(this.btnSend);
            this.Name = "frmEnvoisServeur";
            this.Text = "Envois serveur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEnvoisServeur_FormClosed);
            this.Load += new System.EventHandler(this.FrmEnvoisServeur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxRecieve;
        private System.Windows.Forms.Button btnSTOP;
    }
}

