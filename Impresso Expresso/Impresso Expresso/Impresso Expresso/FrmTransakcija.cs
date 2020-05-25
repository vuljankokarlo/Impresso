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
    public partial class FrmTransakcija : Form
    {
        Entities db = new Entities();
        /// <summary>
        /// Popinjavanje combobox klasa i combobox tipova transakcije
        /// </summary>
        public FrmTransakcija()
        {
            InitializeComponent();
            tipoviBindingSource.DataSource = db.Tipovis.ToList();
            kaseBindingSource.DataSource = db.Kases.ToList();
        }
        
        /// <summary>
        /// Unos nove transakcije (uplata ili isplata iznosa na kasi)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnesiTranskciju_Click(object sender, EventArgs e)
        {
            if (txtIznosTransakcije.Text != "")
            {
                Transakcije transakcija = new Transakcije();
                transakcija.KasaID = int.Parse(cbKasa.SelectedValue.ToString());
                transakcija.TipID = int.Parse(cbTipTransakcije.SelectedValue.ToString());
                transakcija.Datum = DateTime.Now;
                decimal iznos = decimal.Parse(txtIznosTransakcije.Text);
                transakcija.Iznos = decimal.Parse(iznos.ToString("#.##"));
                db.Transakcijes.Add(transakcija);
                AzurirajKasu();
                db.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Popunite sve podatke!", "Pogreška!", MessageBoxButtons.OK);
            }

        }
        /// <summary>
        /// Ažuriranje stanja kase ovisno o tipu transakcije
        /// </summary>
        private void AzurirajKasu()
        {
            int odabranaKasa = int.Parse(cbKasa.SelectedValue.ToString());
            Kase kasa = db.Kases.FirstOrDefault(s => s.ID == odabranaKasa);
            decimal stanjeKase = kasa.StanjeKase;
            decimal iznos = decimal.Parse(txtIznosTransakcije.Text);
            if (int.Parse(cbTipTransakcije.SelectedValue.ToString()) == 1)
            {
               
                kasa.StanjeKase = stanjeKase + (-1 * decimal.Parse(iznos.ToString("#.##")));
            }
            else
            {
                kasa.StanjeKase = stanjeKase + decimal.Parse(iznos.ToString("#.##"));
            }
        }

        /// <summary>
        /// Zaštita unosa iznosa transakcije kao numeric(18,2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIznosTransakcije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// hendla otvaranje user manuala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTransakcija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                UserManual.Pdf.OtvoriPodrsku(16);
            }
        }
    }
}
