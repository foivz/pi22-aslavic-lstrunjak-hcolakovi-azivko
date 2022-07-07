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
    public partial class DetaljiLinijeForm : Form
    {
        Linija linija;
        public DetaljiLinijeForm(Linija odabranaLinija)
        {
            InitializeComponent();
            linija = odabranaLinija;
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetaljiLinijeForm_Load(object sender, EventArgs e)
        {
            brojLinijeTextBox.Text = linija.broj_linije;
            polazisteTextBox.Text = linija.polaziste;
            odredisteTextBox.Text = linija.odrediste;
            datumPolaskaTextBox.Text = linija.datum_i_vrijeme_polaska;
            udaljenostTextBox.Text = linija.udaljenost.ToString();
            using(var context = new LinkBusEntities())
            {
                foreach(Autoprijevoznik autoprijevoznik in context.Autoprijevoznik)
                {
                    if(autoprijevoznik.autoprijevoznik_id == linija.autoprijevoznik_id)
                    {
                        autoprijevoznikTextBox.Text = autoprijevoznik.naziv_prijevoznika;
                    }
                }
            }
            brojMjestaTextBox.Text = linija.broj_mjesta.ToString();
            brojSlobodnihMjestaTextBox.Text = linija.broj_slobodnih_mjesta.ToString();
            double cijena = linija.udaljenost * 0.7;
            cijenaTextBox.Text = cijena.ToString() + " HRK";
        }
    }
}
