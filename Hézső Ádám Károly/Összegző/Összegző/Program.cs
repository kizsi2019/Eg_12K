using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Összegző
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 2, 3, 4, 5, 6, 7 };
            Osszegzo(tomb);
            int nagy = Max(tomb);
            int kicsi = Minn(tomb);
            Console.WriteLine(kicsi);
            Console.WriteLine(nagy);
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
            foreach (int item in tomb)
            {
                if (item > 0)
                {
                    max = item;
                }
            }
            return max;

        }
        static int Minn(int[] tomb)
        {
            int min = tomb[0];
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    min = item;
                }
            }
            return min;

        }
    }
}
