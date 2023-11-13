using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adj meg egy szöveget");
            string asd = Console.ReadLine();

            var verem = new Stack<char>();
            var be = asd;

            Console.WriteLine("Eredeti: ", be);

            foreach(var kar in be)
            {
                verem.Push(kar);
            }
            Console.WriteLine("Visszafelé: ");

            while(verem.Count > 0)
            {
                var karakter = verem.Pop();
            }
        }
    }
}
