using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 2, 3, 4, 5, 6, 7 };
            int osszeg = Osszegzo(tomb);
            int legnagyobb = Max(tomb);
            int legkisebb = Min(tomb);
            Console.WriteLine(osszeg);
            Console.WriteLine(legnagyobb);
            Console.WriteLine(legkisebb);
            Console.ReadKey();
        }
        static int Osszegzo(int[] tomb)
        {
            int ossz = 0;
            foreach(int elem in tomb)
            {
                ossz += elem;
            }
            return ossz;
        }
        static int Max(int[] tomb)
        {
            int max = tomb[0];
            foreach(int elem in tomb)
            {
                if(elem > max)
                {
                    max = elem;
                }
            }
            return max;
        }
        static int Min(int[] tomb)
        {
            int min = tomb[0];
            foreach (int elem in tomb)
            {
                if (elem < min)
                {
                    min = elem;
                }
            }
            return min;
        }
    }
}
