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
    public partial class RegisterForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        LoginForm loginForm = new LoginForm();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void prijaviSeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            NeregistriraniKorisnikForm neregistriraniKorisnikForm = new NeregistriraniKorisnikForm();
            this.Hide();
            neregistriraniKorisnikForm.ShowDialog();
        }

        private void registirajSeButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            labelPhoneNumber.Visible = false;
            labelEmail.Visible = false;
            labelPassword.Visible = false;
            labelUsername.Visible = false;

            bool pronadjen = false;
            using (var context = new LinkBusEntities())
            {
                string ime = imeTextBox.Text;
                string prezime = prezimeTextBox.Text;
                string email = emailTextBox.Text;
                string korisnickoIme = korisnickoImeTextBox.Text;
                string lozinka = lozinkaTextBox.Text;
                string brojMobitela = brojMobitelaTextBox.Text;

                try
                {
                    if (brojMobitela.Length > 25 || brojMobitela.Length < 9)
                    {
                        labelPhoneNumber.Visible = true;
                        i++;
                    }
                    if (email.Length > 50 || !email.Contains("@"))
                    {
                        labelEmail.Visible = true;
                        i++;
                    }
                    if (lozinka.Length > 25 || lozinka.Length < 8)
                    {
                        labelPassword.Visible = true;
                        i++;
                    }
                    if (i > 0) 
                    {
                        throw new Iznimke.InvalidInputException();
                    }
                }
                catch (Iznimke.InvalidInputException)
                {
                    if (ime == string.Empty || prezime == string.Empty || email == string.Empty || korisnickoIme == string.Empty || lozinka == string.Empty || brojMobitela == string.Empty)
                    {
                        MessageBox.Show("Morate popuniti sva polja!");
                    }
                    return;
                }

                foreach (Korisnik korisnik in context.Korisnik)
                {
                    if(korisnickoIme == korisnik.korisnicko_ime)
                    {
                        pronadjen = true;
                        labelUsername.Visible = true;
                        break;
                    }
                }

                if(pronadjen == false)
                {
                    Korisnik korisnik = new Korisnik
                    {
                        ime = ime,
                        prezime = prezime,
                        email = email,
                        korisnicko_ime = korisnickoIme,
                        lozinka = lozinka,
                        broj_mobitela = brojMobitela,
                        uloga_korisnika_id = 2
                    };

                    context.Korisnik.Add(korisnik);
                    context.SaveChanges();
                    MessageBox.Show("Uspješno ste se registrirali!");
                }
            }
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
    }
}
