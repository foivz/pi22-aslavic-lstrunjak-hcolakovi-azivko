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
    public partial class NeregistriraniKorisnikForm : Form
    {
        Repozitorij repozitorij = new Repozitorij();
        public NeregistriraniKorisnikForm()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repozitorij.DohvatiLinije();
            //dataGridView1.DataSource = Repozitorij.listaLinija;
        }

        private void NeregistriraniKorisnikForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void registrirajSeButton_Click(object sender, EventArgs e)
        {
            RegisterForm registracija = new RegisterForm();
            this.Hide();
            registracija.ShowDialog();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetnaStranica = new PocetnaForm();
            this.Hide();
            pocetnaStranica.ShowDialog();
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            List<Linija> noveLinije = new List<Linija>();

            foreach (Linija item in Repozitorij.listaLinija)
            {
                if (item.Odrediste == searchTextBox.Text || item.Polaziste == searchTextBox.Text)
                {
                    noveLinije.Add(item);
                }
            }

            if (noveLinije.Count != 0)
            {
                dataGridView1.DataSource = noveLinije;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Repozitorij.listaLinija;
            }
        }
    }
}
