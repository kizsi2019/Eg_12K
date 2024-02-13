using System;
namespace Osszegzo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int osszeg = Osszegzo(tomb);
            int max = Maximum(tomb);
            int min = Minimum(tomb);
        }
        static int Osszegzo(int[] tomb)
        {
            int ossz = 0;
            foreach (int i in tomb)
            {
                ossz += i;
            }
            return ossz;
        }
        static int Maximum(int[] tomb)
        {
            int max = tomb[0];
            foreach(int i in tomb)
            {
                if(i > max)
                {
                    max = i;
                }
                return max;
            }
        }
        static int Minimum(int[] tomb)
        {
            int min = tomb[0];
            foreach (int i in tomb)
            {
                if (i < min)
                {
                    min = i;
                }
                return min;
            }
        }
    }
}