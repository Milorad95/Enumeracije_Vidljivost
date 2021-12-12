using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_i_vidljivost
{
    // osoba moze biti jedan tip korisnika racuna
    public enum Tip
    {
        Pravno,
        Fizicko
    }
    class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        // properti koji vraca ime i prezime vlasnika kao jedan zapis
        public string PunoIme { 
            get 
            {
                return $"{Ime} {Prezime}";
            } 
        }
        public Tip TipKorisnika { get; set; }


        public Osoba(string ime, string prezime, Tip tipKorisnika)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.TipKorisnika = tipKorisnika;
        }

        // promena prezimena vlasnika racuna
        public void promenaPrezimena(string prezime)
        {
            this.Prezime = prezime;
        }
    }
}
