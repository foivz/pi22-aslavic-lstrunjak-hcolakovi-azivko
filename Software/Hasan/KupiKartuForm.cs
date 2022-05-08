using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasan
{
    public partial class KupiKartuForm : Form
    {
        public Linija OdabranaLinija { get; set; }
        public KupiKartuForm(Linija linija)
        {
            OdabranaLinija = linija;
            InitializeComponent();
        }

        private void KupiKartuForm_Load(object sender, EventArgs e)
        {
            polazisteTextBox.Text = OdabranaLinija.Polaziste;
            odredisteTextBox.Text = OdabranaLinija.Odrediste;
            datumTextBox.Text = OdabranaLinija.VrijemePolaska.ToString();
            udaljenostTextBox.Text = OdabranaLinija.Udaljenost.ToString();
            autoprijevoznikTextBox.Text = OdabranaLinija.Autoprijevoznik;
        }

        private void odaberiDruguLinijuButton_Click(object sender, EventArgs e)
        {
            OdabirLinijeForm odabirLinije = new OdabirLinijeForm();
            odabirLinije.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistriraniForm registrirani = new RegistriraniForm();
            registrirani.ShowDialog();
        }
    }
}
