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
    public partial class FrmNovaPrimka : Form
    {
        /// <summary>
        /// bool provjera jel se primka ureduje ili nova
        /// </summary>
        private bool nova = true;
        private Primke primka;

        public FrmNovaPrimka()
        {
            InitializeComponent();
        }
        /// <summary>
        /// konstruktor prima primku cije detalje ce pruziti i omoguciti izmjenu ova forma
        /// </summary>
        /// <param name="primljenaPrimka"></param>
        public FrmNovaPrimka(Primke primljenaPrimka)
        {
            InitializeComponent();
            primka = primljenaPrimka;
            nova = false;
            PrikaziStavkePrimki();
        }
        /// <summary>
        /// priprema podatke za formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNovaPrimka_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            PrikaziKorisnike();
            PrikaziArtikle();
            PrikaziKolicinu();
            PrikaziDatum();
        }

        #region Prikazi
        /// <summary>
        /// dohvaća popis dobavljača za combobox
        /// </summary>
        private void PrikaziDobavljace()
        {
            BindingList<Dobavljaci> listaDobavljaca = null;
            using (var db = new Entities())
            {
                listaDobavljaca = new BindingList<Dobavljaci>(db.Dobavljacis.ToList());
            }
            cbDobavljac.DataSource = listaDobavljaca;
            cbDobavljac.DisplayMember = "Naziv";
            cbDobavljac.ValueMember = "ID";
            if (!nova)
            {
                cbDobavljac.SelectedValue = primka.DobavljacID;
                
            }
        }
        /// <summary>
        /// dohvaća korisnika iz aktivnog usera
        /// </summary>
        private void PrikaziKorisnike()
        {
            if (nova)
            {
                txtKorisnik.Text = FrmPrijava.korisnik.KorisnickoIme;
                txtKorisnik.Enabled = false;
            }
            else
            {
                
                using (var db = new Entities())
                {
                    Korisnici korisnik = db.Korisnicis.SingleOrDefault(k => k.ID == primka.KorisnikID);
                    if (korisnik != null)
                    {
                        txtKorisnik.Text = korisnik.KorisnickoIme;
                        txtKorisnik.Enabled = false;
                    }
                }
            }
            
        }

        /// <summary>
        /// dohvaća popis Artikala za combobox
        /// </summary>
        private void PrikaziArtikle()
        {
            BindingList<Artikli> listaArtikla = null;
            using (var db = new Entities())
            {
                listaArtikla = new BindingList<Artikli>(db.Artiklis.ToList());
            }
            cbArtikl.DataSource = listaArtikla;
            cbArtikl.DisplayMember = "Naziv";
            cbArtikl.ValueMember = "ID";
            if (!nova)
            {
                StavkePrimke privremenaStavkaPrimke = stavkePrimkeBindingSource.Current as StavkePrimke;
                if(privremenaStavkaPrimke != null)
                {
                    cbArtikl.SelectedValue = privremenaStavkaPrimke.ArtiklID;
                }
                
            }            
        }
        /// <summary>
        /// Dohvaća listu stavki primke proslijeđene primke i prikazuje u dgv
        /// </summary>
        private void PrikaziStavkePrimki()
        {
            BindingList<StavkePrimke> listaStavkiPrimke = null;
            using (var db = new Entities())
            {
                db.Primkes.Attach(primka);
                listaStavkiPrimke = new BindingList<StavkePrimke>(primka.StavkePrimkes.ToList());
            }
            stavkePrimkeBindingSource.DataSource = listaStavkiPrimke;
        }
        /// <summary>
        /// hendla prikazivanje kolicine ovisno jel promjena ili novo
        /// </summary>
        private void PrikaziKolicinu()
        {
            if (!nova)
            {
                StavkePrimke privremenaStavkaPrimke = stavkePrimkeBindingSource.Current as StavkePrimke;
                if (privremenaStavkaPrimke != null)
                {
                    txtKolicina.Text = privremenaStavkaPrimke.Kolicina.ToString();
                }
            }
            else
            {
                txtKolicina.Text = "0";
            }            
        }
        /// <summary>
        /// hendla prikazivanje datuma ovisno jel promjena ili novo
        /// </summary>
        private void PrikaziDatum()
        {
            if (!nova)
            {
                dtpPrimke.Value = primka.DatumIVrijeme;
            }            
        }
        #endregion
              

        #region Pohrani
        /// <summary>
        /// ef za spremanje NOVE primke
        /// </summary>
        private void PohraniPrimku()
        {
            using (var db = new Entities())
            {
                primka = new Primke
                {
                    DobavljacID = int.Parse(cbDobavljac.SelectedValue.ToString()),
                    KorisnikID = FrmPrijava.korisnik.ID,
                    DatumIVrijeme = dtpPrimke.Value
                };
                db.Primkes.Add(primka);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// hendla mijenjanje osnovnih podataka STARE primke
        /// </summary>
        private void PohraniPromjenuPrimke()
        {
            using (var db = new Entities())
            {
                db.Primkes.Attach(primka);
                primka.DobavljacID = int.Parse(cbDobavljac.SelectedValue.ToString());
                primka.KorisnikID = FrmPrijava.korisnik.ID;
                primka.DatumIVrijeme = dtpPrimke.Value;              
                
                db.SaveChanges();
            }
        }
        /// <summary>
        /// hendla pohranjivanje ili updateanje stavke primke
        /// </summary>
        private void PohraniStavkuPrimke()
        {
            using (var db = new Entities())
            {
                StavkePrimke privremenaStavkaPrimke = stavkePrimkeBindingSource.Current as StavkePrimke;
                if (privremenaStavkaPrimke != null)
                {
                    //u slucaju da je odabrana stavka
                    if(privremenaStavkaPrimke.ArtiklID == int.Parse(cbArtikl.SelectedValue.ToString()))
                    {
                        db.Primkes.Attach(primka);
                        privremenaStavkaPrimke.Kolicina = int.Parse(txtKolicina.Text);
                        db.SaveChanges();
                    }
                    //u slucaju da je odabran rub dgv-a
                    else
                    {
                        db.Primkes.Attach(primka);
                        StavkePrimke stavka = new StavkePrimke
                        {
                            ArtiklID = int.Parse(cbArtikl.SelectedValue.ToString()),
                            Kolicina = int.Parse(txtKolicina.Text),
                            Primke = primka

                        };
                        db.StavkePrimkes.Add(stavka);
                        db.SaveChanges();
                    }
                    
                }
                //u slucaju nove stavkeprimke
                else
                {
                    db.Primkes.Attach(primka);
                    StavkePrimke stavka = new StavkePrimke
                    {
                        ArtiklID = int.Parse(cbArtikl.SelectedValue.ToString()),
                        Kolicina = int.Parse(txtKolicina.Text),
                        Primke = primka

                    };
                    db.StavkePrimkes.Add(stavka);
                    db.SaveChanges();
                }
                
            }
        }
        
        #endregion

        
        #region Button event

        /// <summary>
        /// spremanje podataka sa forme i hendlanje exception kolicina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPohrani_Click(object sender, EventArgs e)
        {
            if (nova)
            {
                PohraniPrimku();
                nova = false;
            }
            else
            {
                PohraniPromjenuPrimke();
            }

            try
            {
                PohraniStavkuPrimke();
            }
            catch (FormatException)
            {
                MessageBox.Show("Polje količina prima samo cijele brojeve");
            }
            
            PrikaziStavkePrimki();
            BlokirajPromjene();
        }

        /// <summary>
        /// obrisi selektiranu stavku primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiStavkuPrimke_Click(object sender, EventArgs e)
        {
            StavkePrimke selektiranaStavkaPrimke = stavkePrimkeBindingSource.Current as StavkePrimke;

            if (selektiranaStavkaPrimke != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.StavkePrimkes.Attach(selektiranaStavkaPrimke);
                        db.StavkePrimkes.Remove(selektiranaStavkaPrimke);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziStavkePrimki();
            PrikaziArtikle();
            PrikaziKolicinu();

        }
        /// <summary>
        /// otvara formu za dodavanje dobavljaca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajDobavljaca_Click(object sender, EventArgs e)
        {
            FrmNoviDobavljac noviDobavljac = new FrmNoviDobavljac();
            noviDobavljac.ShowDialog();
            PrikaziDobavljace();
        }
        #endregion

        /// <summary>
        /// u slucaju promjene odabira stavke mijenja podatke u korespondirajucem fieldu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStavkePrimki_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziArtikle();
            PrikaziKolicinu();
        }

        /// <summary>
        /// sprjecava promjene na osnovnim podacima forme
        /// </summary>
        private void BlokirajPromjene()
        {
            cbDobavljac.Enabled = false;            
            dtpPrimke.Enabled = false;
        }
        /// <summary>
        /// hendla otvaranje usermanuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNovaPrimka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(13);
            }
        }
    }
}
