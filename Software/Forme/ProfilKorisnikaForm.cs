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

            using(var context = new LinkBusEntities())
            {
                foreach(Karta item in context.Karta)
                {
                    if(item.korisnik_id == korisnik.korisnik_id)
                    {
                        listaKarata.Add(item);
                    }
                }

                povijestPutovanjaDataGridView.DataSource = null;
                povijestPutovanjaDataGridView.ReadOnly = true;
                povijestPutovanjaDataGridView.DataSource = listaKarata;

                if(this.povijestPutovanjaDataGridView.Rows.Count == 0)
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
    }
}
