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
    public partial class AdminForm : Form
    {
        Repozitorij repozitorij = new Repozitorij();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void odjaviSeButton_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetna = new PocetnaForm();
            this.Hide();
            pocetna.ShowDialog();
        }

        private void dodajLinijuButton_Click(object sender, EventArgs e)
        {
            DodajLinijuFormadad dodajLiniju = new DodajLinijuFormadad();
            dodajLiniju.ShowDialog();
            Osvjezi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = Repozitorij.listaLinija;
            dataGridView1.DataSource = repozitorij.DohvatiLinije();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void obrisiLinijuButton_Click(object sender, EventArgs e)
        {
            Linija linija = dataGridView1.CurrentRow.DataBoundItem as Linija;
            repozitorij.ObrisiLiniju(linija);
            //Repozitorij.ObrisiLiniju(linija);
            Osvjezi();
        }

        private Linija DohvatiLiniju()
        {
            if(dataGridView1.CurrentRow != null)
            {
                return dataGridView1.CurrentRow.DataBoundItem as Linija;
            }
            return null;
        }

        private void azurirajLinijuButton_Click(object sender, EventArgs e)
        {
            var linija = DohvatiLiniju();
            //Linija linija = dataGridView1.CurrentRow.DataBoundItem as Linija;

            if (linija == null)
            {
                MessageBox.Show("Morate odabrati liniju!");
            }
            else
            {
                AzurirajLinijuForm forma = new AzurirajLinijuForm(linija);
                forma.ShowDialog();
                Osvjezi();
            }
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            List<Linija> noveLinije = new List<Linija>();

            foreach (Linija item in Repozitorij.listaLinija)
            {
                if (item.Odrediste == pretraziTextBox.Text || item.Polaziste == pretraziTextBox.Text)
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

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            List<Linija> noveLinije = new List<Linija>();
            DateTime uneseniDatum = dateTimePicker.Value.Date;

            foreach (Linija item in Repozitorij.listaLinija)
            {
                DateTime datumLinije = item.VrijemePolaska.Date;
                if (item.Odrediste == odredisteTextBox.Text && item.Polaziste == polazisteTextBox.Text && uneseniDatum == datumLinije)
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
            Korisnik korisnik = new Korisnik("Hasan", "Čolaković", "hcolakovi", "hasan123", "+385919350483", UlogaKorisnika.Uloga.Admin);
            ProfilKorisnikaForm profil = new ProfilKorisnikaForm(korisnik);
            profil.ShowDialog();
        }
    }
}
