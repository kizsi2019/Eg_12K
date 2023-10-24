using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_10_16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool paros;
            int szam = 0;

            Console.WriteLine(Paros(szam, out paros));

            Console.ReadKey();
        }

        static bool Paros(int a, out bool log)
        {
            if (a % 2 == 0)
            {
                log = true;
            }
            else
            {
                log = false;
            }

            return log;
        }
    }
}
