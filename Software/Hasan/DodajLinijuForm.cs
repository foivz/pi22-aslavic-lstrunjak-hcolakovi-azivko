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
    public partial class DodajLinijuFormadad : Form
    {
        Repozitorij repozitorij = new Repozitorij();
        public DodajLinijuFormadad()
        {
            InitializeComponent();
        }

        private void dodajLinijuButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string brojLinije = brojLinijeTextBox.Text;
            string polaziste = polazisteTextBox.Text;
            string odrediste = odredisteTextBox.Text;
            DateTime datumPolaska = dateTimePicker.Value;
            double udaljenost = double.Parse(udaljenostTextBox.Text);
            string autoprijevoznik = autoprijevoznikTextBox.Text;

            Linija linija = new Linija(id, brojLinije, polaziste, odrediste, datumPolaska, udaljenost, autoprijevoznik);
            //Repozitorij.DodajNovuLiniju(linija);
            repozitorij.DodajNovuLiniju(linija);
            MessageBox.Show("Uspješno ste dodali liniju!");
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
