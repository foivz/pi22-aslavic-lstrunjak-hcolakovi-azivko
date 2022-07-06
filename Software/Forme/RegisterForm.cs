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
            bool pronadjen = false;
            bool greska = false;
            using(var context = new LinkBusEntities())
            {
                string ime = imeTextBox.Text;
                string prezime = prezimeTextBox.Text;
                string email = emailTextBox.Text;
                string korisnickoIme = korisnickoImeTextBox.Text;
                string lozinka = lozinkaTextBox.Text;
                string brojMobitela = brojMobitelaTextBox.Text;

                if (ime == string.Empty || prezime == string.Empty || email == string.Empty || korisnickoIme == string.Empty || lozinka == string.Empty || brojMobitela == string.Empty)
                {
                    greska = true;
                    MessageBox.Show("Morate popuniti sva polja!");
                }
                else if (brojMobitela.Length > 25)
                {
                    greska = true;
                    MessageBox.Show("Broj mobitela mora imati manje od 25 znakova!");
                }
                else if (email.Length > 50)
                {
                    greska = true;
                    MessageBox.Show("Email mora imati manje od 50 znakova!");
                }
                else if (lozinka.Length > 25)
                {
                    greska = true;
                    MessageBox.Show("Lozinka mora imati manje od 25 znakova!");
                }


                foreach (Korisnik korisnik in context.Korisnik)
                {
                    if(korisnickoIme == korisnik.korisnicko_ime)
                    {
                        pronadjen = true;
                        MessageBox.Show("Korisničko ime koje ste unijeli je zauzeto!");
                        break;
                    }
                }

                if(pronadjen == false && greska == false)
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
    }
}
