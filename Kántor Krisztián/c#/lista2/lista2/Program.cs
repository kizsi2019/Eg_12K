using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//4 elemnek foglalunk helyet
            var lista = new List<int>(4);
            lista.Add(9);
            lista.Add(2);
            lista.Add(4);
            lista.Add(5);

            Console.WriteLine("A lista elemei:");
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

            lista.Sort(); //int esetén implementálva van a < és > reláció
            Console.WriteLine("A lista elemei sorbarendezés után:");
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

            //+1 elem. Itt átméretezés lesz.
            //2n alapján a méret 8-ra fog nőni.
            //ez jelen esetben 3*4 byte feleslegesen foglalt memória
            lista.Add(99);

            Console.WriteLine("Lista mérete: {0}", lista.Capacity);
            lista.TrimExcess(); //felesleges foglalás csökkentése
            Console.WriteLine("Átméretezés után: {0}", lista.Capacity);*/
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
