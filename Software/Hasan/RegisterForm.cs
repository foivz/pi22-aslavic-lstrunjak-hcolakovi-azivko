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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registrirajSeButton_Click(object sender, EventArgs e)
        {
            Repozitorij repozitorij = new Repozitorij();
            string Ime = imeTextBox.Text;
            string Prezime = prezimeTextBox.Text;
            string BrojMobitela = brMobitelaTextBox.Text;
            string KorisnickoIme = korImeTextBox.Text;
            string Lozinka = lozinkaTextBox.Text;

            if(repozitorij.Registriraj(Ime, Prezime, KorisnickoIme, Lozinka, BrojMobitela, UlogaKorisnika.Uloga.RegistriraniKorisnik) == true)
            {
                MessageBox.Show("Uspješno ste se registrirali!");
                LogInRegistriraniKorisnikForm logiranje = new LogInRegistriraniKorisnikForm();
                this.Hide();
                logiranje.ShowDialog();
            }
            else
            {
                MessageBox.Show("Taj email je zauzet!");
            }
            imeTextBox.Clear();
            prezimeTextBox.Clear();
            brMobitelaTextBox.Clear();
            korImeTextBox.Clear();
            lozinkaTextBox.Clear();
        }

        private void prijaviSeButton_Click(object sender, EventArgs e)
        {
            LogInRegistriraniKorisnikForm logiranje = new LogInRegistriraniKorisnikForm();
            this.Hide();
            logiranje.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetna = new PocetnaForm();
            this.Hide();
            pocetna.ShowDialog();
        }
    }
}
