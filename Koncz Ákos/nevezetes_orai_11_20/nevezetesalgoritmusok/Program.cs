using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevezetesalgoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 3, 2, 1, 2, 3, 4, 6, 7, 8 };
            int count = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                count += tomb[i];
            }
            Console.WriteLine("A tombben tarolt szamok osszege: {0}", count);


            int[] randT = new int[10];

            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 25);
            }

            int j = 0;
            while (j < randT.Length && randT[j] < 15)
            {
                j++;
            }
            Console.WriteLine("...");

            //max

            List<int> lista = new List<int>();
            int max = 0;

            foreach (int i in lista)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            //min

            List<int> lista1 = new List<int>();
            int min = 9999;

            foreach (int i in lista1)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            int[] tomb2 = new int[] { 0, 2, 3, 4, 5, 6, 7, 7, 3, 2, 1, 2, 3, 4, 21, 12, };

            int rak = 0;
            while (0 < tomb2.Length && tomb2[rak] % 2 != 0)
            {
                rak++;
            }
            Console.WriteLine("A feltételnek megfelelő sorszáma {0}", rak);


            // kereses


            int[] tomb20 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a {0}. számot", i + j);
                tomb20[i] = int.Parse(Console.ReadLine());
            }

            int l = 0;
            while (l < tomb20.Length && tomb20[l] % 3 == 0)
            {
                l++;
            }
            if (l < tomb20.Length)
            {
                Console.WriteLine("3mal oszthato szamot {0}.-ra vitt be", j + l);
            }
            else
            {
                Console.WriteLine("Nem adott meg 3mal oszhato szamot");
            }


            int alsohatar = 0;
            int felsohatar = tomb20.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (tomb20[kozep] < 111) alsohatar = kozep + 1;
                if (tomb20[kozep] < 111) felsohatar = kozep - 1;
            }
            while (alsohatar <= felsohatar && tomb20[kozep] != 111);

            else
            {
                Console.WriteLine("Nincs");
            }

           
            
            int[] szamok = { 2, 3, 4, 5, 6, 2, 2, 3, 4 };
            int index;

            int[] paratlanok = ParatlanSzamok(szamok, out index);

            foreach (int szam in paratlanok)
            {
                if (szam != 0)
                {
                    Console.WriteLine(szam);
                }
            }


            //kovitetel

            int[] szamokT = { 2, 3, 4, 5, 6, 3, 8, 9, 7, 6, 5, 4, 3, 2 };

            int[] negyzetszamokT = new int[20];
            int[] oszhatoszamokT = new int[20];
            int negyzet_i = 0, oszt_3 = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i]; negyzet_i++;
                }
                if (szamokT[i] % 3 == 0)
                {
                    oszhatoszamokT[oszt_3] = szamokT[i];
                    oszt_3++;
                }
            }
            Console.WriteLine("Harommal oszhato szamok: ");
            foreach (int i in oszhatoszamokT)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Negyzetszamok: ");
            foreach (int i in negyzetszamokT)
            {
                Console.Write(i + ",");
            }


            Console.ReadKey();
        }
        // kivalogatas
        static int[] ParatlanSzamok(int[] szamok, out int paratlanindex)
        {
            int[] paratlanok = new int[szamok.Length];
            paratlanindex = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 != 0)
                {
                    paratlanok[paratlanindex] = szamok[i];
                    paratlanindex++;
                }
            }

            return paratlanok;
        }
    }
}
