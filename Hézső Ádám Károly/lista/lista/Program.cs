using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            lista.Insert(1, 77);
            lista.Remove(2);
            foreach (var item in lista)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine("Kapacitása: "+ lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            Console.ReadKey();
        }
    }
}
