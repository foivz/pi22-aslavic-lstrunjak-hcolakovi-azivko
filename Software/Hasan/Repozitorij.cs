using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasan
{
    public class Repozitorij
    {
        public static List<Korisnik> listaKorisnika = new List<Korisnik>();
        public static List<Linija> listaLinija = new List<Linija>();
        public Repozitorij()
        {
            listaKorisnika.Add(new Korisnik("Hasan", "Čolaković", "admin", "admin", "+385919350483", UlogaKorisnika.Uloga.Admin));
            listaKorisnika.Add(new Korisnik("Andrija", "Živko", "user", "user", "+38591123456", UlogaKorisnika.Uloga.RegistriraniKorisnik));
            //listaLinija.Add(new Linija(1, "L1", "Varaždin", "Čakovec", DateTime.Now, 20, "AP Varaždin"));
            //listaLinija.Add(new Linija(2, "L2", "Varaždin", "Zagreb", DateTime.Now, 80, "AP Varaždin"));
            //listaLinija.Add(new Linija(3, "L3", "Varaždin", "Slavonski Brod", DateTime.Now, 240, "Croatia bus"));
            //listaLinija.Add(new Linija(4, "L4", "Varaždin", "Krapina", DateTime.Now, 40, "Croatia bus"));
            //listaLinija.Add(new Linija(5, "L5", "Varaždin", "Novi Marof", DateTime.Now, 22, "Cazmatrans"));
            //listaLinija.Add(new Linija(6, "L6", "Varaždin", "Virovitica", DateTime.Now, 100, "AP Vraždin"));
            //listaLinija.Add(new Linija(7, "L7", "Varaždin", "Osijek", DateTime.Now, 220, "Cazmatrans"));
            //listaLinija.Add(new Linija(8, "L8", "Varaždin", "Split", DateTime.Now, 400, "Cazmatrans"));
            //listaLinija.Add(new Linija(9, "L9", "Varaždin", "Zenica", DateTime.Now, 410, "AP Vraždin"));
            //listaLinija.Add(new Linija(10, "L10", "Varaždin", "Koprivnica", DateTime.Now, 85, "AP Vraždin"));
        }

        public static bool PostojiKorisnik(string korisnickoIme)
        {
            bool postoji = false;
            foreach (Korisnik item in listaKorisnika)
            {
                if (item.KorisnickoIme == korisnickoIme)
                {
                    postoji = true;
                }
            }
            return postoji;
        }

        public Korisnik VratiAdmine(string korisnickoIme, string lozinka)
        {
            foreach(Korisnik item in listaKorisnika)
            {
                if(item.KorisnickoIme == korisnickoIme && item.Lozinka == lozinka && item.Uloga == UlogaKorisnika.Uloga.Admin)
                {
                    return item;
                }
            }
            return null;
        }

        public Korisnik VratiRegistriraneKorisnike(string korisnickoIme, string lozinka)
        {
            foreach(Korisnik item in listaKorisnika)
            {
                if (item.KorisnickoIme == korisnickoIme && item.Lozinka == lozinka && item.Uloga == UlogaKorisnika.Uloga.RegistriraniKorisnik)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Registriraj(string ime, string prezime, string korisnickoIme, string lozinka, string brojMobitela, UlogaKorisnika.Uloga uloga)
        {
            bool registriraj = false;
            if (PostojiKorisnik(korisnickoIme) == false)
            {
                Korisnik korisnik = new Korisnik(ime, prezime, korisnickoIme, lozinka, brojMobitela, uloga);
                registriraj = true;
                listaKorisnika.Add(korisnik);
                return registriraj;
            }
            return registriraj;
        }

        public void DodajNovuLiniju(Linija linija)
        {
            listaLinija.Add(linija);
        }

        public List<Linija> DohvatiLinije()
        {
            return listaLinija;
        }

        public void ObrisiLiniju(Linija linija)
        {
            listaLinija.Remove(linija);
        }

    }
}
