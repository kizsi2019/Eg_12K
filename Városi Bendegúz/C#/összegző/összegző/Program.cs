using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace összegző
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 2, 3, 4, 5, 6, 7 };
            int osszeg = Osszegzo(tomb);
            Console.WriteLine(osszeg);
            int max = Max(tomb);
            Console.WriteLine(max);
            int mini = Min(tomb);
            Console.WriteLine(mini);
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
            int maxi = tomb[0];
            foreach(int item in tomb)
            {
                if(item > 0)
                {
                    maxi = item;
                }
            }
            return maxi;
        }

        static int Min(int[] tomb)
        {
            int mini = tomb[0];
            foreach(int item in tomb)
            {
                if (item < 0)
                {
                    mini = item;
                }
            }
            return mini;
        }
    }
}
