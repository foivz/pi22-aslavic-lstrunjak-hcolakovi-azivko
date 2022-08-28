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
    public partial class DetaljiPutovanjaForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        private Korisnik odabraniKorisnik;
        //private Karta karta;
        public DetaljiPutovanjaForm(Korisnik odabrani)
        {
            InitializeComponent();
            odabraniKorisnik = odabrani;
            //karta = odabranoPutovanje;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
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

        private void DetaljiPutovanjaForm_Load(object sender, EventArgs e)
        {
            using (var context = new LinkBusEntities())
            {
                var query = from k in context.Karta
                            from a in context.Autoprijevoznik
                            from l in context.Linija
                            where k.korisnik_id == odabraniKorisnik.korisnik_id
                            where k.Linija.linija_id == l.linija_id
                            where l.Autoprijevoznik.autoprijevoznik_id == a.autoprijevoznik_id
                            select new { k.karta_id, a.naziv_prijevoznika, l.broj_linije, l.polaziste, l.odrediste, l.datum_i_vrijeme_polaska, k.povratna, k.prtljaga, k.vrsta_karte, k.cijena };
            
            }
        }
    }
}
