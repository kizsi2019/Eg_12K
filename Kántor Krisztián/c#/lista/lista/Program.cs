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
            List<int> lista = new List<int>{0};
            lista.Add(12);
            lista.Add(33);
            lista.Add(45);
            lista.Insert(1, 77);
            lista.Remove(2);

            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(lista.Capacity);
            Console.WriteLine(lista.Count);
            Console.ReadKey();
        }
    }
}
