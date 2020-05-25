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
    public partial class FrmRegistracija : Form
    {
        Entities db = new Entities();
        public FrmRegistracija()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
            ulogeBindingSource.DataSource = db.Uloges.ToList();
        }
        /// <summary>
        /// Registracija korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            PohraniKorisnika();
             
        }
        #region Unos
        /// <summary>
        /// Pohrani korisnika u bazu
        /// </summary>
        private void PohraniKorisnika()
        {
            
            Korisnici korisnikKorime = db.Korisnicis.FirstOrDefault(s => s.KorisnickoIme == txtKorime.Text);
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtKorime.Text != "" && txtLozinka.Text != "" && txtAdresa.Text != "" && txtPosta.Text != "" && txtTelefon.Text != "")
            {
                if (korisnikKorime == null)
                {
                    Korisnici korisnici = new Korisnici
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtKorime.Text,
                        Lozinka = txtLozinka.Text,
                        Adresa = txtAdresa.Text,
                        Posta = txtPosta.Text,
                        Telefon = txtTelefon.Text,
                        UlogaID = int.Parse(cbUloga.SelectedValue.ToString())
                    };
                    db.Korisnicis.Add(korisnici);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Korisničko ime već postoji!", "Pogreška!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve podatke!", "Pogreška!", MessageBoxButtons.OK);

            }

        }
        #endregion
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistracija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(3);
            }
        }
    }
}
