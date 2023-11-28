using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool paros;
            Paros(10, out paros);
            Console.ReadKey();
        }
        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0)
            {
                log = true;
                Console.WriteLine("paros");
            }
            else log = false;
        }
    }
}
