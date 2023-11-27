using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nevezetes_Algoritmusok2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiválogatás

            /*int[] szamokTt = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int js = 2;
            PáratlanSzámok(szamokTt, out js);
            foreach(int item in PáratlanSzámok(szamokTt, out js))
            {
                Console.WriteLine(item);
            }*/

            //Szétválogatás
            /*StreamReader sr = new StreamReader("számok.txt");
            int[] szamokT = new int[12];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
            }
            int[] negyzetszamokT = new int[12];
            int[] oszthato3szamokT = new int[12];
            int negyzet_i = 0, ossz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if(szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i]; negyzet_i++;
                }
                if(szamokT[i] % 3 == 0)
                {
                    oszthato3szamokT[ossz3_i] = szamokT[i];
                    ossz3_i++;
                }
            }
            foreach(int item in negyzetszamokT)
            {
                Console.WriteLine("Négyzetszámok: {0}", item);
            }
            foreach(int item in oszthato3szamokT)
            {
                Console.WriteLine("hárommal osztható számok: " + item);
            }*/

            //Szétválogatás helyben

            /*int[] szamokT2 = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot", i + 1);
                szamokT2[i] = int.Parse(Console.ReadLine());
            }
            int e = 0;
            int u = szamokT2.Length - 1;
            while (e <= u)
            {
                int csere = 0;
                if(szamokT2[e] % 2 == 0)
                {
                    e++;
                }
                else
                {
                    csere = szamokT2[e];
                    szamokT2[e] = szamokT2[u];
                    szamokT2[u] = csere;
                    u--;
                }
            }
            foreach(int item in szamokT2)
            {
                Console.Write(item + ",");
            }*/

            //Buborékos rendezés tétele

            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            for (int i = Tömb.Length - 1; i > 1; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if(Tömb[j] > Tömb[j + 1])
                    {
                        int csere = Tömb[j];
                        Tömb[j] = Tömb[j + 1];
                        Tömb[j + 1] = csere;
                    }
                }
            }
            foreach(int item in Tömb)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int[] PáratlanSzámok(int[] számokT, out int páratlanindex)
        {
            int[] páratlanok = new int[számokT.Length];
            páratlanindex = 0;
            for (int i = 0; i < számokT.Length; i++)
            {
                if(számokT[i] % 2 != 0)
                {
                    páratlanok[páratlanindex] = számokT[i];
                    páratlanindex++;
                }
            }
            return páratlanok;
        }


    }
}
