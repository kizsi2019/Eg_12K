using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sor
{
    class Program
    {
        static void Main(string[] args)
        {
            var sor = new Queue<char>();
            var be = "SOR RULEZ";

            Console.WriteLine("Sorba írás: {0}", be);

            foreach (var chr in be)
            {
                sor.Enqueue(chr);
            }

            Console.WriteLine("Sorból kiolvasás:");

            while (sor.Count > 0)
            {
                var karakter = sor.Dequeue();
                Console.Write(karakter);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
