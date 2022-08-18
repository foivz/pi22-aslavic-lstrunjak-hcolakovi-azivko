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
    public partial class DodavanjeLinije : Form
    {
        public List<string> autoprijevoznici = new List<string>();
        public DodavanjeLinije()
        {
            InitializeComponent();
        }

        private void DodavanjeLinije_Load(object sender, EventArgs e)
        {
            using(var context = new LinkBusEntities())
            {
                foreach(Autoprijevoznik autoprijevoznik in context.Autoprijevoznik)
                {
                    autoprijevoznici.Add(autoprijevoznik.naziv_prijevoznika);
                }

                prijevozniciComboBox.DataSource = null;
                prijevozniciComboBox.DataSource = autoprijevoznici;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void dodajLinijuButton_Click(object sender, EventArgs e)
        {
            string brojLinije = brojLinijeTextBox.Text;
            string polaziste = polazisteComboBox.SelectedItem.ToString();
            string odrediste = odredisteComboBox.SelectedItem.ToString();
            string datumPolaska = datumPolaskaTextBox.Text;
            int udaljenost = int.Parse(udaljenostTextBox.Text);
            string autoprijevoznik = prijevozniciComboBox.SelectedItem.ToString();
            int autoprijevoznik_id = 0;
            int brojMjesta = int.Parse(brojMjestaTextBox.Text);

            using(var context = new LinkBusEntities())
            {
                foreach (Autoprijevoznik item in context.Autoprijevoznik)
                {
                    if(item.naziv_prijevoznika == autoprijevoznik)
                    {
                        autoprijevoznik_id = item.autoprijevoznik_id;
                    }
                }

                Linija linija = new Linija
                {
                    broj_linije = brojLinije,
                    polaziste = polaziste,
                    odrediste = odrediste,
                    datum_i_vrijeme_polaska = datumPolaska,
                    udaljenost = udaljenost,
                    autoprijevoznik_id = autoprijevoznik_id,
                    broj_mjesta = brojMjesta,
                    broj_slobodnih_mjesta = brojMjesta
                };

                context.Linija.Add(linija);
                context.SaveChanges();
                MessageBox.Show("Uspješno ste dodali liniju!");
                this.Close();
            }
        }
    }
}
