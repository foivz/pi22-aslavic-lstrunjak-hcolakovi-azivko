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
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForm = new Form1();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void prijaviSeButton_Click(object sender, EventArgs e)
        {
            bool pronadjen = false;

            using (var context = new LinkBusEntities())
            {
                if (korisnickoImeTextBox.Text == string.Empty || lozinkaTextBox.Text == string.Empty)
                {
                    pronadjen = true;
                    MessageBox.Show("Morate unijeti korisničko ime i lozinku!");
                }

                foreach (Korisnik korisnik in context.Korisnik)
                {
                    if (korisnickoImeTextBox.Text == korisnik.korisnicko_ime && lozinkaTextBox.Text == korisnik.lozinka && korisnik.uloga_korisnika_id == 1)
                    {
                        pronadjen = true;
                        AdminForm adminForm = new AdminForm(korisnik);
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else if (korisnickoImeTextBox.Text == korisnik.korisnicko_ime && lozinkaTextBox.Text == korisnik.lozinka && korisnik.uloga_korisnika_id != 1)
                    {
                        pronadjen = true;
                        RegistriraniKorisnikForm registriraniKorisnik = new RegistriraniKorisnikForm(korisnik);
                        this.Hide();
                        registriraniKorisnik.ShowDialog();
                        this.Close();
                    }
                }

                if (pronadjen == false)
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu točni!");
                }
            }
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
    }
}
