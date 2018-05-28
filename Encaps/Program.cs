using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Encaps
{
    class Program
    {
        static void Main(string[] args)
        {
            HundGammel h;
            h = new HundGammel(5);
            Console.WriteLine(h.AlderGet());
            h.AlderSet(7);
            // h.Alder = 7;
            Console.WriteLine(h.AlderGet());
            // Console.WriteLine(h.Alder);
            h.AlderSet(70);
            Console.WriteLine(h.AlderGet());

            Hund h2 = new Hund();
            h2.Alder = 5;
            Console.WriteLine(h2.Alder);
            h2.Alder = 50;
            Console.WriteLine(h2.Alder);

            A a = new A();
            a.Data = 22;
            Console.WriteLine(a.ToStringEx());

            A b = new A() { Data = 3 };

            Hund j = new Hund { Alder = 10, Navn = "lkj" };


            // Instans metode
            B b2 = new B();
            b2.Metode1();

            // Statisk
            B.Metode2();

            HjælpeBibliotek.Test();


            Vare v = new Vare();
            Vare.MomsPct = 0.25;
            

        }
    }

    class Vare {

        public static double MomsPct { get; set; }

    }

    class B {
        public void Metode1() { }
        public static void Metode2() { }
    }

    static class HjælpeBibliotek {
        public static void Test() { }
    }

    class A {
        public int Data { get; set; }

    }

    class HundGammel
    {

        private int Alder;

        public HundGammel(int alder)
        {
            if (alder <= 0 || alder > 20)
                alder = 1;
            this.Alder = alder;
        }

        public int AlderGet() {
            // Log
            // Sikkerhed
            // Validering
            return this.Alder;
        }

        public void AlderSet(int alder)
        {
            // Log
            // Sikkerhed
            // Validering
            if (alder <= 0 || alder > 20)
                alder = 1;

            this.Alder = alder;
        }


    }

    class Hund {

        private int _alder;

        public int Alder {

            get {
                // log
                // sikkerhed
                // validering
                return this._alder;
            }
            set {
                // log
                // sikkerhed
                // validering
                if (value <= 0 || value > 20)
                    value = 1;
                this._alder = value;
            }
        }

        //public string Navn;
        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }


    }

    class Person
    {

        private int _højde;
        private string navn;

        public int Højde
        {
            get { return _højde; }
            set { _højde = value; }
        }


        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public int StandardVægt
        {
            get { return 80; }
            
        }


    }

    class Bil {

        public int AntalHjul { get; set; }
        public string Model { get; set; }
        public string Mærke { get; }

        //private int antalHjul;

        //public int AntalHjul
        //{
        //    get { return antalHjul; }
        //    set {
        //        //if....
        //        antalHjul = value; }
        //}


    }
}
