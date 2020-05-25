namespace Impresso_Expresso
{
    partial class FrmObracunBlagajne
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IzvjestajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.gbDnevniIzvještaj = new System.Windows.Forms.GroupBox();
            this.gbNacinPlacanja = new System.Windows.Forms.GroupBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtKartica = new System.Windows.Forms.TextBox();
            this.lblKartica = new System.Windows.Forms.Label();
            this.txtNovcanica = new System.Windows.Forms.TextBox();
            this.lblNovcanica = new System.Windows.Forms.Label();
            this.txtGotovinaUBlagajni = new System.Windows.Forms.TextBox();
            this.lblGotovinaUBlagajni = new System.Windows.Forms.Label();
            this.txtIzradioKonobar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPologUBlagajni = new System.Windows.Forms.TextBox();
            this.lblPolog = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnTransakcije = new System.Windows.Forms.Button();
            this.btnObracunBlagajne = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDnevniIzvještaj.SuspendLayout();
            this.gbNacinPlacanja.SuspendLayout();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(7, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(44, 35);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // gbDnevniIzvještaj
            // 
            this.gbDnevniIzvještaj.Controls.Add(this.gbNacinPlacanja);
            this.gbDnevniIzvještaj.Controls.Add(this.txtGotovinaUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.lblGotovinaUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.txtIzradioKonobar);
            this.gbDnevniIzvještaj.Controls.Add(this.label1);
            this.gbDnevniIzvještaj.Controls.Add(this.txtPologUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.lblPolog);
            this.gbDnevniIzvještaj.Controls.Add(this.txtDatum);
            this.gbDnevniIzvještaj.Controls.Add(this.lblDatum);
            this.gbDnevniIzvještaj.ForeColor = System.Drawing.Color.White;
            this.gbDnevniIzvještaj.Location = new System.Drawing.Point(116, 86);
            this.gbDnevniIzvještaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDnevniIzvještaj.Name = "gbDnevniIzvještaj";
            this.gbDnevniIzvještaj.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDnevniIzvještaj.Size = new System.Drawing.Size(345, 316);
            this.gbDnevniIzvještaj.TabIndex = 3;
            this.gbDnevniIzvještaj.TabStop = false;
            this.gbDnevniIzvještaj.Text = "Dnevni izvještaj";
            // 
            // gbNacinPlacanja
            // 
            this.gbNacinPlacanja.Controls.Add(this.lblIznos);
            this.gbNacinPlacanja.Controls.Add(this.txtKartica);
            this.gbNacinPlacanja.Controls.Add(this.lblKartica);
            this.gbNacinPlacanja.Controls.Add(this.txtNovcanica);
            this.gbNacinPlacanja.Controls.Add(this.lblNovcanica);
            this.gbNacinPlacanja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbNacinPlacanja.Location = new System.Drawing.Point(35, 190);
            this.gbNacinPlacanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNacinPlacanja.Name = "gbNacinPlacanja";
            this.gbNacinPlacanja.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNacinPlacanja.Size = new System.Drawing.Size(279, 94);
            this.gbNacinPlacanja.TabIndex = 4;
            this.gbNacinPlacanja.TabStop = false;
            this.gbNacinPlacanja.Text = "Način plačanja";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(160, 13);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(32, 13);
            this.lblIznos.TabIndex = 4;
            this.lblIznos.Text = "Iznos";
            // 
            // txtKartica
            // 
            this.txtKartica.Location = new System.Drawing.Point(105, 64);
            this.txtKartica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKartica.Name = "txtKartica";
            this.txtKartica.Size = new System.Drawing.Size(146, 20);
            this.txtKartica.TabIndex = 3;
            // 
            // lblKartica
            // 
            this.lblKartica.AutoSize = true;
            this.lblKartica.ForeColor = System.Drawing.Color.White;
            this.lblKartica.Location = new System.Drawing.Point(6, 64);
            this.lblKartica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKartica.Name = "lblKartica";
            this.lblKartica.Size = new System.Drawing.Size(43, 13);
            this.lblKartica.TabIndex = 2;
            this.lblKartica.Text = "Kartica:";
            // 
            // txtNovcanica
            // 
            this.txtNovcanica.Location = new System.Drawing.Point(105, 29);
            this.txtNovcanica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNovcanica.Name = "txtNovcanica";
            this.txtNovcanica.Size = new System.Drawing.Size(146, 20);
            this.txtNovcanica.TabIndex = 3;
            // 
            // lblNovcanica
            // 
            this.lblNovcanica.AutoSize = true;
            this.lblNovcanica.ForeColor = System.Drawing.Color.White;
            this.lblNovcanica.Location = new System.Drawing.Point(6, 29);
            this.lblNovcanica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNovcanica.Name = "lblNovcanica";
            this.lblNovcanica.Size = new System.Drawing.Size(62, 13);
            this.lblNovcanica.TabIndex = 2;
            this.lblNovcanica.Text = "Novčanica:";
            // 
            // txtGotovinaUBlagajni
            // 
            this.txtGotovinaUBlagajni.Location = new System.Drawing.Point(143, 71);
            this.txtGotovinaUBlagajni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGotovinaUBlagajni.Name = "txtGotovinaUBlagajni";
            this.txtGotovinaUBlagajni.Size = new System.Drawing.Size(146, 20);
            this.txtGotovinaUBlagajni.TabIndex = 3;
            // 
            // lblGotovinaUBlagajni
            // 
            this.lblGotovinaUBlagajni.AutoSize = true;
            this.lblGotovinaUBlagajni.ForeColor = System.Drawing.Color.White;
            this.lblGotovinaUBlagajni.Location = new System.Drawing.Point(44, 71);
            this.lblGotovinaUBlagajni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGotovinaUBlagajni.Name = "lblGotovinaUBlagajni";
            this.lblGotovinaUBlagajni.Size = new System.Drawing.Size(101, 13);
            this.lblGotovinaUBlagajni.TabIndex = 2;
            this.lblGotovinaUBlagajni.Text = "Gotovina u blagajni:";
            // 
            // txtIzradioKonobar
            // 
            this.txtIzradioKonobar.Location = new System.Drawing.Point(143, 136);
            this.txtIzradioKonobar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIzradioKonobar.Name = "txtIzradioKonobar";
            this.txtIzradioKonobar.Size = new System.Drawing.Size(146, 20);
            this.txtIzradioKonobar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izradio Konobar";
            // 
            // txtPologUBlagajni
            // 
            this.txtPologUBlagajni.Location = new System.Drawing.Point(143, 103);
            this.txtPologUBlagajni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPologUBlagajni.Name = "txtPologUBlagajni";
            this.txtPologUBlagajni.Size = new System.Drawing.Size(146, 20);
            this.txtPologUBlagajni.TabIndex = 3;
            // 
            // lblPolog
            // 
            this.lblPolog.AutoSize = true;
            this.lblPolog.ForeColor = System.Drawing.Color.White;
            this.lblPolog.Location = new System.Drawing.Point(44, 103);
            this.lblPolog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPolog.Name = "lblPolog";
            this.lblPolog.Size = new System.Drawing.Size(89, 13);
            this.lblPolog.TabIndex = 2;
            this.lblPolog.Text = "Polog u blagajnu:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(143, 35);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(146, 20);
            this.txtDatum.TabIndex = 3;
            // 
            // btnTransakcije
            // 
            this.btnTransakcije.Location = new System.Drawing.Point(489, 320);
            this.btnTransakcije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransakcije.Name = "btnTransakcije";
            this.btnTransakcije.Size = new System.Drawing.Size(71, 34);
            this.btnTransakcije.TabIndex = 4;
            this.btnTransakcije.Text = "Transakcije";
            this.btnTransakcije.UseVisualStyleBackColor = true;
            this.btnTransakcije.Click += new System.EventHandler(this.btnTransakcije_Click);
            // 
            // btnObracunBlagajne
            // 
            this.btnObracunBlagajne.Location = new System.Drawing.Point(489, 369);
            this.btnObracunBlagajne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObracunBlagajne.Name = "btnObracunBlagajne";
            this.btnObracunBlagajne.Size = new System.Drawing.Size(71, 34);
            this.btnObracunBlagajne.TabIndex = 4;
            this.btnObracunBlagajne.Text = "Obračun";
            this.btnObracunBlagajne.UseVisualStyleBackColor = true;
            this.btnObracunBlagajne.Click += new System.EventHandler(this.btnObracunBlagajne_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetIzvjestaja";
            reportDataSource1.Value = this.IzvjestajiBindingSource;
            reportDataSource2.Name = "DataSetKorisnici";
            reportDataSource2.Value = this.korisniciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Impresso_Expresso.DnevniIzvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 427);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(532, 317);
            this.reportViewer1.TabIndex = 5;
            // 
            // FrmObracunBlagajne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(586, 609);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnObracunBlagajne);
            this.Controls.Add(this.btnTransakcije);
            this.Controls.Add(this.gbDnevniIzvještaj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmObracunBlagajne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmObracunBlagajne";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmObracunBlagajne_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDnevniIzvještaj.ResumeLayout(false);
            this.gbDnevniIzvještaj.PerformLayout();
            this.gbNacinPlacanja.ResumeLayout(false);
            this.gbNacinPlacanja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox gbDnevniIzvještaj;
        private System.Windows.Forms.GroupBox gbNacinPlacanja;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox txtKartica;
        private System.Windows.Forms.Label lblKartica;
        private System.Windows.Forms.TextBox txtNovcanica;
        private System.Windows.Forms.Label lblNovcanica;
        private System.Windows.Forms.TextBox txtPologUBlagajni;
        private System.Windows.Forms.Label lblPolog;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnTransakcije;
        private System.Windows.Forms.Button btnObracunBlagajne;
        private System.Windows.Forms.TextBox txtGotovinaUBlagajni;
        private System.Windows.Forms.Label lblGotovinaUBlagajni;
        private System.Windows.Forms.TextBox txtIzradioKonobar;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IzvjestajiBindingSource;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
    }
}