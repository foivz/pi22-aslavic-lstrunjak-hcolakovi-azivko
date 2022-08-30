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
    public partial class OdaberiLinijuForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        Korisnik korisnik;
        public OdaberiLinijuForm(Korisnik logiraniKorisnik)
        {
            InitializeComponent();
            korisnik = logiraniKorisnik;
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OdaberiLinijuForm_Load(object sender, EventArgs e)
        {
            using(var context = new LinkBusEntities())
            {
                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = context.Linija.ToList();
                popisLinijaDataGridView.Columns["linija_id"].Visible = false;
                popisLinijaDataGridView.Columns["autoprijevoznik_id"].Visible = false;
                popisLinijaDataGridView.Columns["Autoprijevoznik"].Visible = false;
                popisLinijaDataGridView.Columns["Karta"].Visible = false;
            }
            popisLinijaDataGridView.Columns["broj_linije"].HeaderText = "Broj linije";
            popisLinijaDataGridView.Columns["polaziste"].HeaderText = "Polaziste";
            popisLinijaDataGridView.Columns["odrediste"].HeaderText = "Odrediste";
            popisLinijaDataGridView.Columns["datum_i_vrijeme_polaska"].HeaderText = "Datum i vrijeme polaska";
            popisLinijaDataGridView.Columns["udaljenost"].HeaderText = "Udaljenost";
            popisLinijaDataGridView.Columns["broj_mjesta"].HeaderText = "Broj mjesta";
            popisLinijaDataGridView.Columns["broj_slobodnih_mjesta"].HeaderText = "Broj slobodnih mjesta";
        }

        private void odaberiLinijuButton_Click(object sender, EventArgs e)
        {
            Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;
            KupiKartuForm kupiKartu = new KupiKartuForm(korisnik, linija);
            this.Hide();
            kupiKartu.ShowDialog();
            this.Close();
        }

        private void buttonNav_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void buttonNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void buttonNav_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
