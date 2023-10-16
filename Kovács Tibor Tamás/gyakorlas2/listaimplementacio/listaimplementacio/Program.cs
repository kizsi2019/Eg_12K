using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaimplementacio
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new SajatLista<int>();

            lista.Add(22);
            lista.Add(33);
            lista.Add(88);
            lista.Add(44);

            Console.WriteLine("A lista ennyi elemet tartalmaz {0}", lista.Count);

            bool vanbenne = lista.Contains(33);
            Console.WriteLine("Van benne 33?: {0}", vanbenne);
            lista.Remove(33);
            vanbenne = lista.Contains(33);
            Console.WriteLine("Van benne 33?: {0}", vanbenne);

            lista.Insert(1, 11);

            Console.WriteLine("A lista elemei:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
