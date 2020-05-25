using Microsoft.Reporting.WinForms;
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
    public partial class FrmRacun : Form
    {
        private Racuni noviRacun = null;
        double iznos = 0.00;
        /// <summary>
        /// radi osnovni setup forme, poziva instancu racuna i izmjenu narudzbi
        /// </summary>
        /// <param name="listaNarudzbi"></param>
        public FrmRacun(List<Narudzbe> listaNarudzbi)
        {
            InitializeComponent();
            NapraviRacun();
            listaNarudzbi.ForEach(x=>PohraniNarudzbu(x));
        }

        /// <summary>
        /// prikazuje sve graficke elemente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRacun_Load(object sender, EventArgs e)
        {
            
            using (var db = new Entities())
            {
                dgvStavkeRacuna.DataSource = db.spStavkeRacuna(noviRacun.ID);
            }
            PrikaziIznos();
            PrikaziNacinePlacanja();            
        }
        

        #region Pohrani
        /// <summary>
        /// sprema narudzbu u bazu s id specificnog racuna
        /// </summary>
        /// <param name="narudzba"></param>
        private void PohraniNarudzbu(Narudzbe narudzba)
        {
            using (var db = new Entities())
            {
                db.Narudzbes.Attach(narudzba);
                narudzba.RacunID = noviRacun.ID;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Mijenja nacin placanja
        /// </summary>
        private void PromijeniRacun()
        {
            using (var db = new Entities())
            {
                db.Racunis.Attach(noviRacun);
                noviRacun.PlacanjeID = int.Parse(cbNacinPlacanja.SelectedValue.ToString());
                db.SaveChanges();
            }
        }

        /// <summary>
        /// instancira i sprema objekt racuna
        /// </summary>
        private void NapraviRacun()
        {
            using (var db = new Entities())
            {
                noviRacun = new Racuni
                {
                    ID = 10,
                    Datum = DateTime.Now,
                    KorisnikID = 6,
                    KasaID = 1,
                    PlacanjeID = 1
                };
                db.Racunis.Add(noviRacun);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// mijenja stanje kase pri izdavanju racuna
        /// </summary>
        private void PohraniKasu()
        {
            using (var db = new Entities())
            {
                var kasa = db.Kases.SingleOrDefault(k => k.ID == 1);
                if (kasa != null)
                {
                    kasa.StanjeKase = (decimal)((Double)kasa.StanjeKase + iznos);
                    db.SaveChanges();
                }
            }
        }
        #endregion



        #region Prikazi
        /// <summary>
        /// hendla dohvacanje svih podataka na report racuna
        /// </summary>
        private void PrikaziReport()
        {
            int nacinPlacanja = cbNacinPlacanja.SelectedIndex;
            string ime = "";
            using (var db = new Entities())
            {
                spStavkeRacuna_ResultBindingSource.DataSource = db.spStavkeRacuna(noviRacun.ID);
                var artikl = db.Placanjas.Single(x => x.ID == nacinPlacanja+1);
                ime = artikl.Naziv.ToString();
            }
            
            ReportParameter[] listaParametara = new ReportParameter[]
            {
                new ReportParameter("kasa",noviRacun.KasaID.ToString()),
                new ReportParameter("korisnik", noviRacun.KorisnikID.ToString()),
                new ReportParameter("brojRacuna", noviRacun.ID.ToString()),
                new ReportParameter("datum", noviRacun.Datum.ToString()),
                new ReportParameter("nacinPlacanja", ime)

            };

            this.reportViewer1.LocalReport.SetParameters(listaParametara);
            this.reportViewer1.RefreshReport();
        }
                
        /// <summary>
        /// hendla izracun sume racuna i pdva
        /// </summary>
        private void PrikaziIznos()
        {
            double pdv = 0.00;
            
            foreach (DataGridViewRow row in dgvStavkeRacuna.Rows)
            {
                iznos += (Double)row.Cells["Ukupno"].Value;
            }
            pdv = iznos - (iznos / 1.25);

            txtPDV.Text = pdv.ToString("0.00");
            txtUkupniIznos.Text = iznos.ToString("0.00");
        }
        /// <summary>
        /// dohvaća popis Nacina plaćanja za combobox
        /// </summary>
        private void PrikaziNacinePlacanja()
        {
            
            using (var db = new Entities())
            {
                placanjaBindingSource.DataSource = db.Placanjas.ToList();
            }
           
            
        }
        #endregion

        /// <summary>
        /// na lik ispisa prikazuje report i mijenja podatke o racunu unutar baze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspis_Click(object sender, EventArgs e)
        {
            PromijeniRacun();
            PrikaziReport();
            PohraniKasu();
        }
        /// <summary>
        /// hendlanje otvaranja user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRacun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(7);                
            }
        }
    }
}
