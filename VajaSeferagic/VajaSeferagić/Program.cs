using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaSeferagić
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaZaVajeEntities con = new BazaZaVajeEntities();
            //a.	izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT
            //kjer je P_DATUM manjši od 20. jan. 2004 
            DateTime dan = DateTime.Parse("20.1.2004");
            var x1 = from a in con.PRODUKT
                     where a.P_DATUM < dan
                     select new { Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, Najmanja = a.P_MIN, Cena = a.P_CENA };
            Console.WriteLine("Zaloge, datum manjši od 20.1.2004");
            foreach (var a in x1)
            {
                Console.WriteLine(a.Opis+" "+a.Zaloga);
            }
            Console.WriteLine("__________________________________");


            //b.	izberi P_OPIS, P_ZALOGA,P_DATUM in današnjidatum+365 naj se imenuje ZAPADLOST iz tabele PRODUKT 
            var x2 = from a in con.PRODUKT
                     select new { a.P_OPIS, a.P_ZALOGA, a.P_DATUM, DateTime.Today };
            Console.WriteLine("____________________________");
            foreach (var a in x2)
            {
                Console.WriteLine(a.P_OPIS, a.P_ZALOGA, a.P_DATUM, DateTime.Today);
            }
            Console.WriteLine("____________________________");

            //c.	izberi P_OPIS, P_ZALOGA, P_MIN,P_CENA iz tabele PRODUKT
            //kjer je P_CENA manjša od 50 in je P_DATUM večji kot 15. jan. 2004 
            //DateTime dan2 = DateTime.Parse("15.1.2004");
            //var x3 = from a in con.PRODUKT




            //e.izberi vse dobavitelje, kjer je zaloga v produktu manjša od dvakratnika minimalne zaloge
            var x5 = from a in con.PRODUKT
                     where a.P_ZALOGA < 2 * a.P_MIN
                     select new { Ime = a.DOBAVITELJ.D_IME, Kontakt = a.DOBAVITELJ.D_KONTAKT };
            foreach (var b in x5)
            {
                Console.WriteLine(b.Ime+" "+b.Kontakt);  
            }
            Console.WriteLine("____________________________");

            //g.	izberi kodo in ime dobavitelja, ki nam še niso ničesar dobavili 
            //(njihova koda se ne pojavlja v tabeli PRODUKT)
            //var x7 = (from a in con.PRODUKT
            //         from b in con.DOBAVITELJ
            //         where a.D_KODA == b.D_KODA
            //         select b).Distinct();
            var x7 = (from a in con.PRODUKT
                      select a.DOBAVITELJ).Distinct();
            var x8 = con.DOBAVITELJ.Where(e => !x7.Any(p => p.D_KODA == e.D_KODA)).Select(e=>new { e.D_KODA, e.D_IME });

            Console.ReadLine();
                
        }
    }
}
