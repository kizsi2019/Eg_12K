using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 2 };
        }

        static int Osszegzo(int[] tomb)
        {
            int sum = 0;
            foreach(int elem in tomb)
            {
                sum += elem;
            }
            return sum;
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
