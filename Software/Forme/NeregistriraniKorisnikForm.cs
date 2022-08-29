﻿using System;
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
        private bool mouseDown;
        private Point lastLocation;

        public NeregistriraniKorisnikForm()
        {
            InitializeComponent();
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForm = new Form1();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void registrirajSeButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
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
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
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
