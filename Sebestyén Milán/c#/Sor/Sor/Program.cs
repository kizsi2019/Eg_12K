using System.Collections;
using System.Collections.Generic;
namespace Sor
{
    class Program
    {
        public class SajatSor<T> : IEnumerable<T>
        {
            private List<T> _lista;

            public SajatSor()
            {
                _lista = new List<T>();
            }

            //elem beillesztése a sor végére 
            public void Enqueue(T item)
            {
                _lista.Add(item);
            }

            //elem kinyerése a sor elejéről
            public T Dequeue()
            {
                T item = _lista[0];
                _lista.RemoveAt(0);
                return item;
            }

            //sor elején álló elem megtekintése
            public T Peek()
            {
                return _lista[0];
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (int i = _lista.Count - 1; i >= 0; i--)
                {
                    yield return _lista[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
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

                var sor2 = new SajatSor<int>();
                sor.Enqueue(11);
                sor.Enqueue(12);
                sor.Enqueue(13);
                sor.Enqueue(14);
                sor.Enqueue(15);

                Console.WriteLine("A sor elemei: ");
                foreach (var item in sor2)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Dequeue:");
                Console.WriteLine(sor2.Dequeue());
                Console.WriteLine(sor2.Dequeue());
                Console.WriteLine(sor2.Dequeue());
                Console.WriteLine(sor2.Dequeue());

                Console.ReadKey();
            }
        }
    }
}