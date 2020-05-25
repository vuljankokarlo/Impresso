namespace Impresso_Expresso
{
    partial class FrmUnosArtikla
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUnosArtikla = new System.Windows.Forms.GroupBox();
            this.btnSpremiArtikl = new System.Windows.Forms.Button();
            this.cbKategorijaArtikla = new System.Windows.Forms.ComboBox();
            this.kategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijenaArtikla = new System.Windows.Forms.TextBox();
            this.lblCijenaArtikla = new System.Windows.Forms.Label();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUnosArtikla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(116, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbUnosArtikla
            // 
            this.gbUnosArtikla.Controls.Add(this.btnSpremiArtikl);
            this.gbUnosArtikla.Controls.Add(this.cbKategorijaArtikla);
            this.gbUnosArtikla.Controls.Add(this.label3);
            this.gbUnosArtikla.Controls.Add(this.txtCijenaArtikla);
            this.gbUnosArtikla.Controls.Add(this.lblCijenaArtikla);
            this.gbUnosArtikla.Controls.Add(this.txtNazivArtikla);
            this.gbUnosArtikla.Controls.Add(this.lblNazivArtikla);
            this.gbUnosArtikla.ForeColor = System.Drawing.Color.White;
            this.gbUnosArtikla.Location = new System.Drawing.Point(116, 101);
            this.gbUnosArtikla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUnosArtikla.Name = "gbUnosArtikla";
            this.gbUnosArtikla.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUnosArtikla.Size = new System.Drawing.Size(345, 202);
            this.gbUnosArtikla.TabIndex = 1;
            this.gbUnosArtikla.TabStop = false;
            this.gbUnosArtikla.Text = "Unos artikla:";
            // 
            // btnSpremiArtikl
            // 
            this.btnSpremiArtikl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSpremiArtikl.Location = new System.Drawing.Point(138, 150);
            this.btnSpremiArtikl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiArtikl.Name = "btnSpremiArtikl";
            this.btnSpremiArtikl.Size = new System.Drawing.Size(120, 25);
            this.btnSpremiArtikl.TabIndex = 4;
            this.btnSpremiArtikl.Text = "Spremi";
            this.btnSpremiArtikl.UseVisualStyleBackColor = true;
            this.btnSpremiArtikl.Click += new System.EventHandler(this.btnSpremiArtikl_Click);
            // 
            // cbKategorijaArtikla
            // 
            this.cbKategorijaArtikla.DataSource = this.kategorijeBindingSource;
            this.cbKategorijaArtikla.DisplayMember = "Naziv";
            this.cbKategorijaArtikla.FormattingEnabled = true;
            this.cbKategorijaArtikla.Location = new System.Drawing.Point(137, 110);
            this.cbKategorijaArtikla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKategorijaArtikla.Name = "cbKategorijaArtikla";
            this.cbKategorijaArtikla.Size = new System.Drawing.Size(122, 21);
            this.cbKategorijaArtikla.TabIndex = 3;
            this.cbKategorijaArtikla.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategorija:";
            // 
            // txtCijenaArtikla
            // 
            this.txtCijenaArtikla.Location = new System.Drawing.Point(137, 72);
            this.txtCijenaArtikla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCijenaArtikla.Name = "txtCijenaArtikla";
            this.txtCijenaArtikla.Size = new System.Drawing.Size(122, 20);
            this.txtCijenaArtikla.TabIndex = 2;
            this.txtCijenaArtikla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCijenaArtikla_KeyPress);
            // 
            // lblCijenaArtikla
            // 
            this.lblCijenaArtikla.AutoSize = true;
            this.lblCijenaArtikla.Location = new System.Drawing.Point(64, 72);
            this.lblCijenaArtikla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCijenaArtikla.Name = "lblCijenaArtikla";
            this.lblCijenaArtikla.Size = new System.Drawing.Size(39, 13);
            this.lblCijenaArtikla.TabIndex = 0;
            this.lblCijenaArtikla.Text = "Cijena:";
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(137, 32);
            this.txtNazivArtikla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(122, 20);
            this.txtNazivArtikla.TabIndex = 1;
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(64, 32);
            this.lblNazivArtikla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(37, 13);
            this.lblNazivArtikla.TabIndex = 0;
            this.lblNazivArtikla.Text = "Naziv:";
            // 
            // FrmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.gbUnosArtikla);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUnosArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUnosArtikla";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUnosArtikla_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUnosArtikla.ResumeLayout(false);
            this.gbUnosArtikla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUnosArtikla;
        private System.Windows.Forms.Button btnSpremiArtikl;
        private System.Windows.Forms.ComboBox cbKategorijaArtikla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijenaArtikla;
        private System.Windows.Forms.Label lblCijenaArtikla;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.BindingSource kategorijeBindingSource;
    }
}