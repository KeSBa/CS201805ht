using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    class Program
    {
        static void Main(string[] args)
        {

            // Faktura
            // Kunde
            // FakturaLinjer

            Kunde k = new Kunde() { KundeId = 1, Navn = "a" };
            Faktura f = new Faktura();
            f.Dato = DateTime.Now;
            f.FakturaNummer = 1;
            f.Kunde = k;

            FakturaLinje l1 = new FakturaLinje { Antal = 2,
                Pris = 100,
                Tekst = "abc" };

            f.TilføjLinje(l1);
            f.TilføjLinje(new FakturaLinje { Antal = 3, Pris = 50, Tekst = "frg" });

            //Console.WriteLine(f.FakturaTotal());
            f.Udskriv();



        }
    }
}
