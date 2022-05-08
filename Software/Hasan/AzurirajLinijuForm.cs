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
    public partial class AzurirajLinijuForm : Form
    {
        public Linija OdabranaLinija { get; set; }
        public AzurirajLinijuForm(Linija linija)
        {
            OdabranaLinija = linija;
            InitializeComponent();
        }

        private void AzurirajLinijuForm_Load(object sender, EventArgs e)
        {
            idTextBox.Text = OdabranaLinija.ID.ToString();
            brojLinijeTextBox.Text = OdabranaLinija.BrojLinije.ToString();
            polazisteTextBox.Text = OdabranaLinija.Polaziste.ToString();
            odredisteTextBox.Text = OdabranaLinija.Odrediste.ToString();
            dateTimePicker.Value = OdabranaLinija.VrijemePolaska;
            udaljenostTextBox.Text = OdabranaLinija.Udaljenost.ToString();
            autoprijevoznikTextBox.Text = OdabranaLinija.Autoprijevoznik.ToString();
        }

        private void azurirajButton_Click(object sender, EventArgs e)
        {
            string polaziste = polazisteTextBox.Text;
            string odrediste = odredisteTextBox.Text;
            DateTime datum = dateTimePicker.Value;
            double udaljenost = double.Parse(udaljenostTextBox.Text);
            string autoprijevoznik = autoprijevoznikTextBox.Text;

            OdabranaLinija.Polaziste = polaziste;
            OdabranaLinija.Odrediste = odrediste;
            OdabranaLinija.VrijemePolaska = datum;
            OdabranaLinija.Udaljenost = udaljenost;
            OdabranaLinija.Autoprijevoznik = autoprijevoznik;
            Close();
        }
    }
}
