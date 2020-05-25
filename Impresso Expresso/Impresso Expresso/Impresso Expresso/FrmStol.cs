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
    public partial class FrmStol : Form
    {

        public int idStola { get; set; }
        Korisnici poslaniKorisnikGlobal = null;

        public FrmStol(int poslanaVrijednost, Korisnici poslaniKorisnik)
        {
            InitializeComponent();
            idStola = poslanaVrijednost;
            poslaniKorisnikGlobal = poslaniKorisnik;
        }

        /// <summary>
        /// Kreira novu narudžbu i otvara formu za unos stavki narudžbe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMeni_Click(object sender, EventArgs e)
        {
            //napraviti narudžbu tu, i proslijediti u formu
            using (var db = new Entities())
            {
                Narudzbe narudzba = new Narudzbe
                {
                    RacunID = null,
                    StolID = idStola,
                    KorisnikID = poslaniKorisnikGlobal.ID, //inace bude id reg korisnika, kasnije promjeniti
                    Datum = DateTime.Now
                };
                db.Narudzbes.Add(narudzba);
                db.SaveChanges();

                FrmDodajNarudžbu formaDodajNarudžbu = new FrmDodajNarudžbu(narudzba);
                formaDodajNarudžbu.ShowDialog();
            }
        }


        #region Upravljanje slikom

        private void pbUkloni_MouseEnter(object sender, EventArgs e)
        {
            pbUkloni.Image = Impresso_Expresso.Properties.Resources.brisiNarudzbeMO;
        }

        private void pbUkloni_MouseLeave(object sender, EventArgs e)
        {
            pbUkloni.Image = Impresso_Expresso.Properties.Resources.brisiNarudzbe;
        }

        #endregion

        #region Oslobađanje Stola

        BindingList<Stolovi> listaStolovaZaBrisanje = null;
        BindingList<Narudzbe> listaNarudzbaStolaZaBrisanje = null;

        /// <summary>
        /// Metoda koja čisti stol od narudžbi i oslobađa ga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbUkloni_MouseClick(object sender, MouseEventArgs e)
        {
            //maknuti narudzbe sa stola na stol 1004, al samo one koje su naplacene
            DohvatiStoloveBrisi();

                Stolovi stolZaBrisanje = new Stolovi();
                stolZaBrisanje = listaStolovaZaBrisanje[idStola-1];
                DohvatiNarudzbeStolovaBrisi(stolZaBrisanje);
            if (listaNarudzbaStolaZaBrisanje.Any())
                {
                    for (int j = 0; j < listaNarudzbaStolaZaBrisanje.Count; j++)
                    {
                        if (listaNarudzbaStolaZaBrisanje[j].RacunID != null)
                        {
                            //promjeni ID stola, spremi u bazu
                            using (var db = new Entities())
                            {
                                db.Narudzbes.Attach(listaNarudzbaStolaZaBrisanje[j]);
                                listaNarudzbaStolaZaBrisanje[j].StolID = 1004;
                                db.SaveChanges();
                            }
                        }
                    }
                }

        }

        /// <summary>
        /// Dohvaća listu stolova
        /// </summary>
        private void DohvatiStoloveBrisi()
        {
            using (var db = new Entities())
            {
                listaStolovaZaBrisanje = new BindingList<Stolovi>(db.Stolovis.ToList());
            }
        }

        /// <summary>
        /// Dohvaća sve narudžbe za određeni stol
        /// </summary>
        /// <param name="poslaniStol"></param>
        private void DohvatiNarudzbeStolovaBrisi(Stolovi poslaniStol)
        {

            using (var db = new Entities())
            {
                db.Stolovis.Attach(poslaniStol);
                listaNarudzbaStolaZaBrisanje = new BindingList<Narudzbe>(poslaniStol.Narudzbes.ToList());
            }
        }
        #endregion

        #region Prikaz podataka u combobox-u

        BindingList<Stolovi> listaStolovaZaPrikaz = null;
        BindingList<Narudzbe> listaNarudzbaStolaZaPrikaz = null;

        private void FrmStol_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Puni combobox sa narudžbama stola koje još nisu naplaćene
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStol_Activated(object sender, EventArgs e)
        {
            listaStolovaZaPrikaz = null;
            listaNarudzbaStolaZaPrikaz = null;
            List<Narudzbe> listaZaCB = new List<Narudzbe>();
            DohvatiStolovePuni();

            Stolovi stolZaCB = new Stolovi();
            stolZaCB = listaStolovaZaPrikaz[idStola - 1];
            DohvatiNarudzbeStolovaPuni(stolZaCB);
            
            if (listaNarudzbaStolaZaPrikaz.Any())
            {

                foreach (var item in listaNarudzbaStolaZaPrikaz)
                {
                    if (item.RacunID == null)
                    {
                        listaZaCB.Add(item);
                    }
                }
            }

            cbOdaberiNarudžbu.DataSource = null;
            cbOdaberiNarudžbu.DataSource = listaZaCB;
            cbOdaberiNarudžbu.DisplayMember = "id";
            cbOdaberiNarudžbu.ValueMember = "id";

            lbNarudzbeZaRacun.DataSource = null;
            lbNarudzbeZaRacun.DataSource = listaZaCB;
            lbNarudzbeZaRacun.DisplayMember = "id";


        }

        /// <summary>
        /// Dohvaća listu stolova
        /// </summary>
        private void DohvatiStolovePuni()
        {
            using (var db = new Entities())
            {
                listaStolovaZaPrikaz = new BindingList<Stolovi>(db.Stolovis.ToList());
            }
        }

        /// <summary>
        /// Dohvaća sve narudžbe za određeni stol
        /// </summary>
        /// <param name="poslaniStol"></param>
        private void DohvatiNarudzbeStolovaPuni(Stolovi poslaniStolCB)
        {

            using (var db = new Entities())
            {
                db.Stolovis.Attach(poslaniStolCB);
                listaNarudzbaStolaZaPrikaz = new BindingList<Narudzbe>(poslaniStolCB.Narudzbes.ToList());
            }
        }
        #endregion

        private void btnRacun_Click_1(object sender, EventArgs e)
        {
            List<Narudzbe> listaNarudzbaZaRacun = new List<Narudzbe>();

            foreach (var item in lbNarudzbeZaRacun.SelectedItems)
            {
                listaNarudzbaZaRacun.Add(item as Narudzbe);
            }

            FrmRacun Racun = new FrmRacun(listaNarudzbaZaRacun);
            Racun.ShowDialog();
        }
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(5);
            }
        }


        BindingList<StavkeNarudzbe> listaStavkiZaDgv = new BindingList<StavkeNarudzbe>();

        private void cbOdaberiNarudžbu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOdaberiNarudžbu.SelectedItem != null)
            {
                Narudzbe odabranaNarudzba = cbOdaberiNarudžbu.SelectedItem as Narudzbe;
                using (var db = new Entities())
                {
                    db.Narudzbes.Attach(odabranaNarudzba);
                    listaStavkiZaDgv = new BindingList<StavkeNarudzbe>(odabranaNarudzba.StavkeNarudzbes.ToList());
                }

                dgvPrikazNarudzba.DataSource = listaStavkiZaDgv;
                this.dgvPrikazNarudzba.Columns["Artikli"].Visible = false;
                this.dgvPrikazNarudzba.Columns["Narudzbe"].Visible = false;
            }

        }
    }
}
