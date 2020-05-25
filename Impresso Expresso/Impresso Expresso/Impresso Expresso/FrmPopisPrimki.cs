using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    /// <summary>
    /// <author>Stefan Tropčić</author>
    /// </summary>
    public partial class FrmPopisPrimki : Form
    {
        public FrmPopisPrimki()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Na load forme pozovi metode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrimka_Load(object sender, System.EventArgs e)
        {
            PrikaziPrimke();
            PrikaziStavkePrimki(primkeBindingSource.Current as Primke);
        }

        #region Prikazi
        /// <summary>
        /// Dohvaća listu svih primki iz konteksta i prikazuje ih u dgv
        /// </summary>
        private void PrikaziPrimke()
        {
            BindingList<Primke> listaPrimki = null;
            using(var db = new Entities())
            {
                listaPrimki = new BindingList<Primke>(db.Primkes.ToList());
            }
            primkeBindingSource.DataSource = listaPrimki;
        }

        /// <summary>
        /// Dohvaća listu stavki primke proslijeđene primke i prikazuje u dgv
        /// </summary>
        /// <param name="primke"></param>
        private void PrikaziStavkePrimki(Primke primke)
        {
            
            using (var db = new Entities())
            {
                dgvStavkePrimke.DataSource = db.spStavkePrimke(primke.ID);               
            }
            
        }
        #endregion
        
        #region ButtonEvent

        /// <summary>
        /// otvara formu za upis nove primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovaPrimka_Click(object sender, System.EventArgs e)
        {
            FrmNovaPrimka novaPrimka = new FrmNovaPrimka();
            novaPrimka.ShowDialog();
            PrikaziPrimke();
        }
        /// <summary>
        /// provjerava jel primka prazna i brise primku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiPrimku_Click(object sender, System.EventArgs e)
        {
            Primke selektiranaPrimka = primkeBindingSource.Current as Primke;
            if (selektiranaPrimka != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.Primkes.Attach(selektiranaPrimka);
                        if (selektiranaPrimka.StavkePrimkes.Count == 0)
                        {
                            db.Primkes.Remove(selektiranaPrimka);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Primka sadrži stavke!");
                        }
                    }
                }
            }
            PrikaziPrimke();
        }

        /// <summary>
        /// prosljeduje selektiranu primku frmnovaprimka za uredivanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrediPrimku_Click(object sender, System.EventArgs e)
        {
            FrmNovaPrimka novaPrimka = new FrmNovaPrimka(primkeBindingSource.Current as Primke);
            novaPrimka.ShowDialog();
            PrikaziPrimke();
        }
        #endregion

        /// <summary>
        /// Pri događaju promjene selekcije mijenja stavke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPrimke_SelectionChanged(object sender, System.EventArgs e)
        {
            Primke selektiranaPrimka = primkeBindingSource.Current as Primke;
            if (selektiranaPrimka != null)
            {
                PrikaziStavkePrimki(selektiranaPrimka);
            }
        }
        /// <summary>
        /// hendla otvaranje usermanuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPopisPrimki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(12);
            }
        }
    }
}
