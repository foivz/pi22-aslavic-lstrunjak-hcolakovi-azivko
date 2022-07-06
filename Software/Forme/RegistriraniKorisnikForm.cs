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
    public partial class RegistriraniKorisnikForm : Form
    {
        Korisnik korisnik;
        public RegistriraniKorisnikForm(Korisnik logiranKorisnik)
        {
            InitializeComponent();
            korisnik = logiranKorisnik;
        }

        private void odjaviSeButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        public void SkriveneKolone()
        {
            popisLinijaDataGridView.Columns["linija_id"].Visible = false;
            popisLinijaDataGridView.Columns["Autoprijevoznik"].Visible = false;
            popisLinijaDataGridView.Columns["Karta"].Visible = false;
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;

            using(var context = new LinkBusEntities())
            {
                foreach(Linija item in context.Linija)
                {
                    if(item.linija_id == linija.linija_id)
                    {
                        if(item.broj_slobodnih_mjesta == 0)
                        {
                            MessageBox.Show("Ne možete kupiti kartu za tu liniju jer nema više slobodnih mjesta!");
                            break;
                        }
                        else
                        {
                            KupiKartuForm kupiKartuForm = new KupiKartuForm(korisnik, linija);
                            kupiKartuForm.ShowDialog();
                        }
                    }
                }
            }
        }

        private void RegistriraniKorisnikForm_Load(object sender, EventArgs e)
        {
            using(var context = new LinkBusEntities())
            {
                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = context.Linija.ToList();
                foreach (DataGridViewRow row in popisLinijaDataGridView.Rows)
                {
                    if (Convert.ToInt32(row.Cells[8].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                SkriveneKolone();
            }
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            List<Linija> linije = new List<Linija>();
            using (var context = new LinkBusEntities())
            {
                foreach (Linija linija in context.Linija)
                {
                    if(linija.polaziste.Contains(polazisteTextBox.Text) && linija.odrediste.Contains(odredisteTextBox.Text))
                    {
                        linije.Add(linija);
                    }
                }

                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = linije;
                SkriveneKolone();
            }
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            List<Linija> linije = new List<Linija>();
            string filtriranDatum = dateTimePicker.Value.ToShortDateString();
            using (var context = new LinkBusEntities())
            {
                foreach(Linija linija in context.Linija)
                {
                    string[] splitanDatum = linija.datum_i_vrijeme_polaska.Split(' ');

                    if (splitanDatum[0] == filtriranDatum)
                    {
                        linije.Add(linija);
                    }
                }

                popisLinijaDataGridView.DataSource = null;
                popisLinijaDataGridView.DataSource = linije;
                SkriveneKolone();
            }
        }
    }
}
