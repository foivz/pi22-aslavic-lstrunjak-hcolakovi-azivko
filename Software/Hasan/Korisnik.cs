using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasan
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string BrojMobitela { get; set; }
        public UlogaKorisnika.Uloga Uloga { get; set; }

        public Korisnik(string ime, string prezime, string korisnickoIme, string lozinka, string brojMobitela, UlogaKorisnika.Uloga uloga)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            BrojMobitela = brojMobitela;
            Uloga = uloga;
        }

    }
}
