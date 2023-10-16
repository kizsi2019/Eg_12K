using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellenorzottadatbekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A megadott szam?" + ElBeker("adj meg egy számot 10-20 között!", 10, 20));
            Console.ReadKey();
        }
        static int ElBeker(string bekeresuzi, int mettol=int.MinValue, int meddig = int.MaxValue)
        {
            int szam;
            do
            {
                Console.WriteLine(bekeresuzi);
            } while (int.TryParse(Console.ReadLine(), out szam) || !(szam>mettol && szam<meddig));
            return szam;
        }
    }
}
