using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_jo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szöveget");
            string szoveg = Console.ReadLine();

            var verem = new Stack<char>();
            var be = szoveg;

            foreach (var kar in be)
            {
                verem.Push(kar);
            }

            var visszafele = new string(verem.ToArray());

            if (be == visszafele)
            {
                Console.WriteLine("A szöveg palindróm.");
            }
            else
            {
                Console.WriteLine("A szöveg nem palindróm.");
            }

            Console.ReadKey();
        }
    }
}
