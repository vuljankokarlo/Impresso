namespace Impresso_Expresso
{
    partial class FrmRacun
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
            this.spStavkeRacuna_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.placanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRacun = new System.Windows.Forms.GroupBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spStavkeRacunaResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spStavkeRacuna_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbRacun.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStavkeRacunaResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spStavkeRacuna_ResultBindingSource
            // 
            this.spStavkeRacuna_ResultBindingSource.DataSource = typeof(Impresso_Expresso.spStavkeRacuna_Result);
            // 
            // btnIspis
            // 
            this.btnIspis.ForeColor = System.Drawing.Color.Black;
            this.btnIspis.Location = new System.Drawing.Point(414, 282);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 0;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(309, 248);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(74, 13);
            this.lblIznos.TabIndex = 1;
            this.lblIznos.Text = "Ukupni iznos: ";
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(47, 248);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(84, 13);
            this.lblNacinPlacanja.TabIndex = 2;
            this.lblNacinPlacanja.Text = "Način plaćanja: ";
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.DataSource = this.placanjaBindingSource;
            this.cbNacinPlacanja.DisplayMember = "Naziv";
            this.cbNacinPlacanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Location = new System.Drawing.Point(153, 245);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.cbNacinPlacanja.TabIndex = 3;
            this.cbNacinPlacanja.ValueMember = "ID";
            // 
            // placanjaBindingSource
            // 
            this.placanjaBindingSource.DataSource = typeof(Impresso_Expresso.Placanja);
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUkupniIznos.Location = new System.Drawing.Point(389, 245);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.ReadOnly = true;
            this.txtUkupniIznos.Size = new System.Drawing.Size(100, 20);
            this.txtUkupniIznos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(78, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gbRacun
            // 
            this.gbRacun.Controls.Add(this.txtPDV);
            this.gbRacun.Controls.Add(this.label1);
            this.gbRacun.Controls.Add(this.panel1);
            this.gbRacun.Controls.Add(this.txtUkupniIznos);
            this.gbRacun.Controls.Add(this.cbNacinPlacanja);
            this.gbRacun.Controls.Add(this.lblNacinPlacanja);
            this.gbRacun.Controls.Add(this.lblIznos);
            this.gbRacun.Controls.Add(this.btnIspis);
            this.gbRacun.ForeColor = System.Drawing.Color.White;
            this.gbRacun.Location = new System.Drawing.Point(28, 139);
            this.gbRacun.Name = "gbRacun";
            this.gbRacun.Size = new System.Drawing.Size(520, 325);
            this.gbRacun.TabIndex = 8;
            this.gbRacun.TabStop = false;
            this.gbRacun.Text = "Račun";
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(389, 205);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(100, 20);
            this.txtPDV.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PDV 25%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStavkeRacuna);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(38, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 166);
            this.panel1.TabIndex = 10;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(12, 7);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(439, 150);
            this.dgvStavkeRacuna.TabIndex = 9;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spStavkeRacuna_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Impresso_Expresso.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 480);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(520, 310);
            this.reportViewer1.TabIndex = 9;
            // 
            // spStavkeRacunaResultBindingSource
            // 
            this.spStavkeRacunaResultBindingSource.DataSource = typeof(Impresso_Expresso.spStavkeRacuna_Result);
            // 
            // FrmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(579, 749);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbRacun);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "FrmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.FrmRacun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRacun_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spStavkeRacuna_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbRacun.ResumeLayout(false);
            this.gbRacun.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStavkeRacunaResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbRacun;
        private System.Windows.Forms.BindingSource placanjaBindingSource;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spStavkeRacuna_ResultBindingSource;
        private System.Windows.Forms.BindingSource spStavkeRacunaResultBindingSource;
    }
}