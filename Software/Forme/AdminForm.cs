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
    public partial class AdminForm : Form
    {
        Korisnik korisnik;
        public AdminForm(Korisnik logiraniKorisnik)
        {
            InitializeComponent();
            korisnik = logiraniKorisnik;
        }

        public AdminForm()
        {
            InitializeComponent();
        }

        public void SkriveneKolone()
        {
            popisLinijaDataGridView.Columns["Autoprijevoznik"].Visible = false;
            popisLinijaDataGridView.Columns["Karta"].Visible = false;
        }

        public void PopunjeneLinije()
        {
            foreach (DataGridViewRow row in popisLinijaDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[8].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void odjaviSeButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void dodajLinijuButton_Click(object sender, EventArgs e)
        {
            DodavanjeLinije dodavanjeLinije = new DodavanjeLinije();
            dodavanjeLinije.ShowDialog();
            Osvjezi();
        }

        private void azurirajLinijuButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(popisLinijaDataGridView.CurrentRow == null)
                {
                    throw new Iznimke.Exception("Odaberite onu liniju koju želite ažurirati");
                }

                Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;
                AzuriranjeLinijeForm azuriranjeLinijeForm = new AzuriranjeLinijeForm(linija);
                azuriranjeLinijeForm.ShowDialog();
            }
            catch (Iznimke.Exception ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        public void Osvjezi()
        {
            using (var context = new LinkBusEntities())
            {
                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = context.Linija.ToList();
                SkriveneKolone();
                PopunjeneLinije();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Linija> linije = new List<Linija>();
            using (var context = new LinkBusEntities())
            {
                foreach (Linija linija in context.Linija)
                {
                    if (linija.odrediste.StartsWith(searchTextBox.Text))
                    {
                        linije.Add(linija);
                    }
                }

                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = linije;
                SkriveneKolone();
                PopunjeneLinije();
            }
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            ProfilKorisnikaForm profilKorisnika = new ProfilKorisnikaForm(korisnik);
            profilKorisnika.ShowDialog();
        }

        private void obirsiLinijuButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (popisLinijaDataGridView.CurrentRow == null)
                {
                    throw new Iznimke.Exception("Morate označiti onu liniju koju želite izbrisati!");
                }

                Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;

                if (linija.broj_mjesta > linija.broj_slobodnih_mjesta)
                {
                    throw new Iznimke.Exception("Tu liniju ne možete izbrisati jer je za nju već rezervirano nekoliko karata!");
                }

                using (var context = new LinkBusEntities())
                {
                    context.Linija.Attach(linija);
                    context.Linija.Remove(linija);
                    context.SaveChanges();
                    MessageBox.Show($"Uspješno ste izbrisali liniju {linija.polaziste} - {linija.odrediste}");
                    Osvjezi();
                }
            }
            catch (Iznimke.Exception ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            List<Linija> linije = new List<Linija>();
            string filtriranDatum = dateTimePicker.Value.ToShortDateString();
            using (var context = new LinkBusEntities())
            {
                foreach (Linija linija in context.Linija)
                {
                    string[] splitanDatum = linija.datum_i_vrijeme_polaska.Split(' ');

                    if (splitanDatum[0] == filtriranDatum && linija.polaziste == polazisteTextBox.Text && linija.odrediste == odredisteTextBox.Text)
                    {
                        linije.Add(linija);
                    }
                }

                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = linije;
                SkriveneKolone();
                PopunjeneLinije();
            }
        }
    }
}
