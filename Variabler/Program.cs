
namespace Variabler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {

            System.Int32 i;
            i = 0;
            // i = null;
            int x;

            string tmp = i.ToString();


            long t = 10;

            bool g = true;
            System.Boolean h = false;

            double k = 1986700.75757;

            Console.WriteLine(k.ToString());
            Console.WriteLine(k.ToString("N3"));
            Console.WriteLine(k);

            int e1;
            double e2;
            bool e3;

            DateTime d = DateTime.MinValue;
            DateTime d2 = DateTime.Now;
            DateTime d3 = new DateTime(2018, 12, 24);

            Console.WriteLine(d3);
            Console.WriteLine(d3.ToString("yyyy dddd"));

            TimeSpan ts1 = d3.Subtract(d2);
            Console.WriteLine(ts1.TotalMinutes);

            TimeSpan ts2 = new TimeSpan(14, 00, 00);
            Console.WriteLine(ts2);

            int y = 100;
            int Y = 200;

            const int antalMåneder = 12;
            // antalMåneder = 10;

            // System.Configuration.ConfigurationManager.
            double momsPct = 0.25;

            // App settings (kræver setting i egenskaber til project)
            Variabler.Properties.Settings.Default.Moms = 0.1;
            Variabler.Properties.Settings.Default.Save();


            i++;
            i--;
            i += 10;
            i *= 20;

            if (i % 2 == 0) {
                // lige tal
            } else {
                // ulige tal
            }

            i = 500000000;
            //short j = (short)i;

            //checked
            //{
            //    short j = (short)i;
            //}

            //short j = Convert.ToInt16(i);


            DateTime d5 = Convert.ToDateTime("2017-5-15");

            var q = 1.7;
            
            var u = 34;

            // int[] ar = { 4, 2, 1, 4, 5 };
            // var res2 = ar.Where(r => r < 10).OrderBy(r => r).GroupBy(r => r);

            var nyv = 10;
            int nyv1 = 10;

            string navn1 = "Mikkel";
            int køn1 = 1;       // 1 = mand
            int alder1 = 10;

            string navn2 = "Lene";
            int køn2 = 0;       // 0 = kvinde
            int alder2 = 20;

            string navn3 = "Mathias";
            Køn køn3 = Køn.Mand;
            int alder3 = 80;

            Person p4 = new Person();
            p4.Navn = "Anette";
            p4.Køn = Køn.Kvinde;
            p4.Alder = 54;

            Person p5 = p4;




            Console.WriteLine(Convert.ToUInt32(køn3));

            DayOfWeek dag = DayOfWeek.Sunday;
            if (dag == DayOfWeek.Sunday) { }

            switch (dag)
            {
                case DayOfWeek.Sunday:

                    break;
                case DayOfWeek.Monday:

                    break;

                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:

                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            KortFarve kort = KortFarve.Ruder;

            Person p6 = new Person();   // initialiser til default værdier
            p6.Alder++;



            
            

        }

        public static void GemPerson(Person p) {
            // gemmer p
            
        }
    }

    enum Køn {
        Mand,
        Kvinde
    }

    enum KortFarve {
        Hjerter,
        Spar,
        Ruder,
        Klør
    }

    struct Person {
        public string Navn;
        public Køn Køn;
        public int Alder;
        public string ByNavn;
    }
}
