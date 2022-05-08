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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void prijaviSeButton_Click(object sender, EventArgs e)
        {
            Repozitorij repozitorij = new Repozitorij();
            string korisnickoIme = korImeTextBox.Text;
            string lozinka = lozinkaTextBox.Text;


            if(repozitorij.VratiAdmine(korisnickoIme, lozinka) == null)
            {
                MessageBox.Show("Unijeli ste krive podatke!");
            }
            else
            {
                AdminForm adminForma = new AdminForm();
                this.Hide();
                adminForma.ShowDialog();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetna = new PocetnaForm();
            this.Hide();
            pocetna.ShowDialog();
        }
    }
}
