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
    public partial class FrmPrijava : Form
    {
        public Entities db = new Entities();
        public static Korisnici korisnik;
        public FrmPrijava()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
        }
        /// <summary>
        /// Prijava u sustav
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            ProvjeraPrijave();
             
        }
        #region Provjera
        /// <summary>
        /// Provjera unesenih podataka za prijavu
        /// </summary>
        private void ProvjeraPrijave()
        {
            if (txtLozinka.Text != "" && txtKorIme.Text != "")
            {
                korisnik = db.Korisnicis.FirstOrDefault(s => s.KorisnickoIme == txtKorIme.Text);
                if (korisnik != null)
                {
                    if (korisnik.Lozinka == txtLozinka.Text)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kriva lozinka!", "Pogreška", MessageBoxButtons.OK);
                    }
                }
                else
                {

                    MessageBox.Show("Korisnik ne postoji!", "Pogreška", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve podatke!", "Pogreška", MessageBoxButtons.OK);

            }
        }

        #endregion
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(2);
            }
        }
    }
}
