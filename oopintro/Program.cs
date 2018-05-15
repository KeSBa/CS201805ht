using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Alder = -10;
            Person p2 = new Person("a", 10);
            Person p3 = new Person(10);
            Person p4 = new Person("b");
            
            Console.WriteLine(p.ToString());

        }
    }

    
}
