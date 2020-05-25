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
    public partial class FrmUpravljanjeArtiklom : Form
    {
        Entities db = new Entities();
        public FrmUpravljanjeArtiklom()
        {
            InitializeComponent();
            this.dgvPopisArtikala.DefaultCellStyle.ForeColor = Color.Black;
            kategorijeBindingSource.DataSource = db.Kategorijes.ToList();
            OsvjeziArtikle();
        }
        #region Unos
        /// <summary>
        /// Unos novog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmUnosArtikla formaUnosArtikla = new FrmUnosArtikla();
            formaUnosArtikla.ShowDialog();
            OsvjeziArtikle();
        }
        #endregion

        #region Ažuriranje
        /// <summary>
        /// Funkcionalnost ažuriranje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrediArtikl_Click(object sender, EventArgs e)
        {
            int odabraniArtikl = int.Parse(this.dgvPopisArtikala.SelectedRows[0].Cells[0].Value.ToString());
            if (odabraniArtikl != 0)
            {
                FrmUnosArtikla formaUnosArtikla = new FrmUnosArtikla(odabraniArtikl);
                formaUnosArtikla.ShowDialog();
                OsvjeziArtikle();
            }
        }
        #endregion

        #region Brisanje
        /// <summary>
        /// Brisanje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrišiArtikl_Click(object sender, EventArgs e)
        {
            int odabraniArtikl = int.Parse(this.dgvPopisArtikala.SelectedRows[0].Cells[0].Value.ToString());
            if (odabraniArtikl != 0)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati artikl?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    List<StavkeNarudzbe> stavkeNarudzbe = db.StavkeNarudzbes.Where(s => s.ArtiklID == odabraniArtikl).ToList();
                    List<StavkePrimke> stavkePrimke = db.StavkePrimkes.Where(s => s.ArtiklID == odabraniArtikl).ToList();
                    Artikli artikl = db.Artiklis.FirstOrDefault(s => s.ID == odabraniArtikl);

                    if (stavkePrimke.Count == 0 && stavkeNarudzbe.Count == 0)
                    {
                        db.Artiklis.Remove(artikl);
                        db.SaveChanges();
                        OsvjeziArtikle();
                    }
                    else
                    {
                        MessageBox.Show("Nije moguće brisati artikle koji su sadržani u stavkama primke i narudžbe!", "Upozorenje!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali artikl!", "Pogreška!", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region OsvjezavanjePrikaza
        /// <summary>
        /// Osvježavanje prikaza artikala u Data grid view-u
        /// </summary>
        private void OsvjeziArtikle()
        {
            Kategorije odabranaKategorija = lbPopisKategorija.SelectedItem as Kategorije;
            if (odabranaKategorija != null)
            {
                List<Artikli> artikliKategorije;
                dgvPopisArtikala.DataSource = null;
                using (Entities dd = new Entities())
                {
                     artikliKategorije = dd.Artiklis.Where(s => s.KategorijaID == odabranaKategorija.ID).ToList();
                }
                dgvPopisArtikala.DataSource = artikliKategorije;
                
            }
            else
            {
                MessageBox.Show("Niste odabrali kategoriju!", "Pogreška!", MessageBoxButtons.OK);
            }
        }
        

        private void lbPopisKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.OsvjeziArtikle();
        }

        #endregion
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUpravljanjeArtiklom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(9);
            }
        }
    }
}
