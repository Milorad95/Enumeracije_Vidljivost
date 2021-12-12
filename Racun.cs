using System;
using System.Timers;
namespace Enumeracije_i_vidljivost
{
    class Racun
    {
        public string Broj { get; set; }

        private decimal Stanje = 0;
        public Osoba Vlasnik { get; set; }

        // parametar vlasnik je tipa Osoba koja ima svoje atribute 
        public Racun(string brojRacuna, Osoba vlasnik)
        {
            this.Broj = brojRacuna;
            this.Vlasnik = vlasnik;
        }
    
        // promena vlasnika racuna
        public void promenaVlasnika(Osoba vlasnik)
        {
            this.Vlasnik = vlasnik;
        }

        public void uplata(decimal iznos)
        {
            this.Stanje += iznos;
        }

        public void isplata(decimal iznos)
        {
            if(this.Stanje - iznos >= 0)
            {
                this.Stanje -= iznos;
            }
            else
            {
                Console.WriteLine("Nedovoljno sredstava na racunu!");
            }
        }

        // metoda koja ispisuje za koji broj racuna i u koje vreme se trazila provera stanja na racunu
        public string proveraStanja()
        {
            return $"Provera stanja za racun broj: {this.Broj} Vreme: {DateTime.Now}\nStanje na racunu: {this.Stanje}";
        }

        // ispisuje sve vrednosti Racuna i Vlasnika
        public string opis()
        {
            return $"Broj racuna je: {this.Broj} vlasnik je {Vlasnik.PunoIme} {Vlasnik.TipKorisnika} lice.\n{proveraStanja()}.";
        }
    }
}
