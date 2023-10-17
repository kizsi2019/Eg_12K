using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool paros;
            Console.WriteLine(Paros(11, out paros));

            Console.ReadKey();
        }

        static bool Paros(int a, out bool log)
        {
            if (a%2==0)
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
