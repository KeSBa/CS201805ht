using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Test");

            int i = 10;
            i++;
            i = i * 2;  // i *=2;

            for (int x = 0; x < 10; x++)
            {
                if (x < 5)
                {
                    Console.WriteLine("mindre en fem");
                }
                else {
                    Console.WriteLine("5 eller større");                    
                }
            }

            A();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Tryk en tast...");
                Console.ReadKey();
            }
        }

        static void A() {
            B();
        }
        static void B() {
            C();
        }
        static void C() {            
            Console.WriteLine("I c");
        }


    }
}
