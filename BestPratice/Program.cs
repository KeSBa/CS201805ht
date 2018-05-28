using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanser...
            //BestPracticeClass b;
            //b = new BestPracticeClass();
            BestPracticeClass b = new BestPracticeClass();
            b.Felt3 = 10;
            // b.Felt5 = 10;   // fejl


            // Kald til en statisk metode (på selve typen)
            BestPracticeClass.Test3();
            



        }
    }


}
