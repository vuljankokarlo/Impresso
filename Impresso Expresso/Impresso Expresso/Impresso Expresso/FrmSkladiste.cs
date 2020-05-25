using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    /// <summary>
    /// <author>Stefan Tropčić</author>
    /// </summary>
    public partial class FrmSkladiste : Form
    {
        private enum opcijeSort { ID, AZ, ZA, Najskuplji, Najjeftiniji, Najviše, Najmanje };

        public FrmSkladiste()
        {
            InitializeComponent();
        }

        /// <summary>
        /// prikazi sve graficke elemente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSkladiste_Load(object sender, EventArgs e)
        {           
            cbOpcijeSort.DataSource = Enum.GetValues(typeof(opcijeSort));
            PrikaziArtikle();
        }
                
        /// <summary>
        /// Dohvaća listu svih artikala i prikazuje ih u dgv
        /// </summary>
        private void PrikaziArtikle()
        {
            BindingList<Artikli> listaArtikala = null;
            using (var db = new Entities())
            {
                listaArtikala = new BindingList<Artikli>(db.Artiklis.ToList());
            }
            artikliBindingSource.DataSource = Sortiraj(listaArtikala);
        }

        #region Sort
        /// <summary>
        /// ovisno o odabiru sorta mijenja listu podataka
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <returns></returns>
        private BindingList<Artikli> Sortiraj(BindingList<Artikli> listaArtikala)
        {
            BindingList<Artikli> sortiranaLista = null;
            
            opcijeSort izabranaOpcija = (opcijeSort)cbOpcijeSort.SelectedItem;
            
            switch(izabranaOpcija)
            {
                case opcijeSort.AZ:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderBy(x => x.Naziv).ToList());
                    break;
                case opcijeSort.ZA:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderByDescending(x => x.Naziv).ToList());
                    break;
                case opcijeSort.Najjeftiniji:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderBy(x => x.Cijena).ToList());
                    break;
                case opcijeSort.Najskuplji:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderByDescending(x => x.Cijena).ToList());
                    break;
                case opcijeSort.Najmanje:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderBy(x => x.StanjeNaSkladistu).ToList());
                    break;
                case opcijeSort.Najviše:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderByDescending(x => x.StanjeNaSkladistu).ToList());
                    break;
                default:
                    sortiranaLista =  listaArtikala;
                    break;

            }
            return sortiranaLista;
        }
        /// <summary>
        /// u slucaju promjene tipa sortiranja prikazi drugacije podatke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOpcijeSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziArtikle();
        }
        #endregion

        #region ButtonEvent
        /// <summary>
        /// Metoda instancira i poziva formu FrmUpravljanjeArtikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnosArtikla_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeArtiklom formaUpravljanjeArtiklom = new FrmUpravljanjeArtiklom();
            formaUpravljanjeArtiklom.ShowDialog();
            PrikaziArtikle();
        }
        /// <summary>
        /// Metoda instancira i poziva formu FrmPrimka
        /// </summary>        
        private void btnPrimka_Click(object sender, EventArgs e)
        {
            FrmPopisPrimki formaPrimka = new FrmPopisPrimki();
            formaPrimka.ShowDialog();
            PrikaziArtikle();
        }

        #endregion

        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSkladiste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(8);
            }
        }
    }
}
