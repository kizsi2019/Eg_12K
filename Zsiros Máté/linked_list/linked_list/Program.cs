using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new LinkedList<string>();
            //jobbról bővítés
            lista.AddLast("egy");
            lista.AddLast("példa");
            lista.AddLast("program");
            lista.AddLast("lenne");
            //balról bővítés
            lista.AddFirst("Ez");

            Console.WriteLine("Lánc elemek száma: {0}", lista.Count);
            Console.WriteLine("Lánc tartalma előre: ");
            //a foreach automatikusan a value elemet szedi ki
            foreach (var elem in lista)
            {
                Console.Write("{0} ", elem);
            }

            Console.WriteLine("\nLánc tartalma vissza: ");
            var vissza = lista.Last;
            while (vissza != null)
            {
                Console.Write("{0} ", vissza.Value);
                vissza = vissza.Previous;
            }
            Console.ReadKey();
        }
    }
}
