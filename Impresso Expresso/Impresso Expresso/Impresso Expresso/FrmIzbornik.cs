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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        Korisnici trenutniKorisnik = null;

        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.ShowDialog();

            pbStol1.BackColor = Color.Transparent;
            pbStol2.BackColor = Color.Transparent;
            pbStol3.BackColor = Color.Transparent;
            pbStol4.BackColor = Color.Transparent;
            pbStol5.BackColor = Color.Transparent;
            pbStol6.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Metoda koja instancira i poziva novu formu frmSRegistracija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija formaRegistracija = new FrmRegistracija();
            formaRegistracija.ShowDialog();
        }


        #region Stolovi
        private void pbStol1_Click(object sender, EventArgs e)
        {
            FrmStol formaStol = new FrmStol(1, trenutniKorisnik);
            formaStol.ShowDialog();
        }

        private void pbStol2_Click(object sender, EventArgs e)
        {
            FrmStol formaStol = new FrmStol(2, trenutniKorisnik);
            formaStol.ShowDialog();
        }

        private void pbStol3_Click(object sender, EventArgs e)
        {
            FrmStol formaStol = new FrmStol(3, trenutniKorisnik);
            formaStol.ShowDialog();
        }

        private void pbStol4_Click(object sender, EventArgs e)
        {
            FrmStol formaStol = new FrmStol(4, trenutniKorisnik);
            formaStol.ShowDialog();
        }

        private void pbStol5_Click(object sender, EventArgs e)
        {
            FrmStol formaStol = new FrmStol(5, trenutniKorisnik);
            formaStol.ShowDialog();
        }

        private void pbStol6_Click(object sender, EventArgs e)
        {
            FrmStol formaStol = new FrmStol(6, trenutniKorisnik);
            formaStol.ShowDialog();
        }
        #endregion

        /// <summary>
        /// Metoda koja instancira i poziva novu formu frmSkladište
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            FrmSkladiste formaSkladište = new FrmSkladiste();
            formaSkladište.ShowDialog();
        }

        #region BojaStolova

        BindingList<Stolovi> listaStolova = null;
        BindingList<Narudzbe> listaNarudzbaStola = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIzbornik_Activated(object sender, EventArgs e)
        {

            trenutniKorisnik = FrmPrijava.korisnik;
            if (trenutniKorisnik.UlogaID == 1)
            {
                btnRegistracija.Enabled = true;
            }
            else
            {
                btnRegistracija.Enabled = false;
            }

            DohvatiStolove();

            for (int i = 0; i < 6; i++)
            {
                Stolovi stol = new Stolovi();
                stol = listaStolova[i];
                DohvatiNarudzbeStolova(stol);
                if (listaNarudzbaStola.Any())
                {
                    for (int j = 0; j < listaNarudzbaStola.Count; j++)
                    {
                        if (listaNarudzbaStola[j].RacunID == null)
                        {
                            //nije placeno sve
                            ObojiStolCrveno(i + 1);
                            break;
                        }
                        else
                        {
                            //sve je placeno
                            ObojiStolZeleno(i + 1);

                        }
                    }
                }
                else
                {
                    //nema narudžbi
                    ObojiStolSivo(i+1);
                }
            }
        }

        /// <summary>
        /// Dohvaća listu stolova
        /// </summary>
        private void DohvatiStolove()
        {
            using (var db = new Entities())
            {
                listaStolova = new BindingList<Stolovi>(db.Stolovis.ToList());
            }
        }

        /// <summary>
        /// Dohvaća sve narudžbe za određeni stol
        /// </summary>
        /// <param name="poslaniStol"></param>
        private void DohvatiNarudzbeStolova(Stolovi poslaniStol)
        {
            
            using (var db = new Entities())
            {
                db.Stolovis.Attach(poslaniStol);
                listaNarudzbaStola = new BindingList<Narudzbe>(poslaniStol.Narudzbes.ToList());
            }
        }

        private void ObojiStolSivo(int brojStola)
        {
            switch (brojStola)
            {
                case 1:
                    {
                        pbStol1.Image = Impresso_Expresso.Properties.Resources.gray;
                        break;
                    }
                case 2:
                    {
                        pbStol2.Image = Impresso_Expresso.Properties.Resources.gray;
                        break;
                    }
                case 3:
                    {
                        pbStol3.Image = Impresso_Expresso.Properties.Resources.gray;
                        break;
                    }
                case 4:
                    {
                        pbStol4.Image = Impresso_Expresso.Properties.Resources.gray;
                        break;
                    }
                case 5:
                    {
                        pbStol5.Image = Impresso_Expresso.Properties.Resources.gray;
                        break;
                    }
                case 6:
                    {
                        pbStol6.Image = Impresso_Expresso.Properties.Resources.gray;
                        break;
                    }
            }
        }

        private void ObojiStolCrveno(int brojStola)
        {
            switch (brojStola)
            {
                case 1:
                    {
                        pbStol1.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
                case 2:
                    {
                        pbStol2.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
                case 3:
                    {
                        pbStol3.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
                case 4:
                    {
                        pbStol4.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
                case 5:
                    {
                        pbStol5.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
                case 6:
                    {
                        pbStol6.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
            }
        }

        private void ObojiStolZeleno(int brojStola)
        {
            switch (brojStola)
            {
                case 1:
                    {
                        pbStol1.Image = Impresso_Expresso.Properties.Resources.green;
                        break;
                    }
                case 2:
                    {
                        pbStol2.Image = Impresso_Expresso.Properties.Resources.green;
                        break;
                    }
                case 3:
                    {
                        pbStol3.Image = Impresso_Expresso.Properties.Resources.green;
                        break;
                    }
                case 4:
                    {
                        pbStol4.Image = Impresso_Expresso.Properties.Resources.green;
                        break;
                    }
                case 5:
                    {
                        pbStol5.Image = Impresso_Expresso.Properties.Resources.green;
                        break;
                    }
                case 6:
                    {
                        pbStol6.Image = Impresso_Expresso.Properties.Resources.red;
                        break;
                    }
            }
        }
        #endregion

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.FormClosing += (s, ea) => this.Show();
            this.Hide();
            formaPrijava.ShowDialog();
            
        }
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIzbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(4);
            }
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            FrmObracunBlagajne frmObracunBlagajne = new FrmObracunBlagajne();
            frmObracunBlagajne.ShowDialog();
        }
    }
}
