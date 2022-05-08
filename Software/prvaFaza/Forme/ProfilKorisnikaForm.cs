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
    public partial class ProfilKorisnikaForm : Form
    {
        public Korisnik Korisnik { get; set; }
        public ProfilKorisnikaForm(Korisnik korisnik)
        {
            Korisnik = korisnik;
            InitializeComponent();
        }

        private void ProfilKorisnikaForm_Load(object sender, EventArgs e)
        {
            imeTextBox.Text = Korisnik.Ime;
            prezimeTextBox.Text = Korisnik.Prezime;
            korImeTextBox.Text = Korisnik.KorisnickoIme;
            brMobitelaTextBox.Text = Korisnik.BrojMobitela;
            tipKorisnikaTextBox.Text = Korisnik.Uloga.ToString();


        }

        private void pocetnaButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
