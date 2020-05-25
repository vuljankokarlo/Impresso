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
    public partial class FrmDodajNarudžbu : Form
    {

        Narudzbe trenutnaNarudzba;
        public FrmDodajNarudžbu(Narudzbe novaNarudzba)
        {
            InitializeComponent();
            trenutnaNarudzba = novaNarudzba;
        }

        double trenutniArtikl = 0;

        private void pbOduzmi_Click(object sender, EventArgs e)
        {
            
            tbKolicinaArtikla.Text = (int.Parse(tbKolicinaArtikla.Text) - 1).ToString();
            ProvjeriMinus();
        }

        private void pbDodaj_Click(object sender, EventArgs e)
        {
            
            tbKolicinaArtikla.Text = (int.Parse(tbKolicinaArtikla.Text) + 1).ToString();
            ProvjeriPlus();
        }


        #region Provjera Prikaza

        private void ProvjeriMinus()
        {
            if (int.Parse(tbKolicinaArtikla.Text) == 1)
            {
                pbOduzmi.Hide();
                pbDodaj.Show();
            }
            if (int.Parse(tbKolicinaArtikla.Text) < trenutniArtikl && int.Parse(tbKolicinaArtikla.Text) > 1)
            {
                pbOduzmi.Show();
                pbDodaj.Show();
            }
        }

        private void ProvjeriPlus()
        {
            if (int.Parse(tbKolicinaArtikla.Text) < trenutniArtikl && int.Parse(tbKolicinaArtikla.Text) > 1)
            {
                pbOduzmi.Show();
                pbDodaj.Show();
            }
            if (int.Parse(tbKolicinaArtikla.Text) == trenutniArtikl)
            {
                pbOduzmi.Show();
                pbDodaj.Hide();
            }
        }

        #endregion

        #region Prikaz

        BindingList<Kategorije> listaKategorija = null;
        BindingList<Artikli> listaArtikla = null;

        /// <summary>
        /// Prikaži kategorije u combobox-u kod učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDodajNarudžbu_Load(object sender, EventArgs e)
        {
            pbOduzmi.Hide();
            tbKolicinaArtikla.Text = "1";
            DohvatiKategorije();
            cbKategorija.DataSource = null;
            cbKategorija.DataSource = listaKategorija;
            cbKategorija.DisplayMember = "naziv";
            cbKategorija.ValueMember = "id";
        }

        /// <summary>
        /// Dohvati sve kategorije
        /// </summary>
        private void DohvatiKategorije()
        {
            using (var db = new Entities())
            {
                listaKategorija = new BindingList<Kategorije>(db.Kategorijes.ToList());
            }
        }

        /// <summary>
        /// Dohvati sve artikle neke kategorije
        /// </summary>
        /// <param name="kategorija"></param>
        private void DohvatiArtikleKategorije(Kategorije kategorija)
        {
            using (var db = new Entities())
            {
                db.Kategorijes.Attach(kategorija);
                listaArtikla = new BindingList<Artikli>(kategorija.Artiklis.ToList());
            }
        }

        /// <summary>
        /// Prikaz artikla u dataGridView-u ovisno o odabranoj kategoriji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvArtikliZaNarudzbu.DataSource = null;
            Kategorije odabranaKategorija = cbKategorija.SelectedItem as Kategorije;
            DohvatiArtikleKategorije(odabranaKategorija);
            artikliBindingSource.DataSource = null;
            artikliBindingSource.DataSource = listaArtikla;
            dgvArtikliZaNarudzbu.DataSource = artikliBindingSource;
        }

        #endregion

        private void dgvArtikliZaNarudzbu_SelectionChanged(object sender, EventArgs e)
        {
            Artikli artiklZaDodati = artikliBindingSource.Current as Artikli;
            if (artiklZaDodati != null)
            {
                trenutniArtikl = artiklZaDodati.StanjeNaSkladistu;
                if (trenutniArtikl != 0)
                {
                    tbKolicinaArtikla.Text = "1";
                    pbDodaj.Show();
                    pbOduzmi.Hide();
                    btnDodajArtikl.Enabled = true;
                    btnPotvrdi.Enabled = true;
                }
                else
                {
                    tbKolicinaArtikla.Text = "0";
                    pbDodaj.Hide();
                    pbOduzmi.Hide();
                    btnDodajArtikl.Enabled = false;
                    btnPotvrdi.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Dodavanje artikla u narudžbu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            Artikli odabraniArtikl = artikliBindingSource.Current as Artikli;
            if (odabraniArtikl != null)
            {
                using (var db = new Entities())
                {
                    db.Artiklis.Attach(odabraniArtikl);
                    db.Narudzbes.Attach(trenutnaNarudzba);

                    StavkeNarudzbe stavkaNarudzbe = new StavkeNarudzbe
                    {
                        NarudzbaID = trenutnaNarudzba.ID,
                        ArtiklID = odabraniArtikl.ID,
                        Kolicina = int.Parse(tbKolicinaArtikla.Text)
                    };
                    db.StavkeNarudzbes.Add(stavkaNarudzbe);

                    odabraniArtikl.StanjeNaSkladistu = odabraniArtikl.StanjeNaSkladistu - int.Parse(tbKolicinaArtikla.Text);

                    db.SaveChanges();
                }
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDodajNarudžbu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(6);
            }
        }
    }
}
