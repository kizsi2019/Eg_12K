using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevezetes_Algoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int összeg = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                összeg += Tömb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);

            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");

            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);

            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);

            int ii = 0;
            while (ii < Tömb.Length && Tömb[ii] % 2 == 0)
            {
                ii++;
            }
            Console.WriteLine("A páratlan elem feltételeinek sorszáma {0}", ii);

            int i0 = 0;
            while (i0 < Tömb.Length && Tömb[i0] % 2 == 0)
            {
                i0++;
            }
            if (i0 < Tömb.Length) Console.WriteLine("A páratlan elem feltételeinek megfelelő sorszáma {0}", i0);
            else Console.WriteLine("Nincs");

            int[] beolvasás = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot: ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }
            int j0 = 0;
            while (j0 < beolvasás.Length && beolvasás[j0] % 3 != 0)
            {
                j0++;
            }
            if (j0 < beolvasás.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be!", j0 + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");

            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83};

            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 31) alsóhatár = közép + 1;
                if (rendezettTömb[közép] > 31) felsőhatár = közép - 1;
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != 31);
            if (rendezettTömb[közép] == 31) Console.WriteLine("Van, indexe: " + közép);
            else Console.WriteLine("Nincs");


            



            Console.ReadKey();
        }
    }
}
