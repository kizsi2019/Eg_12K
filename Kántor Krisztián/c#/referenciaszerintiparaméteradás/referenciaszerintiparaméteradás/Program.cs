using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenciaszerintiparaméteradás
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 4, c;
            c = ketszerOsszeadoFuggveny(ref a,ref b);
            Console.WriteLine("\'a\' értéke: {0}\n\'b\' értéke: {1}\n\'c\' értéke: {2}", a, b, c);

            Console.ReadKey();
        }

        static int ketszerOsszeadoFuggveny(ref int szam1,ref int szam2)
        {
            szam1 = szam1 * 2;
            szam2 = szam2 * 2;
            return szam2 + szam1;
        }
    }
}
