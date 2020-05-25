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
    /// <author>Stefan Tropčić</author>
    /// </summary>
    public partial class FrmNoviDobavljac : Form
    {
        /// <summary>
        /// lista pozivnih brojeva
        /// </summary>
        private List<string> pozivniBroj = new List<string> { "01", "020", "021", "022",
                            "023","031","032","033","034","035","040","042","043","044",
                            "047","048","049","051","052","053","091","092","095","097",
                            "098","099"};

        private Dobavljaci dobavljac = new Dobavljaci();
        private bool greska = false;

        public FrmNoviDobavljac()
        {
            InitializeComponent();
        }

        private void FrmNoviDobavljac_Load(object sender, EventArgs e)
        {
            cbPozivniBroj.DataSource = pozivniBroj;
        }

        #region Pohrani
        /// <summary>
        /// pohranjuje podatke u bazu i zatvara formu ako produ provjere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pohrani_Click(object sender, EventArgs e)
        {
            greska = false;
            ProvjeriTelefonskiBroj(txtTelefonskiBroj.Text);
            ProvjeriPostanskiBroj(txtPostanskiBroj.Text);
            ProvjeriPolja();
            if (!greska)
            {
                PohraniDobavljaca();
            }
            
        }

        /// <summary>
        /// pohranjuje podatke u bazu i zatvara formu
        /// </summary>
        private void PohraniDobavljaca()
        {
            dobavljac.Naziv = txtNaziv.Text;
            dobavljac.Adresa = txtAdresa.Text;
            dobavljac.Posta = txtPostanskiBroj.Text + txtGrad.Text;
            dobavljac.Telefon = cbPozivniBroj.SelectedValue+"/" + txtTelefonskiBroj.Text;

            using (Entities db = new Entities())
            {
                db.Dobavljacis.Add(dobavljac);
                db.SaveChanges();
            }
            Close();
        }
        #endregion

        #region Provjeri
        /// <summary>
        /// provjerava jel telefonski broj zadovoljava hrv standarde
        /// </summary>
        /// <param name="tekst"></param>
        private void ProvjeriTelefonskiBroj(string tekst)
        {
            ProvjeriBroj(tekst, "telefonski");
            if (!greska)
            {
                int broj = tekst.Length;
                if (broj > 7)
                {
                    greska = true;
                    MessageBox.Show("Predugačak telefonski broj");
                }
                else if (broj < 6)
                {
                    greska = true;
                    MessageBox.Show("Prekatak telefonski broj");
                }
            }
        }

        /// <summary>
        /// provjerava jel postanski broj zadovoljava hrv standarde
        /// </summary>
        /// <param name="tekst"></param>
        private void ProvjeriPostanskiBroj(string tekst)
        {
            ProvjeriBroj(tekst, "poštanski");
            if (!greska)
            {
                int broj = int.Parse(tekst);
                if (broj > 53297 || broj < 10000)
                {
                    greska = true;
                    MessageBox.Show("Ne postoji taj poštanski broj u RH");
                }
            }
        }

        /// <summary>
        /// provjerava jel uneseni tekst broj
        /// </summary>
        /// <param name="provjera"></param>
        /// <param name="vrsta"></param>
        private void ProvjeriBroj(string provjera, string vrsta)
        {
            try
            {
                int broj = int.Parse(provjera);
            }
            catch (FormatException)
            {
                MessageBox.Show("Upišite broj u polje " + vrsta + " broj");
                greska = true;
            }
            
        }

        /// <summary>
        /// provjerava jel sva polja imaju ista uneseno
        /// </summary>
        private void ProvjeriPolja()
        {
            if (txtNaziv.Text == "" || txtAdresa.Text == "" || txtPostanskiBroj.Text == "" || 
                txtGrad.Text == "" || txtTelefonskiBroj.Text == "")
            {
                MessageBox.Show("Unesite sve podatke!", "Pogreška!", MessageBoxButtons.OK);
                greska = true;
            }
        }
        #endregion

        /// <summary>
        /// hendla otvaranje usermanuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviDobavljac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(14);
            }
        }
    }
}
