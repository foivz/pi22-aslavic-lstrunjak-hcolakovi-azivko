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
    public partial class ProfilKorisnikaForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        Korisnik korisnik;
        public ProfilKorisnikaForm(Korisnik logiraniKorisnik)
        {
            InitializeComponent();
            korisnik = logiraniKorisnik;
        }

        private void ProfilKorisnikaForm_Load(object sender, EventArgs e)
        {
            labelEmail.Visible = false;
            labelBrojMobitela.Visible = false;
            textboxIme.Text = korisnik.ime;
            textboxPrezime.Text = korisnik.prezime;
            textboxEmail.Text = korisnik.email;
            textboxBrojMobitela.Text = korisnik.broj_mobitela;

            using (var context = new LinkBusEntities())
            {
                var query = from k in context.Karta
                            from a in context.Autoprijevoznik
                            from l in context.Linija
                            where k.korisnik_id == korisnik.korisnik_id
                            where k.Linija.linija_id == l.linija_id
                            where l.Autoprijevoznik.autoprijevoznik_id == a.autoprijevoznik_id
                            select new {a.naziv_prijevoznika, l.broj_linije, l.polaziste, l.odrediste, l.datum_i_vrijeme_polaska, k.povratna, k.prtljaga, k.vrsta_karte, k.cijena };

                dgvPovijestPutovanja.DataSource = null;
                dgvPovijestPutovanja.ReadOnly = true;
                dgvPovijestPutovanja.DataSource = query.ToList();

                dgvPovijestPutovanja.Columns[0].HeaderText = "Autoprijevoznik";
                dgvPovijestPutovanja.Columns[1].HeaderText = "Broj linije";
                dgvPovijestPutovanja.Columns[2].HeaderText = "Polazište";
                dgvPovijestPutovanja.Columns[3].HeaderText = "Odredište";
                dgvPovijestPutovanja.Columns[4].HeaderText = "Datum i vrijeme polaska";
                dgvPovijestPutovanja.Columns[5].HeaderText = "Povratna karta";
                dgvPovijestPutovanja.Columns[6].HeaderText = "Prtljaga";
                dgvPovijestPutovanja.Columns[7].HeaderText = "Vrsta karte";
                dgvPovijestPutovanja.Columns[8].HeaderText = "Cijena karte";

                if (this.dgvPovijestPutovanja.Rows.Count == 0)
                {
                    label5.Visible = false;
                    label6.Text = "Niste kupili nijednu kartu!";
                    label6.Visible = true;
                }


            }

        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNav_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void buttonNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void buttonNav_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonPohrani.Visible = true;
            textboxIme.ReadOnly = false;
            textboxPrezime.ReadOnly = false;
            textboxEmail.ReadOnly = false;
            textboxBrojMobitela.ReadOnly = false;
        }

        private void buttonPohrani_Click(object sender, EventArgs e)
        {
            int i = 0;
            string email = textboxEmail.Text;
            string brojMobitela = textboxBrojMobitela.Text;
            string ime = textboxIme.Text;
            string prezime = textboxPrezime.Text;
            using (var context = new LinkBusEntities())
            {
                try
                {
                    if (brojMobitela.Length > 11 || brojMobitela.Length < 9)
                    {
                        labelBrojMobitela.Visible = true;
                        i++;
                    }
                    if (email.Length > 50 || !email.Contains("@"))
                    {
                        labelEmail.Visible = true;
                        i++;
                    }
                    if (i > 0)
                    {
                        throw new Iznimke.InvalidInputException();
                    }
                }
                catch (Iznimke.InvalidInputException)
                {
                    if (ime == string.Empty || prezime == string.Empty || email == string.Empty || brojMobitela == string.Empty)
                    {
                        MessageBox.Show("Morate popuniti sva polja!");
                    }
                    return;
                }

                Korisnik kor = context.Korisnik.Where(k => k.korisnik_id == korisnik.korisnik_id).FirstOrDefault();
                kor.ime = textboxIme.Text;
                kor.prezime = textboxPrezime.Text;
                kor.email = textboxEmail.Text;
                kor.broj_mobitela = textboxBrojMobitela.Text;
                context.SaveChanges();
            }

                buttonPohrani.Visible = false;
                textboxIme.ReadOnly = true;
                textboxPrezime.ReadOnly = true;
                textboxEmail.ReadOnly= true;
                textboxBrojMobitela.ReadOnly= true;
                MessageBox.Show("Uspješno ste ažurirali profil!");

        }
    }
}
