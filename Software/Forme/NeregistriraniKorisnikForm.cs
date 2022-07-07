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
    public partial class NeregistriraniKorisnikForm : Form
    {
        public NeregistriraniKorisnikForm()
        {
            InitializeComponent();
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForm = new Form1();
            this.Hide();
            pocetnaForm.ShowDialog();
        }

        private void registrirajSeButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
        }

        public object DohvatiLinije()
        {
            using (var context = new LinkBusEntities())
            {
                return context.Linija.ToList();
            }
        }

        public void PopunjeneLinije()
        {
            foreach (DataGridViewRow row in popisLinijaDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[8].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void NeregistriraniKorisnikForm_Load(object sender, EventArgs e)
        {
            using(var context = new LinkBusEntities())
            {
                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = DohvatiLinije();
                PopunjeneLinije();

                popisLinijaDataGridView.Columns["linija_id"].Visible = false;
                popisLinijaDataGridView.Columns["broj_linije"].Visible = false;
                popisLinijaDataGridView.Columns["autoprijevoznik_id"].Visible = false;
                popisLinijaDataGridView.Columns["Autoprijevoznik"].Visible = false;
                popisLinijaDataGridView.Columns["Karta"].Visible = false;
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Linija> linije = new List<Linija>();
            using(var context = new LinkBusEntities())
            {
                foreach(Linija linija in context.Linija)
                {
                    if(linija.odrediste.StartsWith(searchTextBox.Text))
                    {
                        linije.Add(linija);
                    }
                }

                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = linije;
                PopunjeneLinije();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(popisLinijaDataGridView.CurrentRow == null)
                {
                    throw new Iznimke.Exception("Morate odabrati liniju za prikaz njenih detalja!");
                }

                Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;
                DetaljiLinijeForm detaljiLinije = new DetaljiLinijeForm(linija);
                detaljiLinije.ShowDialog();
            }
            catch(Iznimke.Exception ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
