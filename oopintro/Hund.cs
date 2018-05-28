using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopintro
{
    public class Hund
    {
        private int Alder;
        public string Navn;
        private static System.Random rnd;

        public Hund()
        {
            rnd = new Random();
            this.Navn = "";

        }
        // Custom
        public Hund(string navn, int alder)
        {
            if (navn == null)
                navn = "";
            // sikkerhed
            // Log
            // Validering
            this.Navn = navn;
            if (alder < 0)
                alder = 0;
            this.Alder = alder;
        }

        public int TilfældigTal() {
            return Hund.rnd.Next(1, 21);
        }

        
        public void test() {
            
        }
    }
}
