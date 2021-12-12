using System;

namespace Enumeracije_i_vidljivost
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Racun("150-45781298-025", new Osoba("Marko", "Markovic", Tip.Fizicko));

            if(r.Vlasnik == null || r.Broj == null) {
                Console.WriteLine("Ne mozete otvoriti racun bez vlasnika i broja!");
            }
            else {
                r.opis();

                Console.WriteLine("Uplata 1000...");
                Console.ReadLine();

                r.uplata(1000);
                Console.WriteLine(r.opis());

                Console.WriteLine("Isplata...");
                Console.ReadLine();

                r.isplata(750);
                Console.WriteLine(r.opis());

                Console.WriteLine("Provera stanja...");
                Console.ReadLine();

                Console.WriteLine(r.proveraStanja());

                Console.WriteLine("Promena vlasnika...");
                Console.ReadLine();

                r.Vlasnik = new Osoba("Milorad", "Komljenovic", Tip.Pravno);
                Console.WriteLine(r.opis());

                Console.WriteLine("Promena prezimena...");
                Console.ReadLine();

                r.Vlasnik.promenaPrezimena("Petrovic");
                Console.WriteLine(r.opis());

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
