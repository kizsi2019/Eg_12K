using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9 ,43, 561, 63, 1 ,35};

            int összeg = 0;
            foreach(int item in Tömb)
            {
                összeg += item;
            }
            Console.WriteLine("A tömbben tárolt elemek összege: {0}", összeg);



            int[] randT = new int[10];
            Random r = new Random();
            for(int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while( j< randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");

            int legnagyobb_index = 0;
            int legkissebb_index = 0;
            for(int i =0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkissebb_index]) legkissebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke: {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkissebb elem indexe {0}, értéke: {1}", legkissebb_index, Tömb[legkissebb_index]);

            int o = 0;
            while(o < Tömb.Length && Tömb[o] % 2 != 1)
            {
                o++;
            }
            Console.WriteLine("A feltételnek megfelelő elem sorszáma: {0}",o);

            int[] Beolvasás = new int[20];
            for(int i = 0; i< 20; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot: ", i +1);
                Beolvasás[i] = int.Parse(Console.ReadLine());
            }

            int jj= 0;
            while(jj < Beolvasás.Length && Beolvasás[jj] % 3 != 0)
            {
                jj++;
            }
            if (jj < Beolvasás.Length) Console.WriteLine("3-mal osztható {0}.-ra vitt be!", jj +1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot");

            int[] rendezett_Tömb = new int[] { 10, 15, 18, 30, 31, 49, 60, 72, 90, 99 };
            int alsohatar = 0;
            int felsohatar = rendezett_Tömb.Length - 1;
            int közep = 0;

            do
            {
                közep = (alsohatar + felsohatar) / 2;
                if (rendezett_Tömb[közep] < 111) alsohatar = közep + 1;
                if (rendezett_Tömb[közep] > 111) felsohatar = közep - 1;
            } while (alsohatar <= felsohatar && rendezett_Tömb[közep] != 111);
            if(rendezett_Tömb[közep] == 111)
                Console.WriteLine("Van indexe: " + közep);
            else Console.WriteLine("Nincs");

            Console.ReadKey();
        }
    }
}
