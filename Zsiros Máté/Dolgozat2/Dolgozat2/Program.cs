using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szöveget");
            string szoveg = Console.ReadLine();

            var verem = new Stack<char>();
            var be = szoveg;

            Console.WriteLine("Eredeti: ", be);

            foreach (var kar in be)
            {
                verem.Push(kar);
            }

            Console.WriteLine("Visszafelé: ");

            while (verem.Count > 0)
            {
                var karakter = verem.Pop();
                Console.Write(karakter);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
