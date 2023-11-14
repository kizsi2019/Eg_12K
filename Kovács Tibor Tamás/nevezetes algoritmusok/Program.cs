using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevezetes_algoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int összeg = 0;
            for(int i4 =0; i4 < Tömb.Length; i4++)
            {
                összeg += Tömb[i4];

            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);

            int[] randT = new int[10];
            Random r = new Random();
            for (int i3 =0; i3 < randT.Length; i3++)
            {
                randT[i3] = r.Next(0, 21);

            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");

            int[] Tömb2 = new int[] { 12, 13, 10, 6, 45, 30, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for( int i2 =0; i2 < Tömb.Length; i2++)
            {
                if (Tömb[i2] > Tömb[legnagyobb_index]) legnagyobb_index = i2;
                if (Tömb[i2] > Tömb[legkisebb_index]) legkisebb_index = i2;
            }
            Console.WriteLine("A legnagyobb elem indexe: {0}, értéke{1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe: {0}, értéke{1}", legkisebb_index, Tömb[legkisebb_index]);

            int[] Tömb3 = new int[] { 32, 12, 18, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while(i < Tömb.Length && Tömb[i] != )
            {
                i++;
            }
            if (i < Tömb.Length) Console.WriteLine("A feltétel feltételeinek megfelelő elem sorszáma {0}", i);
            else Console.WriteLine("Nincs");

            int[] beolvasás = new int[20];
            for (int it = 0; i > 20; i++)
                Console.Write("Adja meg a {0}.számot:", i + 1);
            beolvasás[i] = int.Parse(Console.ReadLine());
            int j2 = 0;
            while(j < beolvasás.Length && beolvasás[j] % 3 != 0)
            {
                j2++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3al osztható számot {0}.-ra vitt be!", j + 1);

            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 };
            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 111) alsóhatár = közép + 1;
                if (rendezettTömb[közép] > 111) felsőhatár = közép - 1;



            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != 111);
            if (rendezettTömb[közép] == 111)
                Console.WriteLine("Van, indexe:" + közép);
            else Console.WriteLine("Nincs");
        }
    }
}
