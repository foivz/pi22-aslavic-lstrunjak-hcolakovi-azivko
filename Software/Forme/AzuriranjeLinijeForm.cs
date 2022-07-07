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
    public partial class AzuriranjeLinijeForm : Form
    {
        Linija linija;
        List<string> autoprijevoznici = new List<string>();
        public AzuriranjeLinijeForm(Linija odabranaLinija)
        {
            InitializeComponent();
            linija = odabranaLinija;
        }

        public AzuriranjeLinijeForm()
        {
            InitializeComponent();
        }

        private void AzuriranjeLinijeForm_Load(object sender, EventArgs e)
        {
            brojLinijeTextBox.Text = linija.broj_linije;
            polazisteTextBox.Text = linija.polaziste;
            odredisteTextBox.Text = linija.odrediste;
            vrijemePolaskaTextBox.Text = linija.datum_i_vrijeme_polaska;
            udaljenostTextBox.Text = linija.udaljenost.ToString();
            string prijevoznik = "";
            using (var context = new LinkBusEntities())
            {
                foreach (Autoprijevoznik autoprijevoznik in context.Autoprijevoznik)
                {
                    if(autoprijevoznik.autoprijevoznik_id == linija.autoprijevoznik_id)
                    {
                        prijevoznik = autoprijevoznik.naziv_prijevoznika;
                    }
                    autoprijevoznici.Add(autoprijevoznik.naziv_prijevoznika);
                }

                autoprijevozniciComboBox.DataSource = null;
                autoprijevozniciComboBox.DataSource = autoprijevoznici;
                autoprijevozniciComboBox.SelectedIndex = autoprijevozniciComboBox.FindStringExact(prijevoznik.ToString());
            }
            brojMjestaTextBox.Text = linija.broj_mjesta.ToString();
            brojSlobodnihMjestaTextBox.Text = linija.broj_slobodnih_mjesta.ToString();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void azurirajButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(int.Parse(brojSlobodnihMjestaTextBox.Text) > int.Parse(brojMjestaTextBox.Text))
                {
                    throw new Iznimke.Exception("Broj slobodnih mjesta ne može biti veći od ukupnog broja mjesta!"); 
                }

                using(var context = new LinkBusEntities())
                {
                    context.Linija.Attach(linija);
                    linija.datum_i_vrijeme_polaska = vrijemePolaskaTextBox.Text;

                    int autoprijevoznik_id = 0;
                    foreach(Autoprijevoznik autoprijevoznik in context.Autoprijevoznik)
                    {
                        if(autoprijevoznik.naziv_prijevoznika == autoprijevozniciComboBox.SelectedItem.ToString())
                        {
                            autoprijevoznik_id = autoprijevoznik.autoprijevoznik_id;
                        }
                    }

                    linija.autoprijevoznik_id = autoprijevoznik_id;
                    linija.broj_mjesta = int.Parse(brojMjestaTextBox.Text);
                    linija.broj_slobodnih_mjesta = int.Parse(brojSlobodnihMjestaTextBox.Text);
                    context.SaveChanges();
                    MessageBox.Show("Uspješno ste ažurirali liniju!");
                    this.Close();
                }

            }
            catch (Iznimke.Exception ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
