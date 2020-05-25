using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    /// <summary>
    /// <author>Rene Maruševec</author>
    /// </summary>
    class IzracunObracuna
    {
        public decimal PologUBlagajni { get; set; }
        public decimal IznosGotovineUBlagajni { get; set; }
        public decimal IznosKarticaUBlagajni { get; set; }
        public decimal PrometBlagajne { get; set; }
        public Korisnici IdKonobara { get; set; }
        public IzracunObracuna(Korisnici idKonobara)
        {
            this.IdKonobara = idKonobara;
        }

        Entities db = new Entities();
        /// <summary>
        /// Izračun pologa za današnji dan
        /// </summary>
        public void IzracunPologa()
        {
            try
            {
                foreach (var broj in db.IznosPologaZaDanas())
                {
                    PologUBlagajni = (decimal)broj;
                }
            }
            catch (Exception)
            {
                PologUBlagajni = 0;
            }
        }
        /// <summary>
        /// Izračun iznosa gotovine svih računa za današnji dan
        /// </summary>
        public void IzracunIznosaGotovineUBlagajni()
        {
            try
            {
                foreach (var broj in db.IznosRacunaPlacenihGotovinom())
                {
                    IznosGotovineUBlagajni = (decimal)broj;
                }
            }
            catch (Exception)
            {
                IznosGotovineUBlagajni = 0;
            }
        }
        /// <summary>
        /// Izračun iznosa računa plaćenih karticom za današnji dan
        /// </summary>
        public void IzracunIznosaKarticaUBlagajni()
        {

            try
            {
                foreach (var broj in db.IznosRacunaPlacenihKarticom())
                {
                    IznosKarticaUBlagajni = (decimal)broj;
                }
            }
            catch (Exception)
            {
                IznosKarticaUBlagajni = 0;
            }

        }
        /// <summary>
        /// Unos dnevnog izvještaja u bazu podataka
        /// </summary>
        public void UnosIzvjestajaUBazu()
        {
            IzracunPrometaBlagajne();
            Izvjestaji izvjestaj = new Izvjestaji
            {
                Datum = DateTime.Now,
                PrometBlagajne = PrometBlagajne,
                PologUBlagajni = PologUBlagajni,
                GotovinaUBlagajni = IznosGotovineUBlagajni,
                KonobarID = IdKonobara.ID,
                IznosKartica = IznosKarticaUBlagajni

            };
            db.Izvjestajis.Add(izvjestaj);
            db.SaveChanges();
        }
        /// <summary>
        /// Izracun prometa blagajne. Polog plus Iznos racuna u gotovini
        /// </summary>
        private void IzracunPrometaBlagajne()
        {
            PrometBlagajne = PologUBlagajni + IznosGotovineUBlagajni;
        }
        /// <summary>
        /// Ažuriranje stanja kase. Dodavanje iznosa racuna u gotovini
        /// </summary>
        public void AzuriranjeStanjaKase()
        {
            IzracunPologa();
            IzracunIznosaGotovineUBlagajni();
            IzracunPrometaBlagajne();
            Kase kasa = db.Kases.FirstOrDefault(s => s.ID == 1);
            kasa.StanjeKase = PrometBlagajne;
            db.SaveChanges();

        }
    }
}
