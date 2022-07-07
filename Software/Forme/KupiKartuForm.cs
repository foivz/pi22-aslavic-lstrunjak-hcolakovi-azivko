using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forme.Database;

namespace Forme
{
    public partial class KupiKartuForm : Form
    {
        Korisnik korisnik;
        Linija linija;
        public KupiKartuForm(Korisnik aktivniKorisnik, Linija odabranaLinija)
        {
            InitializeComponent();
            korisnik = aktivniKorisnik;
            linija = odabranaLinija;
        }

        private void odaberiLinijuButton_Click(object sender, EventArgs e)
        {
            OdaberiLinijuForm odaberiLinijuForm = new OdaberiLinijuForm(korisnik);
            this.Hide();
            odaberiLinijuForm.ShowDialog();
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            double cijena = 0;
            string vrstaKarte = "Regularna";
            cijena = double.Parse(udaljenostTextBox.Text) * 0.7;

            if (studentskaRadioButton.Checked)
            {
                //50% popusta za studente
                cijena *= 0.5;
                vrstaKarte = "Studentska";
            }
            else if (umirovljenikRdioButton.Checked)
            {
                //30% popusta za umirovljenike
                cijena *= 0.7;
                vrstaKarte = "Umirovljenička";
            }

            if (povratnaKartaCheckBox.Checked)
            {
                cijena *= 1.95;
            }

            if (prtljagaCheckBox.Checked)
            {
                cijena += 10;
            }

            // Moramo dodati tu kartu BAŠ tom korisniku koji je logiran
            // Moramo smanjiti broj slobodnih mjesta za tu liniju
            using (var context = new LinkBusEntities())
            {
                Karta karta = new Karta
                {
                    linija_id = linija.linija_id,
                    korisnik_id = korisnik.korisnik_id,
                    vrsta_karte = vrstaKarte,
                    povratna = povratnaKartaCheckBox.Checked,
                    prtljaga = prtljagaCheckBox.Checked,
                    cijena = cijena,
                    datum_i_vrijeme_rezeravcije = DateTime.Now.ToString()
                };

                // Ažuriranje broja slobodnih mjesta
                context.Linija.Attach(linija);
                linija.broj_slobodnih_mjesta -= 1;
                context.SaveChanges();

                // Dodavanje karte u tablicu Karta
                context.Karta.Add(karta);
                context.SaveChanges();

                // Povratna informacija korisniku
                MessageBox.Show($"Uspješno ste rezervirali kartu na relaciji {linija.polaziste} - {linija.odrediste}. Ukupna cijena je: {cijena} HRK.");
                this.Close();
            }
        }

        private void KupiKartuForm_Load(object sender, EventArgs e)
        {
            polazisteTextBox.Text = linija.polaziste;
            odredisteTextBox.Text = linija.odrediste;
            udaljenostTextBox.Text = linija.udaljenost.ToString();
            using (var context = new LinkBusEntities())
            {
                foreach (Autoprijevoznik autoprijevoznik in context.Autoprijevoznik)
                {
                    if (autoprijevoznik.autoprijevoznik_id == linija.autoprijevoznik_id)
                    {
                        autoprijevoznikTextBox.Text = autoprijevoznik.naziv_prijevoznika;
                    }
                }
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
