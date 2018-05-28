using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    public class Faktura
    {
        public Faktura()
        {
            fakturaLinjer = new FakturaLinje[10];
        }

        public DateTime Dato { get; set; }
        public int FakturaNummer { get; set; }
        public Kunde Kunde { get; set; }

        private FakturaLinje[] fakturaLinjer;
        private int tæller = 0;

        public void TilføjLinje(FakturaLinje f)
        {
            fakturaLinjer[tæller] = f;
            tæller++;
        }

        public double FakturaTotal()
        {
            double sum = 0;
            foreach (FakturaLinje item in this.fakturaLinjer)
            {
                if (item != null)
                {
                    sum += item.SamletPris();
                  
                }

            }
            return sum;
        }

        public void Udskriv() {
            Console.WriteLine("Faktura nr " + this.FakturaNummer);
            Console.WriteLine("Kunde: " + this.Kunde.PrintNavn());
            foreach (var item in this.fakturaLinjer)
            {
                if(item!=null)
                    Console.WriteLine(item.Udskriv());
            }
            Console.WriteLine("Samlet pris: " + this.FakturaTotal().ToString("N2"));
        }

    }
}
