namespace TpErgonogaf
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.btnAnnuler2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(95, 45);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(56, 91);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(78, 13);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de Passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(169, 42);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(189, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(169, 88);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(189, 20);
            this.txtMdp.TabIndex = 3;
            // 
            // btnOK2
            // 
            this.btnOK2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK2.Location = new System.Drawing.Point(98, 144);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(75, 23);
            this.btnOK2.TabIndex = 4;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            this.btnOK2.Enter += new System.EventHandler(this.btnOK2_Click);
            // 
            // btnAnnuler2
            // 
            this.btnAnnuler2.Location = new System.Drawing.Point(222, 144);
            this.btnAnnuler2.Name = "btnAnnuler2";
            this.btnAnnuler2.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler2.TabIndex = 5;
            this.btnAnnuler2.Text = "Annuler";
            this.btnAnnuler2.UseVisualStyleBackColor = true;
            this.btnAnnuler2.Click += new System.EventHandler(this.btnAnnuler2_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 206);
            this.Controls.Add(this.btnAnnuler2);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Button btnAnnuler2;
    }
}