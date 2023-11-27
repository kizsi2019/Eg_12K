using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NevezetesAlgoritmusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 2, 3, 10, 43, 31, 49, 64, 77, 83, 25, 41, 59, 69,  };
            /*PáratlanSzámok(szamokT, out 5);
            foreach (int item in szamokT)
            {
                //Console.WriteLine(item);
               
            }*/


            //szétválogatás tétele:

            StreamReader sr = new StreamReader("számok.txt");
            int[] szamokT = new int[100];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
            }

            int[] negyzetszamok = new int[100];
            int[] oszthato3szamok = new int[100];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                //négyzetszám vizsgálat
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamok[negyzet_i] = szamokT[i];negyzet_i++;
                }

                //oszthatóság
                if (szamokT[i] % 3 == 0)
                {
                    oszthato3szamok[osz3_i] = szamokT[i];
                    osz3_i++;
                }
            }
            
            foreach(int item in negyzetszamok)
            {
                Console.WriteLine(negyzet_i);
            }


            int[] szamok = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot: ", i +1);
                szamok[i] = int.Parse(Console.ReadLine());
            }

            int e = 0;
            int u = 0;
            while (e <= u)
            {
                int csere = 0;
                if (szamok[e] % 2 == 0)
                {
                    e++;
                }
                else
                {
                    csere = szamok[e];
                    szamok[e] = szamok[u];
                    szamok[u] = csere;
                    u--;
                }
            }
            foreach(int item in szamok)
            {
                Console.WriteLine(item);
            }


            for (int i = tomb.Length - 1; i > 1; i--)
            {
                for(int j = 0; j)
            }


        }

        /*static int[] PáratlanSzámok(int[] szamokT, out int páratlanindex)
        {
            int[] páratlanok = new int[szamokT.Length];
            páratlanindex = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] % 2 != 0)
                {
                    páratlanok[páratlanindex] = szamokT[i];
                    páratlanindex++;
                }
            }
            return páratlanok;
        }*/
    }
}
