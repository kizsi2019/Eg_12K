using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] {2, 3, 4, 5};
            Console.WriteLine("adj meg egy nevet");
            string name = Console.ReadLine();
            Console.WriteLine(EllBekerf("add meg a jegyeit 1 és 5 között", 1, 5));
            Console.ReadKey();

            int legjobb = Max(tomb);
            int legrosszabb = Min(tomb);
            Console.WriteLine(name + " legjobb jegye: " + legjobb);        
            Console.WriteLine(name + " legrosszabb jegye: " + legrosszabb);
            Console.ReadKey();
        }

        static int Max(int[] tomb)
        {
            int max = tomb[0];
            foreach (int item in tomb)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        static int Min(int[] tomb)
        {
            int min = tomb[0];
            foreach (int item in tomb)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        static int EllBekerf(string bekeresuzi, int mettol = int.MinValue, int meddig = int.MaxValue)
        {
            int szam;
            do
            {
                Console.WriteLine(bekeresuzi);
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            return szam;
        }
    }
}

