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
    public partial class PocetnaForm : Form
    {
        public PocetnaForm()
        {
            InitializeComponent();
        }

        private void neregistriraniKorisnikButton_Click(object sender, EventArgs e)
        {
            NeregistriraniKorisnikForm neregistriraniKorisnik = new NeregistriraniKorisnikForm();
            this.Hide();
            neregistriraniKorisnik.ShowDialog();
        }

        private void registriraniKorisnikButton_Click(object sender, EventArgs e)
        {
            LogInRegistriraniKorisnikForm logiranje = new LogInRegistriraniKorisnikForm();
            this.Hide();
            logiranje.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            LogInForm logiranje = new LogInForm();
            this.Hide();
            logiranje.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            LogInForm adminForm = new LogInForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
