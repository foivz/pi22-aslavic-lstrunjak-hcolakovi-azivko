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
            List<Karta> listaKarata = new List<Karta>();

            imeTextBox.Text = korisnik.ime;
            prezimeTextBox.Text = korisnik.prezime;
            emailTextBox.Text = korisnik.email;
            brojMobitelaTextBox.Text = korisnik.broj_mobitela;

            using (var context = new LinkBusEntities())
            {
                foreach (Karta item in context.Karta)
                {
                    if (item.korisnik_id == korisnik.korisnik_id)
                    {
                        listaKarata.Add(item);
                    }
                }

                povijestPutovanjaDataGridView.DataSource = null;
                povijestPutovanjaDataGridView.ReadOnly = true;
                povijestPutovanjaDataGridView.DataSource = listaKarata;

                if (this.povijestPutovanjaDataGridView.Rows.Count == 0)
                {
                    label5.Visible = false;
                    label6.Text = "Niste kupili nijednu kartu!";
                    label6.Visible = true;
                }

                povijestPutovanjaDataGridView.Columns["karta_id"].Visible = false;
                povijestPutovanjaDataGridView.Columns["korisnik_id"].Visible = false;
                povijestPutovanjaDataGridView.Columns["Korisnik"].Visible = false;
                povijestPutovanjaDataGridView.Columns["Linija"].Visible = false;
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
            imeTextBox.Enabled = true;
            prezimeTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            brojMobitelaTextBox.Enabled = true;
        }

        private void buttonPohrani_Click(object sender, EventArgs e)
        {
            using (var context = new LinkBusEntities())
            {
                Korisnik kor = context.Korisnik.Where(k => k.korisnik_id == korisnik.korisnik_id).FirstOrDefault();
                kor.ime = imeTextBox.Text;
                kor.prezime = prezimeTextBox.Text;
                kor.email = emailTextBox.Text;
                kor.broj_mobitela = brojMobitelaTextBox.Text;

                context.SaveChanges();
            }
                buttonPohrani.Visible = false;
                imeTextBox.Enabled = false;
                prezimeTextBox.Enabled = false;
                emailTextBox.Enabled = false;
                brojMobitelaTextBox.Enabled = false;
                MessageBox.Show("Uspješno ste ažurirali profil!");

        }
    }
}
