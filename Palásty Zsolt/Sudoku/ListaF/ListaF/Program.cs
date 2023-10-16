using System;
namespace ListaF
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

            
            foreach (int i in lista)
            {
                Console.WriteLine(i + ", ");
            }
            Console.WriteLine ("Kapacitása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            Console.ReadKey();
        }
        
    }
}