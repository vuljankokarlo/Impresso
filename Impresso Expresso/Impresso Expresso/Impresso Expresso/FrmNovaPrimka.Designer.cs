namespace Impresso_Expresso
{
    partial class FrmNovaPrimka
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
            this.gbNovaPrimka = new System.Windows.Forms.GroupBox();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.btnDodajDobavljaca = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpPrimke = new System.Windows.Forms.DateTimePicker();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblDobavljač = new System.Windows.Forms.Label();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.cbArtikl = new System.Windows.Forms.ComboBox();
            this.dgvStavkePrimki = new System.Windows.Forms.DataGridView();
            this.primkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbStavke = new System.Windows.Forms.GroupBox();
            this.btnObrisiStavkuPrimke = new System.Windows.Forms.Button();
            this.pDgv = new System.Windows.Forms.Panel();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbNovaPrimka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkePrimkeBindingSource)).BeginInit();
            this.gbStavke.SuspendLayout();
            this.pDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNovaPrimka
            // 
            this.gbNovaPrimka.Controls.Add(this.txtKorisnik);
            this.gbNovaPrimka.Controls.Add(this.btnDodajDobavljaca);
            this.gbNovaPrimka.Controls.Add(this.lblDatum);
            this.gbNovaPrimka.Controls.Add(this.dtpPrimke);
            this.gbNovaPrimka.Controls.Add(this.lblKorisnik);
            this.gbNovaPrimka.Controls.Add(this.lblDobavljač);
            this.gbNovaPrimka.Controls.Add(this.cbDobavljac);
            this.gbNovaPrimka.ForeColor = System.Drawing.Color.White;
            this.gbNovaPrimka.Location = new System.Drawing.Point(43, 149);
            this.gbNovaPrimka.Name = "gbNovaPrimka";
            this.gbNovaPrimka.Size = new System.Drawing.Size(705, 126);
            this.gbNovaPrimka.TabIndex = 1;
            this.gbNovaPrimka.TabStop = false;
            this.gbNovaPrimka.Text = "Nova primka";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(273, 47);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnik.TabIndex = 7;
            // 
            // btnDodajDobavljaca
            // 
            this.btnDodajDobavljaca.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDobavljaca.Location = new System.Drawing.Point(57, 84);
            this.btnDodajDobavljaca.Name = "btnDodajDobavljaca";
            this.btnDodajDobavljaca.Size = new System.Drawing.Size(121, 23);
            this.btnDodajDobavljaca.TabIndex = 6;
            this.btnDodajDobavljaca.Text = "Dodaj dobavljača";
            this.btnDodajDobavljaca.UseVisualStyleBackColor = true;
            this.btnDodajDobavljaca.Click += new System.EventHandler(this.btnDodajDobavljaca_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(465, 24);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum";
            // 
            // dtpPrimke
            // 
            this.dtpPrimke.Location = new System.Drawing.Point(468, 48);
            this.dtpPrimke.Name = "dtpPrimke";
            this.dtpPrimke.Size = new System.Drawing.Size(200, 20);
            this.dtpPrimke.TabIndex = 4;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(270, 24);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 3;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // lblDobavljač
            // 
            this.lblDobavljač.AutoSize = true;
            this.lblDobavljač.Location = new System.Drawing.Point(54, 24);
            this.lblDobavljač.Name = "lblDobavljač";
            this.lblDobavljač.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljač.TabIndex = 2;
            this.lblDobavljač.Text = "Dobavljac";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(57, 47);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(121, 21);
            this.cbDobavljac.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(208, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPohrani
            // 
            this.btnPohrani.ForeColor = System.Drawing.Color.Black;
            this.btnPohrani.Location = new System.Drawing.Point(165, 121);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(95, 23);
            this.btnPohrani.TabIndex = 4;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(139, 65);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(120, 20);
            this.txtKolicina.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(25, 65);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 2;
            this.lblKolicina.Text = "Količina";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.ForeColor = System.Drawing.Color.White;
            this.lblArtikl.Location = new System.Drawing.Point(25, 26);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(30, 13);
            this.lblArtikl.TabIndex = 1;
            this.lblArtikl.Text = "Artikl";
            // 
            // cbArtikl
            // 
            this.cbArtikl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArtikl.FormattingEnabled = true;
            this.cbArtikl.Location = new System.Drawing.Point(139, 23);
            this.cbArtikl.Name = "cbArtikl";
            this.cbArtikl.Size = new System.Drawing.Size(121, 21);
            this.cbArtikl.TabIndex = 0;
            // 
            // dgvStavkePrimki
            // 
            this.dgvStavkePrimki.AutoGenerateColumns = false;
            this.dgvStavkePrimki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.primkaIDDataGridViewTextBoxColumn,
            this.artiklIDDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn,
            this.primkeDataGridViewTextBoxColumn});
            this.dgvStavkePrimki.DataSource = this.stavkePrimkeBindingSource;
            this.dgvStavkePrimki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavkePrimki.Location = new System.Drawing.Point(0, 0);
            this.dgvStavkePrimki.Name = "dgvStavkePrimki";
            this.dgvStavkePrimki.Size = new System.Drawing.Size(345, 158);
            this.dgvStavkePrimki.TabIndex = 9;
            this.dgvStavkePrimki.SelectionChanged += new System.EventHandler(this.dgvStavkePrimki_SelectionChanged);
            // 
            // primkaIDDataGridViewTextBoxColumn
            // 
            this.primkaIDDataGridViewTextBoxColumn.DataPropertyName = "PrimkaID";
            this.primkaIDDataGridViewTextBoxColumn.HeaderText = "PrimkaID";
            this.primkaIDDataGridViewTextBoxColumn.Name = "primkaIDDataGridViewTextBoxColumn";
            // 
            // artiklIDDataGridViewTextBoxColumn
            // 
            this.artiklIDDataGridViewTextBoxColumn.DataPropertyName = "ArtiklID";
            this.artiklIDDataGridViewTextBoxColumn.HeaderText = "ArtiklID";
            this.artiklIDDataGridViewTextBoxColumn.Name = "artiklIDDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // artikliDataGridViewTextBoxColumn
            // 
            this.artikliDataGridViewTextBoxColumn.DataPropertyName = "Artikli";
            this.artikliDataGridViewTextBoxColumn.HeaderText = "Artikli";
            this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
            this.artikliDataGridViewTextBoxColumn.Visible = false;
            // 
            // primkeDataGridViewTextBoxColumn
            // 
            this.primkeDataGridViewTextBoxColumn.DataPropertyName = "Primke";
            this.primkeDataGridViewTextBoxColumn.HeaderText = "Primke";
            this.primkeDataGridViewTextBoxColumn.Name = "primkeDataGridViewTextBoxColumn";
            this.primkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkePrimkeBindingSource
            // 
            this.stavkePrimkeBindingSource.DataSource = typeof(Impresso_Expresso.StavkePrimke);
            // 
            // gbStavke
            // 
            this.gbStavke.Controls.Add(this.btnObrisiStavkuPrimke);
            this.gbStavke.Controls.Add(this.lblKolicina);
            this.gbStavke.Controls.Add(this.cbArtikl);
            this.gbStavke.Controls.Add(this.lblArtikl);
            this.gbStavke.Controls.Add(this.btnPohrani);
            this.gbStavke.Controls.Add(this.txtKolicina);
            this.gbStavke.ForeColor = System.Drawing.Color.White;
            this.gbStavke.Location = new System.Drawing.Point(43, 288);
            this.gbStavke.Name = "gbStavke";
            this.gbStavke.Size = new System.Drawing.Size(277, 159);
            this.gbStavke.TabIndex = 10;
            this.gbStavke.TabStop = false;
            this.gbStavke.Text = "Nove stavke";
            // 
            // btnObrisiStavkuPrimke
            // 
            this.btnObrisiStavkuPrimke.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiStavkuPrimke.Location = new System.Drawing.Point(28, 121);
            this.btnObrisiStavkuPrimke.Name = "btnObrisiStavkuPrimke";
            this.btnObrisiStavkuPrimke.Size = new System.Drawing.Size(81, 23);
            this.btnObrisiStavkuPrimke.TabIndex = 5;
            this.btnObrisiStavkuPrimke.Text = "Obriši stavku";
            this.btnObrisiStavkuPrimke.UseVisualStyleBackColor = true;
            this.btnObrisiStavkuPrimke.Click += new System.EventHandler(this.btnObrisiStavkuPrimke_Click);
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.dgvStavkePrimki);
            this.pDgv.ForeColor = System.Drawing.Color.Black;
            this.pDgv.Location = new System.Drawing.Point(403, 289);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(345, 158);
            this.pDgv.TabIndex = 11;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(Impresso_Expresso.Korisnici);
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataSource = typeof(Impresso_Expresso.Dobavljaci);
            // 
            // FrmNovaPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(793, 473);
            this.Controls.Add(this.pDgv);
            this.Controls.Add(this.gbStavke);
            this.Controls.Add(this.gbNovaPrimka);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "FrmNovaPrimka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi primku";
            this.Load += new System.EventHandler(this.FrmNovaPrimka_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNovaPrimka_KeyDown);
            this.gbNovaPrimka.ResumeLayout(false);
            this.gbNovaPrimka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkePrimkeBindingSource)).EndInit();
            this.gbStavke.ResumeLayout(false);
            this.gbStavke.PerformLayout();
            this.pDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbNovaPrimka;
        private System.Windows.Forms.DateTimePicker dtpPrimke;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblDobavljač;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.ComboBox cbArtikl;
        private System.Windows.Forms.DataGridView dgvStavkePrimki;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkePrimkeBindingSource;
        private System.Windows.Forms.GroupBox gbStavke;
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnObrisiStavkuPrimke;
        private System.Windows.Forms.Button btnDodajDobavljaca;
        private System.Windows.Forms.TextBox txtKorisnik;
    }
}