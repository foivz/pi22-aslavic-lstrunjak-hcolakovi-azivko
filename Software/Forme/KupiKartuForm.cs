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
        private bool mouseDown;
        private Point lastLocation;
        Korisnik korisnik;
        Linija linija;
        double izracunCijene = 0;
        public KupiKartuForm(Korisnik aktivniKorisnik, Linija odabranaLinija)
        {
            InitializeComponent();
            korisnik = aktivniKorisnik;
            linija = odabranaLinija;
        }

        private void odaberiLinijuButton_Click(object sender, EventArgs e)
        {
            OdaberiLinijuForm olf1 = new OdaberiLinijuForm(korisnik);
            olf1.ShowDialog();
            this.Close();
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            string vrstaKarte = "Regularna";
            if (studentskaRadioButton.Checked)
            {
                vrstaKarte = "Studentska";
            }
            else if (umirovljenikRdioButton.Checked)
            {
                vrstaKarte = "Umirovljenička";
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
                    cijena = izracunCijene,
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
                MessageBox.Show($"Uspješno ste rezervirali kartu na relaciji {linija.polaziste} - {linija.odrediste}. Ukupna cijena je: {izracunCijene} HRK.");
                this.Close();
            }

            string povratnaString;
            string prtljagaString;

            if (povratnaKartaCheckBox.Checked) 
            {
                povratnaString = "Da";
            }
            else 
            {
                povratnaString = "Ne";
            }

            if (prtljagaCheckBox.Checked) 
            {
                prtljagaString = "Da";
            }
            else 
            {
                prtljagaString = "Ne";
            }
            using (RacunReportForm rrf = new RacunReportForm(Convert.ToString(korisnik.korisnik_id),
                autoprijevoznikTextBox.Text, polazisteTextBox.Text, 
                odredisteTextBox.Text, vrstaKarte,
                textboxCijena.Text, linija.datum_i_vrijeme_polaska,
                povratnaString, prtljagaString)) 
            {
                rrf.ShowDialog();
            }
        }

        private void KupiKartuForm_Load(object sender, EventArgs e)
        {
            polazisteTextBox.Text = linija.polaziste;
            odredisteTextBox.Text = linija.odrediste;
            udaljenostTextBox.Text = linija.udaljenost.ToString();
            izracunCijene = int.Parse(udaljenostTextBox.Text) * 0.6;
            izracunCijene = Math.Round(izracunCijene, 2);
            textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
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

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void studentskaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (studentskaRadioButton.Checked == true)
            {
                izracunCijene *= 0.5;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
            else
            {
                izracunCijene /= 0.5;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
        }

        private void umirovljenikRdioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (umirovljenikRdioButton.Checked == true)
            {
                izracunCijene *= 0.7;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
            else
            {
                izracunCijene /= 0.7;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
        }

        private void povratnaKartaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (povratnaKartaCheckBox.Checked == true)
            {
                izracunCijene *= 1.9;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
            else
            {
                izracunCijene /= 1.9;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
        }

        private void prtljagaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (prtljagaCheckBox.Checked == true)
            {
                izracunCijene *= 1.1;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
            else
            {
                izracunCijene /= 1.1;
                izracunCijene = Math.Round(izracunCijene, 2);
                textboxCijena.Text = Convert.ToString(izracunCijene) + " Kn";
            }
        }
    }
}
