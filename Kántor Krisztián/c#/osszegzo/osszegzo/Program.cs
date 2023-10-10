using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = {2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            Console.WriteLine(Osszegzo(tomb));
            Console.WriteLine(Maxi(tomb));
            Console.WriteLine(Mini(tomb));
            Console.ReadKey();
        }

        static int Osszegzo(int[] tomb)
        {
            int ossz = 0;
            foreach (int item in tomb)
            {
                ossz += item;
            }
            return ossz;
        }

        static int Maxi(int[] tomb)
        {
            int maxi = tomb[0];
            foreach (int item in tomb)
            {
                if (maxi<item)
                {
                    maxi = item;
                }
            }
            return maxi;
        }

        static int Mini(int[] tomb)
        {
            int mini = tomb[0];
            foreach (int item in tomb)
            {
                if (mini>item)
                {
                    mini = item;
                }
            }
            return mini;
        }
    }
}
