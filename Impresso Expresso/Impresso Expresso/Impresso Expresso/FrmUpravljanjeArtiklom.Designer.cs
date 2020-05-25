namespace Impresso_Expresso
{
    partial class FrmUpravljanjeArtiklom
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
            this.gbUpravljanjeArtiklima = new System.Windows.Forms.GroupBox();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopisArtikala = new System.Windows.Forms.Label();
            this.lblPopisKategorija = new System.Windows.Forms.Label();
            this.lbPopisKategorija = new System.Windows.Forms.ListBox();
            this.kategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrišiArtikl = new System.Windows.Forms.Button();
            this.btnUrediArtikl = new System.Windows.Forms.Button();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPopisArtikala = new System.Windows.Forms.DataGridView();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUpravljanjeArtiklima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUpravljanjeArtiklima
            // 
            this.gbUpravljanjeArtiklima.Controls.Add(this.dgvPopisArtikala);
            this.gbUpravljanjeArtiklima.Controls.Add(this.lblPopisArtikala);
            this.gbUpravljanjeArtiklima.Controls.Add(this.lblPopisKategorija);
            this.gbUpravljanjeArtiklima.Controls.Add(this.lbPopisKategorija);
            this.gbUpravljanjeArtiklima.Controls.Add(this.btnObrišiArtikl);
            this.gbUpravljanjeArtiklima.Controls.Add(this.btnUrediArtikl);
            this.gbUpravljanjeArtiklima.Controls.Add(this.btnDodajArtikl);
            this.gbUpravljanjeArtiklima.ForeColor = System.Drawing.Color.White;
            this.gbUpravljanjeArtiklima.Location = new System.Drawing.Point(12, 86);
            this.gbUpravljanjeArtiklima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUpravljanjeArtiklima.Name = "gbUpravljanjeArtiklima";
            this.gbUpravljanjeArtiklima.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUpravljanjeArtiklima.Size = new System.Drawing.Size(757, 455);
            this.gbUpravljanjeArtiklima.TabIndex = 1;
            this.gbUpravljanjeArtiklima.TabStop = false;
            this.gbUpravljanjeArtiklima.Text = "Upravljanje artiklima";
            // 
            // lblPopisArtikala
            // 
            this.lblPopisArtikala.AutoSize = true;
            this.lblPopisArtikala.Location = new System.Drawing.Point(299, 103);
            this.lblPopisArtikala.Name = "lblPopisArtikala";
            this.lblPopisArtikala.Size = new System.Drawing.Size(97, 17);
            this.lblPopisArtikala.TabIndex = 2;
            this.lblPopisArtikala.Text = "Popis artikala:";
            // 
            // lblPopisKategorija
            // 
            this.lblPopisKategorija.AutoSize = true;
            this.lblPopisKategorija.Location = new System.Drawing.Point(48, 103);
            this.lblPopisKategorija.Name = "lblPopisKategorija";
            this.lblPopisKategorija.Size = new System.Drawing.Size(113, 17);
            this.lblPopisKategorija.TabIndex = 2;
            this.lblPopisKategorija.Text = "Popis kategorija:";
            // 
            // lbPopisKategorija
            // 
            this.lbPopisKategorija.DataSource = this.kategorijeBindingSource;
            this.lbPopisKategorija.DisplayMember = "Naziv";
            this.lbPopisKategorija.FormattingEnabled = true;
            this.lbPopisKategorija.ItemHeight = 16;
            this.lbPopisKategorija.Location = new System.Drawing.Point(51, 133);
            this.lbPopisKategorija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPopisKategorija.Name = "lbPopisKategorija";
            this.lbPopisKategorija.Size = new System.Drawing.Size(183, 292);
            this.lbPopisKategorija.TabIndex = 1;
            this.lbPopisKategorija.ValueMember = "ID";
            this.lbPopisKategorija.SelectedIndexChanged += new System.EventHandler(this.lbPopisKategorija_SelectedIndexChanged);
            // 
            // btnObrišiArtikl
            // 
            this.btnObrišiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrišiArtikl.Location = new System.Drawing.Point(551, 38);
            this.btnObrišiArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrišiArtikl.Name = "btnObrišiArtikl";
            this.btnObrišiArtikl.Size = new System.Drawing.Size(183, 46);
            this.btnObrišiArtikl.TabIndex = 0;
            this.btnObrišiArtikl.Text = "Obriši artikl";
            this.btnObrišiArtikl.UseVisualStyleBackColor = true;
            this.btnObrišiArtikl.Click += new System.EventHandler(this.btnObrišiArtikl_Click);
            // 
            // btnUrediArtikl
            // 
            this.btnUrediArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnUrediArtikl.Location = new System.Drawing.Point(301, 38);
            this.btnUrediArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediArtikl.Name = "btnUrediArtikl";
            this.btnUrediArtikl.Size = new System.Drawing.Size(183, 46);
            this.btnUrediArtikl.TabIndex = 0;
            this.btnUrediArtikl.Text = "Uredi artikl";
            this.btnUrediArtikl.UseVisualStyleBackColor = true;
            this.btnUrediArtikl.Click += new System.EventHandler(this.btnUrediArtikl_Click);
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnDodajArtikl.Location = new System.Drawing.Point(51, 38);
            this.btnDodajArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(183, 46);
            this.btnDodajArtikl.TabIndex = 0;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPopisArtikala
            // 
            this.dgvPopisArtikala.AutoGenerateColumns = false;
            this.dgvPopisArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisArtikala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvPopisArtikala.DataSource = this.artikliBindingSource1;
            this.dgvPopisArtikala.Location = new System.Drawing.Point(301, 133);
            this.dgvPopisArtikala.MultiSelect = false;
            this.dgvPopisArtikala.Name = "dgvPopisArtikala";
            this.dgvPopisArtikala.RowTemplate.Height = 24;
            this.dgvPopisArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisArtikala.Size = new System.Drawing.Size(432, 291);
            this.dgvPopisArtikala.TabIndex = 3;
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataSource = typeof(Impresso_Expresso.Artikli);
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
            this.dataGridViewTextBoxColumn2.Visible = false;
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
            this.dataGridViewTextBoxColumn5.Visible = false;
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
            // FrmUpravljanjeArtiklom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.gbUpravljanjeArtiklima);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUpravljanjeArtiklom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpravljanjeArtiklom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUpravljanjeArtiklom_KeyDown);
            this.gbUpravljanjeArtiklima.ResumeLayout(false);
            this.gbUpravljanjeArtiklima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUpravljanjeArtiklima;
        private System.Windows.Forms.Label lblPopisArtikala;
        private System.Windows.Forms.Label lblPopisKategorija;
        private System.Windows.Forms.Button btnObrišiArtikl;
        private System.Windows.Forms.Button btnUrediArtikl;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.ListBox lbPopisKategorija;
        private System.Windows.Forms.BindingSource kategorijeBindingSource;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeNaSkladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeNarudzbesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkePrimkesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPopisArtikala;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
    }
}