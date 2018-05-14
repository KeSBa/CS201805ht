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



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Tryk en tast...");
                Console.ReadKey();
            }
        }
    }
}
