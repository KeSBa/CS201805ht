using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    public class Kunde
    {
        public int KundeId { get; set; }
        public string Navn { get; set; }

        public string Land { get; set; }

        public string PrintNavn() {
            return this.Navn + " (" + this.KundeId + ")";
        }
    }
}
