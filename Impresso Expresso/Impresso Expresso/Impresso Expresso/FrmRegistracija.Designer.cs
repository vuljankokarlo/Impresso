namespace Impresso_Expresso
{
    partial class FrmRegistracija
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
            this.pbBaner = new System.Windows.Forms.PictureBox();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.ulogeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblKorime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaner)).BeginInit();
            this.gbRegistracija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBaner
            // 
            this.pbBaner.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pbBaner.Location = new System.Drawing.Point(93, 1);
            this.pbBaner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBaner.Name = "pbBaner";
            this.pbBaner.Size = new System.Drawing.Size(404, 91);
            this.pbBaner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaner.TabIndex = 0;
            this.pbBaner.TabStop = false;
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.btnSpremi);
            this.gbRegistracija.Controls.Add(this.cbUloga);
            this.gbRegistracija.Controls.Add(this.txtTelefon);
            this.gbRegistracija.Controls.Add(this.txtAdresa);
            this.gbRegistracija.Controls.Add(this.txtPosta);
            this.gbRegistracija.Controls.Add(this.txtKorime);
            this.gbRegistracija.Controls.Add(this.txtLozinka);
            this.gbRegistracija.Controls.Add(this.txtPrezime);
            this.gbRegistracija.Controls.Add(this.lblUloga);
            this.gbRegistracija.Controls.Add(this.lblTelefon);
            this.gbRegistracija.Controls.Add(this.lblAdresa);
            this.gbRegistracija.Controls.Add(this.txtIme);
            this.gbRegistracija.Controls.Add(this.lblPosta);
            this.gbRegistracija.Controls.Add(this.lblKorime);
            this.gbRegistracija.Controls.Add(this.lblLozinka);
            this.gbRegistracija.Controls.Add(this.lblPrezime);
            this.gbRegistracija.Controls.Add(this.lbIme);
            this.gbRegistracija.ForeColor = System.Drawing.Color.White;
            this.gbRegistracija.Location = new System.Drawing.Point(107, 97);
            this.gbRegistracija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRegistracija.Size = new System.Drawing.Size(367, 343);
            this.gbRegistracija.TabIndex = 1;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Registracija";
            // 
            // btnSpremi
            // 
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(134, 297);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(143, 25);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cbUloga
            // 
            this.cbUloga.DataSource = this.ulogeBindingSource;
            this.cbUloga.DisplayMember = "Naziv";
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(134, 262);
            this.cbUloga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(144, 21);
            this.cbUloga.TabIndex = 8;
            this.cbUloga.ValueMember = "ID";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(134, 229);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(144, 20);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(134, 158);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(144, 20);
            this.txtAdresa.TabIndex = 5;
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(134, 195);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(144, 20);
            this.txtPosta.TabIndex = 6;
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(134, 91);
            this.txtKorime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(144, 20);
            this.txtKorime.TabIndex = 3;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(134, 124);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(144, 20);
            this.txtLozinka.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(134, 57);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(144, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(75, 262);
            this.lblUloga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(38, 13);
            this.lblUloga.TabIndex = 0;
            this.lblUloga.Text = "Uloga:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(75, 229);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(75, 158);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 0;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(134, 26);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(144, 20);
            this.txtIme.TabIndex = 1;
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Location = new System.Drawing.Point(75, 195);
            this.lblPosta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(37, 13);
            this.lblPosta.TabIndex = 0;
            this.lblPosta.Text = "Pošta:";
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(52, 91);
            this.lblKorime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(78, 13);
            this.lblKorime.TabIndex = 0;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(75, 124);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 0;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(75, 57);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 0;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(75, 26);
            this.lbIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(27, 13);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:";
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.gbRegistracija);
            this.Controls.Add(this.pbBaner);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistracija";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRegistracija_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaner)).EndInit();
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBaner;
        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.BindingSource ulogeBindingSource;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
    }
}