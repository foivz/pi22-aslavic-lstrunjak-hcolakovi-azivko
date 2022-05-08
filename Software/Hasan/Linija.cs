using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasan
{
    public class Linija
    {
        public int ID { get; set; }
        public string BrojLinije { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public double Udaljenost { get; set; }
        public string Autoprijevoznik { get; set; }

        public Linija(int id, string brojLinije, string polaziste, string odrediste, DateTime vrijemePolaska, double udaljenost, string autoprijevoznik)
        {
            ID = id;
            BrojLinije = brojLinije;
            Polaziste = polaziste;
            Odrediste = odrediste;
            VrijemePolaska = vrijemePolaska;
            Udaljenost = udaljenost;
            Autoprijevoznik = autoprijevoznik;
        }

    }
}
