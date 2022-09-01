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
    public partial class RacunReportForm : Form
    {
        string _korisnikID, _nazivPrijevoznika, 
            _polaziste, _odrediste, _vrstaKarte, 
            _cijena, _datumVrijemePolaska, 
            _povratna, _prtljaga;
        public RacunReportForm(string korisnikID, string nazivPrijevoznika, 
            string polaziste, string odrediste, string vrstaKarte, string cijena, 
            string datumVrijemePolaska, string povratna, string prtljaga)
        {
            InitializeComponent();
            _korisnikID = korisnikID;
            _nazivPrijevoznika = nazivPrijevoznika;
            _polaziste = polaziste;
            _odrediste = odrediste;
            _vrstaKarte = vrstaKarte;
            _cijena = cijena;
            _datumVrijemePolaska = datumVrijemePolaska;
            _povratna = povratna;
            _prtljaga = prtljaga;
        }

        private void RacunReportForm_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pKorisnikID", _korisnikID),
                new Microsoft.Reporting.WinForms.ReportParameter("pNazivPrijevoznika", _nazivPrijevoznika),
                new Microsoft.Reporting.WinForms.ReportParameter("pPolaziste", _polaziste),
                new Microsoft.Reporting.WinForms.ReportParameter("pOdrediste", _odrediste),
                new Microsoft.Reporting.WinForms.ReportParameter("pDatumVrijemePolaska", _datumVrijemePolaska),
                new Microsoft.Reporting.WinForms.ReportParameter("pPovratna", _povratna),
                new Microsoft.Reporting.WinForms.ReportParameter("pPrtljaga", _prtljaga),
                new Microsoft.Reporting.WinForms.ReportParameter("pVrstaKarte", _vrstaKarte),
                new Microsoft.Reporting.WinForms.ReportParameter("pCijena", _cijena)

            };
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\Z1V3\Desktop\PI_Projekt\pi22-aslavic-lstrunjak-hcolakovi-azivko\Software\Forme\KartaRacunReport.rdlc";
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
