namespace Impresso_Expresso
{
    partial class FrmPrijava
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
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.gbPrijava.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(148, 34);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(121, 20);
            this.txtKorIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(148, 76);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(121, 20);
            this.txtLozinka.TabIndex = 0;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(49, 76);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(41, 34);
            this.lblKorime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(78, 13);
            this.lblKorime.TabIndex = 2;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // gbPrijava
            // 
            this.gbPrijava.Controls.Add(this.btnPrijava);
            this.gbPrijava.Controls.Add(this.txtKorIme);
            this.gbPrijava.Controls.Add(this.lblKorime);
            this.gbPrijava.Controls.Add(this.txtLozinka);
            this.gbPrijava.Controls.Add(this.lblLozinka);
            this.gbPrijava.ForeColor = System.Drawing.Color.White;
            this.gbPrijava.Location = new System.Drawing.Point(147, 154);
            this.gbPrijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPrijava.Name = "gbPrijava";
            this.gbPrijava.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPrijava.Size = new System.Drawing.Size(304, 175);
            this.gbPrijava.TabIndex = 3;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijava";
            // 
            // btnPrijava
            // 
            this.btnPrijava.ForeColor = System.Drawing.Color.Black;
            this.btnPrijava.Location = new System.Drawing.Point(44, 114);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(224, 27);
            this.btnPrijava.TabIndex = 3;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.gbPrijava);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrijava";
            this.Load += new System.EventHandler(this.FrmPrijava_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrijava_KeyDown);
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbPrijava;
        private System.Windows.Forms.Button btnPrijava;
    }
}