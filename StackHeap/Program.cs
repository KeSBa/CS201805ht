using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHeap
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Navn = "a";
            Person p2 = new Person();
            p2.Navn = "b";
            Console.WriteLine(p1.Navn);
            Console.WriteLine(p2.Navn);
            p1 = p2;
            Console.WriteLine(p1.Navn);
            Console.WriteLine(p2.Navn);
            p2.Navn = "c";
            Console.WriteLine(p1.Navn);
            Console.WriteLine(p2.Navn);

            p2 = null;
            Console.WriteLine(p2.Navn);

        }
    }

    class Person
    {
        public string Navn;
    }
}
