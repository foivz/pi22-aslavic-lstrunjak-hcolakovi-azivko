using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class UCputovanja : UserControl
    {
        public UCputovanja()
        {
            InitializeComponent();
        }

        #region Properties
        private string _broj_karte;
        private string _naziv_prijevoznika;
        private string _datum_i_vrijeme_polaska;
        private string _polaziste;
        private string _odrediste;
        private bool _povratna;
        private bool _prtljaga;
        private string _vrsta_karte;
        private string _cijena;

        [Category("Custom props")]
        public string Broj_karte
        {
            get { return _broj_karte; }
            set { _broj_karte = value; labelBrojKarte.Text = value; }
        }

        [Category("Custom props")]
        public string Naziv_prijevoznika
        {
            get { return _naziv_prijevoznika; }
            set { _naziv_prijevoznika = value; textBoxNazivPrijevoznika.Text = value; }
        }

        [Category("Custom props")]
        public string Datum_i_vrijeme_polaska
        {
            get { return _datum_i_vrijeme_polaska; }
            set { _datum_i_vrijeme_polaska= value; textBoxDatumVrijemePolaska.Text = value; }
        }

        [Category("Custom props")]
        public string Polaziste
        {
            get { return _polaziste; }
            set { _polaziste = value; textBoxPolaziste.Text = value; }
        }

        [Category("Custom props")]
        public string Odrediste
        {
            get { return _odrediste; }
            set { _odrediste = value; textBoxOdrediste.Text = value; }
        }

        [Category("Custom props")]
        public bool Povratna
        {
            get { return _povratna; }
            set { _povratna = value; checkBoxPovratna.Checked = value; }
        }

        [Category("Custom props")]
        public bool Prtljaga
        {
            get { return _prtljaga; }
            set { _prtljaga = value; checkBoxPrtljaga.Checked = value; }
        }

        [Category("Custom props")]
        public string Vrsta_karte
        {
            get { return _vrsta_karte; }
            set { _vrsta_karte = value; textBoxVrstaKarte.Text = value; }
        }

        [Category("Custom props")]
        public string Cijena
        {
            get { return _cijena; }
            set { _cijena = value; textBoxCijena.Text = value; }
        }

        #endregion
    }
}
