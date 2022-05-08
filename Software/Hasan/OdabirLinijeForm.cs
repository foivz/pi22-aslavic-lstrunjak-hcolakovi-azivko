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
    public partial class OdabirLinijeForm : Form
    {
        Repozitorij repozitorij = new Repozitorij();
        public OdabirLinijeForm()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = Repozitorij.listaLinija;
            dataGridView1.DataSource = repozitorij.DohvatiLinije();
        }

        private void OdabirLinijeForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private Linija DohvatiLiniju()
        {
            if (dataGridView1.CurrentRow != null)
            {
                return dataGridView1.CurrentRow.DataBoundItem as Linija;
            }
            return null;
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            var linija = DohvatiLiniju();
            //Linija linija = dataGridView1.CurrentRow.DataBoundItem as Linija;

            if (linija == null)
            {
                MessageBox.Show("Morate odabrati liniju!");
            }
            else
            {
                KupiKartuForm kupiKartu = new KupiKartuForm(linija);
                this.Hide();
                kupiKartu.ShowDialog();
                Osvjezi();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
