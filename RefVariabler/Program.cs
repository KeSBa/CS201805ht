using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RefVariabler
{
    class Program
    {
        static void Main(string[] args)
        {

            int ids;
            double d;
            bool bss;
            DateTime dato;
            TimeSpan ts;
            string n = "";
            char css = 'f';

            double måned1 = 2000;
            double måned2 = 4000;
            double måned3 = 500;
            double måned4 = 2500;
            double gns = (måned1 + måned2 + måned3 + måned4) / 4;
            Console.WriteLine(gns.ToString("N2"));

            double[] løn = { 2000, 4000, 500, 2500, 7500 };
            // løn[0] = 2000;

            double sum = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                sum += løn[i];
            }
            gns = sum / løn.Length;
            Console.WriteLine(gns.ToString("N2"));


            int[] test = null;
            Console.WriteLine(test);
            if (test == null)
                Console.WriteLine("Tomt");

            test = new int[5];
            test[0] = 10;

            string[,] skak = new string[8, 8];
            skak[0, 0] = "T";

            // -----


            int[] a;
            int[] b;

            a = new int[3];
            b = new int[3];



            a[1] = 1;
            b[1] = 1;

            // sammenligning
            if (a == b)
            {
                Console.WriteLine("ens");
            }

            a = b;

            if (a == b)
            {
                Console.WriteLine("ens");
            }

            int[] c;
            c = a;


            Console.WriteLine("****");

            int[] x = { 5, 1, 4, 5, 8, 2 };
            int[] y = { 6 };
            if (x == y)
            {
                Console.WriteLine("ens");
            }
            else {
                Console.WriteLine("ikke ens");
            }

            int[] z = (int[])x.Clone();
            if (z == x)
            {
                Console.WriteLine("ens");
            }
            else
            {
                Console.WriteLine("ikke ens");
            }

            Console.WriteLine(SammenlignerVærdier(x,y));

            int[] aa = { 25, 4 };
            int[] bb = { 25, 5 };

            Console.WriteLine(SammenlignerVærdier(aa,bb));


            System.Array.Sort(x);


            Person p = new Person();

            // Udskrift....
            Console.WriteLine(string.Join(" ", x));


            // ----------------------------------

            string n1;
            n1 = "abcdefghij";

            string n2 = "abc";
            string n3 = n1 + n2;
            Console.WriteLine(n1==n2);
            Console.WriteLine(n3);


            Console.WriteLine(n1.ToUpper());
            Console.WriteLine(n1.Substring(2,2));
            Console.WriteLine(n1.EndsWith("j"));

            //string sti = "c:\\temp\\test.txt";
            string sti = @"c:\temp\test.txt";
            Console.WriteLine(sti);

            string test2 = "ldfkjld lsdkjg ldksjg\r\nldfkgj dlkfj gldkfjg ";
            Console.WriteLine(test2);

            string test3 = "dflkgædlfk \"gædlfkg\" dæfklg ";
            Console.WriteLine(test3);

            string test4 = "xfjlxkfj";
            string test5 = test4.ToUpper();

            
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            string tmp = "";
            for (int i = 0; i < 1000; i++)
            {
                tmp = tmp + "*";
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            s.Reset();



            s.Start();
            System.Text.StringBuilder sb = new StringBuilder();            
            for (int i = 0; i < 10000; i++) 
            {
                sb.Append("*");
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = 0; i < 10; i=i+2)
            {
                Console.WriteLine(i);
            }

            
            for (int i = 10; i >0; i = i -1)
            {
                Console.WriteLine(i);
            }

            {
                int yd = 10;
            }

            {
                int yd = 20;

            }

            //do
            //{

            //} while (true);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
                if (i == 8)
                    break;
            }

            string ww = "***";
            Console.WriteLine(ww.PadLeft(10, '.'));
            Console.WriteLine(ww.PadRight(10, '.'));

            Console.WriteLine(ww.PadLeft(5, ' '));

        }

        static bool SammenlignerVærdier(int[] a, int[] b) {
            if (a.Length != b.Length)
                return false;
            bool ens = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) {
                    ens = false;
                }
            }
            return ens;

        }
    }

    class Person {
        public string Navn;
    }
}
