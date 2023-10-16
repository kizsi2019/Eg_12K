using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellenorzoadatbekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A megadott szám? " + EllBekert("Adj meg egy szamot 10-20 kozott", 10, 20));
            Console.ReadKey();
        }

        static int EllBekert(string bekertsor, int mettol = int.MinValue, int meddig = int.MaxValue)
        {
            int szam;

            do
            {
                Console.WriteLine(bekertsor);
            } while (int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            return szam;
        }
    }
}
