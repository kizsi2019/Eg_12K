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
            using System;
            using System.Collections.Generic;

namespace PeldaList
    {
        class Program
        {
            static void Main(string[] args)
            {
                //4 elemnek foglalunk helyet
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
                Console.WriteLine("Átméretezés után: {0}", lista.Capacity);

                Console.ReadKey();

                //Saját adatszerkezet esetén is érdemes implementálni az
                //ICollection<T> felületet.
            public class SajatLista<T> : ICollection<T>, IList<T>
            {
                private T[] _array;

                //alap konstruktor
                public SajatLista()
                {
                    _array = new T[1];
                    Count = 0;
                }

                //optimalizált allokáló konstruktor
                public SajatLista(int count)
                {
                    _array = new T[count];
                    Count = 0;
                }

                public T this[int index]
                {
                    get { return _array[index]; }
                    set { _array[index] = value; }
                }

                public int Count
                {
                    get;
                    private set;
                }

                public bool IsReadOnly
                {
                    get { return false; }
                }

                public void Add(T item)
                {

                    if (Count + 1 < _array.Length)
                    {
                        //van elég elemnek hely
                        Count += 1;
                        _array[Count - 1] = item;
                    }
                    else
                    {
                        //nincs elég hely, ezért allokálunk többnek helyet
                        T[] newArray = new T[_array.Length * 2];
                        Array.Copy(_array, 0, newArray, 0, Count);
                        Count += 1;
                        newArray[Count - 1] = item;
                        _array = newArray;
                    }
                }

                public void Clear()
                {
                    Array.Clear(_array, 0, Count);
                }

                public bool Contains(T item)
                {
                    return Array.IndexOf(_array, item) != -1;
                }

                public void CopyTo(T[] array, int arrayIndex)
                {
                    Array.Copy(_array, 0, array, arrayIndex, Count);
                }

                public IEnumerator<T> GetEnumerator()
                {
                    for (int i = 0; i < Count; i++)
                    {
                        yield return _array[i];
                    }
                }

                public int IndexOf(T item)
                {
                    return Array.IndexOf(_array, item);
                }

                public void Insert(int index, T item)
                {
                    if (Count + 1 > _array.Length)
                    {
                        T[] newArray = new T[_array.Length * 2];
                        Array.Copy(_array, 0, newArray, 0, Count);
                        _array = newArray;
                    }
                    Count += 1;
                    Array.Copy(_array, index, _array, index + 1, Count - index);
                    _array[index] = item;
                }

                public bool Remove(T item)
                {
                    int index = IndexOf(item);
                    if (index >= 0)
                    {
                        RemoveAt(index);
                        return true;
                    }
                    return false;
                }

                public void RemoveAt(int index)
                {
                    Count--;
                    if (index < Count)
                    {
                        Array.Copy(_array, index + 1, _array, index, Count - index);
                    }
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }

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
}
