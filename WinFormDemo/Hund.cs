using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDemo
{
    class Hund
    {
        public int Alder { get; set; }
        public string Navn { get; set; }

        public int AntalBen { get; } = 4;

        public System.Drawing.Color Farve { get; set; }
    }
}
