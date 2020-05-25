using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    /// <summary>
    /// <author>Rene Maruševec</author>
    /// </summary>
    public partial class FrmUnosArtikla : Form
    {
        Entities db = new Entities();
        int idOdabranogArtikla = 0;
        public FrmUnosArtikla()
        {
            InitializeComponent();
            kategorijeBindingSource.DataSource = db.Kategorijes.ToList();
        }
        public FrmUnosArtikla(int ID)
        {
            InitializeComponent();
            idOdabranogArtikla = ID;
            PopunjavanjeElemenataForme();
            this.gbUnosArtikla.Text = "Ažuriranje artikla";

        }
        #region Popunjavanje Elemenata
        /// <summary>
        /// Popunjavanje elemenata forme za ažuriranje artikala
        /// </summary>
        private void PopunjavanjeElemenataForme()
        {
            kategorijeBindingSource.DataSource = db.Kategorijes.ToList();
            Artikli artikli = db.Artiklis.FirstOrDefault(s => s.ID == idOdabranogArtikla);
            if (artikli != null)
            {
                txtNazivArtikla.Text = artikli.Naziv;
                txtCijenaArtikla.Text = artikli.Cijena.ToString();
                cbKategorijaArtikla.SelectedValue = int.Parse(artikli.KategorijaID.ToString());
            }
            else
            {
                MessageBox.Show("Greška kod slanja odabranog artikla!", "Pogreška!", MessageBoxButtons.OK);
            }
        }
        #endregion

        /// <summary>
        /// Funkcionalnost unosa ili ažuriranje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiArtikl_Click(object sender, EventArgs e)
        {

            if (idOdabranogArtikla == 0)
            {
                if (txtCijenaArtikla.Text != "" && txtNazivArtikla.Text != "" && cbKategorijaArtikla.SelectedItem != null)
                {
                    
                    Artikli artikli = new Artikli();
                    artikli.Naziv = txtNazivArtikla.Text;
                    decimal cijena = decimal.Parse(txtCijenaArtikla.Text);
                    artikli.Cijena = decimal.Parse(cijena.ToString("#.##"));
                    artikli.KategorijaID = int.Parse(cbKategorijaArtikla.SelectedValue.ToString());
                    artikli.StanjeNaSkladistu = 0;
                    db.Artiklis.Add(artikli);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Popunite sve podatke!", "Pogreška!", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (txtCijenaArtikla.Text != "" && txtNazivArtikla.Text != "" && cbKategorijaArtikla.SelectedItem != null)
                {
                    var artikl = db.Artiklis.FirstOrDefault(s => s.ID == idOdabranogArtikla);
                    artikl.Naziv = txtNazivArtikla.Text;
                    decimal cijena = decimal.Parse(txtCijenaArtikla.Text);
                    artikl.Cijena = decimal.Parse(cijena.ToString("#.##"));
                    artikl.KategorijaID = int.Parse(cbKategorijaArtikla.SelectedValue.ToString());
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Popunite sve podatke!", "Pogreška!", MessageBoxButtons.OK);
                }
            }

        }
        /// <summary>
        /// Zaštita unosa cijene kao numeric(18,2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCijenaArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUnosArtikla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(10);
            }
        }
    }
}
