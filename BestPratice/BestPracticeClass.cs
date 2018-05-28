using System;

namespace BestPratice
{
    // Kun tilgang fra projektet selv
    internal class BestPracticeClass {

        // Felter
        private int felt1;  // kun tilgås internt i klasse
        
        // Nej tak....
        public int felt2;   // kan tilgås af instanser af klassen

        // Egenskaber (fuld egenskab.. propfull)
        private int felt3;  // kan kun tilgås gennem klassen selv

        public int Felt3
        {
            get {
                // log, validering, sikkerhed
                return felt3; }
            set {
                // log, validering, sikkerhed                
                felt3 = value; }
        }

        // Automatisk egenskab
        public int Felt4 { get; set; }

        // Forskellige typer egenskaber
        public int Felt5 { get; private set; }  // set kan kun 
                                                // tilgås internt i klassen
        public int Felt6 { get; }               // read only

        // Constructor

        // Default (ctor)
        public BestPracticeClass()
        {
            // log, validering, sikkerhed                
            // Initialiseringskode
        }

        // En eller flere custom constructor
        public BestPracticeClass(int felt1)
        {
            // log, validering, sikkerhed                
            this.felt1 = felt1; // Initialisering
        }

        public BestPracticeClass(int felt1, int felt2)
        {
            // log, validering, sikkerhed                
            this.felt1 = felt1; // Initialisering
            this.felt2 = felt2;
        }

        // Metoder
        public void Test1() {
            // metoden kan tilgås udefra
            // og kan tilgå interne felter
            Console.WriteLine(this.felt1);            
        }

        private void Test2()
        {
            // metoden kan IKKE tilgås udefra
            // og kan tilgå interne felter
            Console.WriteLine(this.felt1);
        }

        public static void Test3() {
            // Statisk metode - kan tilgås på typen
        }

    
    }


}
