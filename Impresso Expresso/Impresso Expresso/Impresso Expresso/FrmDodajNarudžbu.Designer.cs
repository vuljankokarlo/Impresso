namespace Impresso_Expresso
{
    partial class FrmDodajNarudžbu
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
            this.gbArtikli = new System.Windows.Forms.GroupBox();
            this.dgvArtikliZaNarudzbu = new System.Windows.Forms.DataGridView();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.tbKolicinaArtikla = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.pbOduzmi = new System.Windows.Forms.PictureBox();
            this.pbDodaj = new System.Windows.Forms.PictureBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKolicinaArtikla = new System.Windows.Forms.Label();
            this.lblKategorijaArtikla = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliZaNarudzbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduzmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArtikli
            // 
            this.gbArtikli.Controls.Add(this.dgvArtikliZaNarudzbu);
            this.gbArtikli.Controls.Add(this.btnDodajArtikl);
            this.gbArtikli.Controls.Add(this.tbKolicinaArtikla);
            this.gbArtikli.Controls.Add(this.btnPotvrdi);
            this.gbArtikli.Controls.Add(this.pbOduzmi);
            this.gbArtikli.Controls.Add(this.pbDodaj);
            this.gbArtikli.Controls.Add(this.cbKategorija);
            this.gbArtikli.Controls.Add(this.lblKolicinaArtikla);
            this.gbArtikli.Controls.Add(this.lblKategorijaArtikla);
            this.gbArtikli.Location = new System.Drawing.Point(207, 212);
            this.gbArtikli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbArtikli.Name = "gbArtikli";
            this.gbArtikli.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbArtikli.Size = new System.Drawing.Size(640, 384);
            this.gbArtikli.TabIndex = 0;
            this.gbArtikli.TabStop = false;
            // 
            // dgvArtikliZaNarudzbu
            // 
            this.dgvArtikliZaNarudzbu.AllowUserToAddRows = false;
            this.dgvArtikliZaNarudzbu.AllowUserToDeleteRows = false;
            this.dgvArtikliZaNarudzbu.AllowUserToResizeColumns = false;
            this.dgvArtikliZaNarudzbu.AllowUserToResizeRows = false;
            this.dgvArtikliZaNarudzbu.AutoGenerateColumns = false;
            this.dgvArtikliZaNarudzbu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliZaNarudzbu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvArtikliZaNarudzbu.DataSource = this.artikliBindingSource;
            this.dgvArtikliZaNarudzbu.Location = new System.Drawing.Point(8, 202);
            this.dgvArtikliZaNarudzbu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArtikliZaNarudzbu.MultiSelect = false;
            this.dgvArtikliZaNarudzbu.Name = "dgvArtikliZaNarudzbu";
            this.dgvArtikliZaNarudzbu.RowHeadersVisible = false;
            this.dgvArtikliZaNarudzbu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikliZaNarudzbu.Size = new System.Drawing.Size(624, 175);
            this.dgvArtikliZaNarudzbu.TabIndex = 8;
            this.dgvArtikliZaNarudzbu.SelectionChanged += new System.EventHandler(this.dgvArtikliZaNarudzbu_SelectionChanged);
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(507, 150);
            this.btnDodajArtikl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(125, 44);
            this.btnDodajArtikl.TabIndex = 7;
            this.btnDodajArtikl.Text = "Dodaj Artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // tbKolicinaArtikla
            // 
            this.tbKolicinaArtikla.Enabled = false;
            this.tbKolicinaArtikla.Location = new System.Drawing.Point(193, 108);
            this.tbKolicinaArtikla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKolicinaArtikla.Name = "tbKolicinaArtikla";
            this.tbKolicinaArtikla.Size = new System.Drawing.Size(171, 22);
            this.tbKolicinaArtikla.TabIndex = 6;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(373, 150);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(125, 44);
            this.btnPotvrdi.TabIndex = 3;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // pbOduzmi
            // 
            this.pbOduzmi.Image = global::Impresso_Expresso.Properties.Resources.makni;
            this.pbOduzmi.Location = new System.Drawing.Point(373, 23);
            this.pbOduzmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbOduzmi.Name = "pbOduzmi";
            this.pbOduzmi.Size = new System.Drawing.Size(125, 110);
            this.pbOduzmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOduzmi.TabIndex = 2;
            this.pbOduzmi.TabStop = false;
            this.pbOduzmi.Click += new System.EventHandler(this.pbOduzmi_Click);
            // 
            // pbDodaj
            // 
            this.pbDodaj.Image = global::Impresso_Expresso.Properties.Resources.dodaj;
            this.pbDodaj.Location = new System.Drawing.Point(507, 23);
            this.pbDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDodaj.Name = "pbDodaj";
            this.pbDodaj.Size = new System.Drawing.Size(125, 110);
            this.pbDodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDodaj.TabIndex = 2;
            this.pbDodaj.TabStop = false;
            this.pbDodaj.Click += new System.EventHandler(this.pbDodaj_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(193, 23);
            this.cbKategorija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(171, 24);
            this.cbKategorija.TabIndex = 1;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // lblKolicinaArtikla
            // 
            this.lblKolicinaArtikla.AutoSize = true;
            this.lblKolicinaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicinaArtikla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblKolicinaArtikla.Location = new System.Drawing.Point(79, 108);
            this.lblKolicinaArtikla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicinaArtikla.Name = "lblKolicinaArtikla";
            this.lblKolicinaArtikla.Size = new System.Drawing.Size(81, 25);
            this.lblKolicinaArtikla.TabIndex = 0;
            this.lblKolicinaArtikla.Text = "Kolicina";
            // 
            // lblKategorijaArtikla
            // 
            this.lblKategorijaArtikla.AutoSize = true;
            this.lblKategorijaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorijaArtikla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblKategorijaArtikla.Location = new System.Drawing.Point(79, 25);
            this.lblKategorijaArtikla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorijaArtikla.Name = "lblKategorijaArtikla";
            this.lblKategorijaArtikla.Size = new System.Drawing.Size(100, 25);
            this.lblKategorijaArtikla.TabIndex = 0;
            this.lblKategorijaArtikla.Text = "Kategorija";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pbLogo.Location = new System.Drawing.Point(207, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(640, 123);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(Impresso_Expresso.Artikli);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KategorijaID";
            this.dataGridViewTextBoxColumn2.HeaderText = "KategorijaID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn3.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StanjeNaSkladistu";
            this.dataGridViewTextBoxColumn5.HeaderText = "StanjeNaSkladistu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Kategorije";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kategorije";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StavkeNarudzbes";
            this.dataGridViewTextBoxColumn7.HeaderText = "StavkeNarudzbes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StavkePrimkes";
            this.dataGridViewTextBoxColumn8.HeaderText = "StavkePrimkes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // FrmDodajNarudžbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbArtikli);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDodajNarudžbu";
            this.Text = "FrmDodajNarudžbu";
            this.Load += new System.EventHandler(this.FrmDodajNarudžbu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodajNarudžbu_KeyDown);
            this.gbArtikli.ResumeLayout(false);
            this.gbArtikli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliZaNarudzbu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduzmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArtikli;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.PictureBox pbOduzmi;
        private System.Windows.Forms.PictureBox pbDodaj;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKolicinaArtikla;
        private System.Windows.Forms.Label lblKategorijaArtikla;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox tbKolicinaArtikla;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.DataGridView dgvArtikliZaNarudzbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeNaSkladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeNarudzbesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkePrimkesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource artikliBindingSource;
    }
}