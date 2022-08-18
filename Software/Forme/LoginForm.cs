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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForm = new Form1();
            this.Hide();
            pocetnaForm.ShowDialog();
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
                    }
                    else if (korisnickoImeTextBox.Text == korisnik.korisnicko_ime && lozinkaTextBox.Text == korisnik.lozinka && korisnik.uloga_korisnika_id != 1)
                    {
                        pronadjen = true;
                        RegistriraniKorisnikForm registriraniKorisnik = new RegistriraniKorisnikForm(korisnik);
                        this.Hide();
                        registriraniKorisnik.ShowDialog();
                    }
                }

                if (pronadjen == false)
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu točni!");
                }
            }
        }
    }
}
