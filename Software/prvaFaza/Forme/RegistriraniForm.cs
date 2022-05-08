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
    public partial class RegistriraniForm : Form
    {
        Repozitorij repozitorij = new Repozitorij();
        public RegistriraniForm()
        {
            InitializeComponent();
        }

        private void odjaviSeButton_Click(object sender, EventArgs e)
        {
            LogInRegistriraniKorisnikForm logiranje = new LogInRegistriraniKorisnikForm();
            this.Hide();
            logiranje.ShowDialog();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repozitorij.DohvatiLinije();
            //dataGridView1.DataSource = Repozitorij.DohvatiLinije();
        }

        private void RegistriraniForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            List<Linija> noveLinije = new List<Linija>();

            DateTime uneseniDatum = odabriteDatumDateTimePicker.Value.Date;

            foreach (Linija item in Repozitorij.listaLinija)
            {
                DateTime datumLinije = item.VrijemePolaska.Date;
                if (uneseniDatum == datumLinije)
                {
                    noveLinije.Add(item);
                }
            }

            if (noveLinije.Count != 0)
            {
                dataGridView1.DataSource = noveLinije;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Repozitorij.listaLinija;
            }
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            List<Linija> noveLinije = new List<Linija>();

            foreach (Linija item in Repozitorij.listaLinija)
            {
                if (item.Odrediste == odredisteTextBox.Text && item.Polaziste == polazisteTextBox.Text)
                {
                    noveLinije.Add(item);
                }
            }

            if (noveLinije.Count != 0)
            {
                dataGridView1.DataSource = noveLinije;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Repozitorij.listaLinija;
            }
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik("Andrija", "Živko", "azivko", "zivko123", "+385123456789", UlogaKorisnika.Uloga.RegistriraniKorisnik);
            ProfilKorisnikaForm profil = new ProfilKorisnikaForm(korisnik);
            profil.ShowDialog();
        }

        private Linija DohvatiLiniju()
        {
            if (dataGridView1.CurrentRow != null)
            {
                return dataGridView1.CurrentRow.DataBoundItem as Linija;
            }
            return null;
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            var linija = DohvatiLiniju();
            //Linija linija = dataGridView1.CurrentRow.DataBoundItem as Linija;

            if (linija == null)
            {
                MessageBox.Show("Morate odabrati liniju!");
            }
            else
            {
                KupiKartuForm kupiKartu = new KupiKartuForm(linija);
                kupiKartu.ShowDialog();
                Osvjezi();
            }
        }
    }
}
