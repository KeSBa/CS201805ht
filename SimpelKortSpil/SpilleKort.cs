using System;

namespace SimpelKortSpil
{
    public class SpilleKort
    {
        public int Værdi { get; private set; }
        public Kulør KortKulør { get; private set; }
        public int Point { get
            {
                if (this.Værdi == 1)
                {
                    return 11;
                }
                else if (this.Værdi >= 2 && this.Værdi <= 10)
                {
                    return 5;
                }
                else if (this.Værdi >= 11 && this.Værdi <= 13)
                {
                    return 10;
               
                }
                return 0;
            }
        }

        public SpilleKort(int værdi, Kulør kulør)
        {
            if (værdi<1||værdi>13)
            {
                værdi = 1;
            }

            this.Værdi = værdi;
            this.KortKulør = kulør;
        }
        public string Print()
        {
            switch (this.KortKulør)
            {
                case Kulør.Hjerter:
                    return "Hj " + this.VisVærdi();
                    break;
                case Kulør.Ruder:
                    return "Ru " + this.VisVærdi();
                    break;
                case Kulør.Spar:
                    return "Sp " + this.VisVærdi();
                    break;
                case Kulør.Klør:
                    return "Kl " + this.VisVærdi();
                    break;
                default:
                    return " ";
                    break;
            }
        }
        private string VisVærdi()
        {
            if (this.Værdi==1)
            {
                return "Es " + this.Point;
            }
            else if (this.Værdi >= 2 && this.Værdi<=10)
            {
                return this.Værdi.ToString("00")+" " + this.Point;
            }
            else if (this.Værdi == 11)
            {
                return "Kn " + this.Point;
            }
            else if (this.Værdi == 12)
            {
                return "Dm " + this.Point;
            }
            else if (this.Værdi == 13)
            {
                return "Ko " + this.Point;
            }
            return "*";
        }
        public static SpilleKort TilfældigKort()
        {
            int v = Rnd.Next(1, 14);
            int f = Rnd.Next(1, 5);
            SpilleKort s = new SpilleKort(v,(Kulør) f);
            return s;
        }
        private static Random Rnd = new Random();
        public Farve FindFarve()
        {
            switch (this.KortKulør)
            {
                case Kulør.Hjerter:
                    
                case Kulør.Ruder:
                    return Farve.Rød;
                  
                case Kulør.Spar:
                    
                case Kulør.Klør:
                    return Farve.Sort;
                default:
                    return Farve.Sort;
            }
        }
    }
}
