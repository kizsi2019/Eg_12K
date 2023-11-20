using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka
{
    class Program
    {
        static void Main(string[] args)
        {
            //szétválogatás
            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 16, 76 };
            int[] negyzetszamokT = new int[20];
            int[] oszhato3szamokT = new int[20];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < tomb.Length; i++)
            {//négyzetszám vizsgálat
                if (tomb[i] > 0 && Math.Sqrt(tomb[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = tomb[i];
                    negyzet_i++;
                }

                //oszthatóság vizsgálat
                if (tomb[i] % 3 == 0)
                {
                    oszhato3szamokT[osz3_i] = tomb[i];
                    osz3_i++;
                }
            }

            foreach(int item in negyzetszamokT)
            {
                Console.WriteLine(item);
            }
            foreach(int item in oszhato3szamokT)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}