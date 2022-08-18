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
            }
        }

        private void odaberiLinijuButton_Click(object sender, EventArgs e)
        {
            Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;
            KupiKartuForm kupiKartu = new KupiKartuForm(korisnik, linija);
            this.Hide();
            kupiKartu.ShowDialog();
        }
    }
}
