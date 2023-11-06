using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellenorzottadabekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A megadott szam: " + EllBeker("adj meg egy számot 10-20 között!", 10,20));
            Console.ReadKey();
        }
        static int EllBeker(string bekeresuzi, int mettol=int.MinValue, int meddig=int.MaxValue)
        {
            int szam;
            do
            {
                Console.WriteLine(bekeresuzi);
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam>mettol && szam<meddig));
            return szam;
        }
    }
}
