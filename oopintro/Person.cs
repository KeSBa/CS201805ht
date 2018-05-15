using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopintro
{
    public partial class Person
    {
        // Felter / Data
        public string Navn;
        public int Alder;

        // Default constructor
        public Person()
        {
            // log
            // sikkerhed
            this.Navn = "";
            //Navn = "";
        }

        public Person(string navn, int alder)
        {
            // log
            // sikkerhed
            this.Navn = navn;
            this.Alder = alder;
            
        }

        // Custom constructor
        public Person(int alder) 
        {
            // log
            // sikkerhed
            this.Navn = "";
            this.Alder = alder;

        }


        // Custom constructor
        public Person(string navn) : this()
        {            
            // log
            // sikkerhed
            this.Navn = navn;            

        }


    }

    public partial class Person
    {
        public bool ErILIve;
    }
    }
