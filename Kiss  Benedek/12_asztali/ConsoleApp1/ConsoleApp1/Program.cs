using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 4, c;
            c = kétszeresétÖsszeadóFüggvény(ref a, ref b);
            Console.WriteLine("\'a\' érték : {0}\n\'b\' érték : {1}\n\'c\' érték : {2}", a, b, c);
            //a = 12, b = 8, c = 20
            Console.ReadKey();
        }
        static int kétszeresétÖsszeadóFüggvény(ref int szam1, ref int szam2)
        {
            szam1 = szam1 * 2;
            szam2 = szam2 * 2;
            return szam1 + szam2;
        }
    }
}
