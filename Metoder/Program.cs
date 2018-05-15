using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            bool res1 = Test1();
            Test2();
            MinReturType res2 = Test3();

            int aaa;
            aaa = 10;
            bool b = true;
            Test4a(ref aaa, b);

            int[] ar = { 51, 4, 24, 2, 5 };
            UdskrivArray(ar);


            Test6(ref ar);

            Test7("",1);
            Test7("", 1,2);
            Test7("", 1, 2,2,1,4,2,4,54,4);

            double res3 = Test8(100);
            double res4 = Test8(100,.25);
            double res5 = Test8(moms: 0.3, beløb: 10000);

            VisFiler("c:\\temp");

        }

        public static void VisFiler(string mappe) {
            string[] filer = System.IO.Directory.GetFiles(mappe);
            foreach (var fil in filer)
                Console.WriteLine(fil);
            string[] mapper = System.IO.Directory.GetDirectories(mappe);
            foreach (var _mappe in mapper)
                VisFiler(_mappe);
        }

        public static double Test8(double beløb, double moms = 0.25) {
            return beløb * (1 + moms);
        }

        public static double Test8(double beløb, bool skriv, double moms = 0.25)
        {
            return beløb * (1 + moms);
        }

        static void Test7(string a, params int[] v)
        {
        }

            static bool Test1()
        {
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Test2()
        {
            //if (true)
            //    return;
        }

        static MinReturType Test3()
        {
            MinReturType r = new MinReturType();
            r.a = "lkj lkj";
            r.b = 10;
            return r;
        }

        static void Test4(int a, bool b)
        {

            if (b == true)
                Console.WriteLine(a);

            a++;

        }

        static void Test4a(ref int a, bool b)
        {

            if (b == true)
                Console.WriteLine(a);

            a++;

        }

        static void UdskrivArray(int[] a)
        {
            System.Array.Sort(a);
            Console.WriteLine(String.Join(" ", a));
            a[0] = 1000000;
        }

        static void Test6(ref int[] a)
        {
            a = new int[1000];
        }


    }

    struct MinReturType
    {
        public string a;
        public int b;
    }
}
