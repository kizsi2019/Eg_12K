using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace nevezetes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            StreamReader sr = new StreamReader("asd.txt");
            int[] szamokT = new int[100];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
            }
            //szétválogatás
            int[] negyzetszamokT = new int[100];
            int[] oszhato3szamokT = new int[100];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {    //négyzetszám vizsgálat
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i];
                    negyzet_i++;
                }
                //oszthatóság vizsgálat
                if (szamokT[i] % 3 == 0)
                { oszhato3szamokT[osz3_i] = szamokT[i]; osz3_i++; }
            }


            int[] szamokT2 = new int[20];
            //bekérés a felhasználótól
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a {0}. számot: ", i);
                szamokT2[i] = int.Parse(Console.ReadLine());
            }
            //szétválogatás helyben
            int e = 0;
            int u = szamokT2.Length - 1;
            while (e <= u)
            {
                int csere = 0;
                if (szamokT2[e] % 2 == 0) e++;
                else
                {
                    csere = szamokT2[e];
                    szamokT2[e] = szamokT2[u];
                    szamokT2[u] = csere; u--;
                }
            }

            foreach (int i in szamokT2)
            {
                Console.WriteLine(i);
            }

        }
        static int[] PáratlanSzámok(int[] számokT, out int páratlanindex)
        {
            int[] páratlanok = new int[számokT.Length];
            páratlanindex = 0;
            for (int i = 0; i < számokT.Length; i++)
            {
                if (számokT[i] % 2 != 0)
                {
                    páratlanok[páratlanindex] = számokT[i];
                    páratlanindex++;
                }
            }
            return páratlanok;
        }

        static int[] BuborékosRendezés(int[] Tömb)
        {
            for (int i = Tömb.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Tömb[j] > Tömb[j + 1])
                    {
                        int csere = Tömb[j];
                        Tömb[j] = Tömb[j + 1];
                        Tömb[j + 1] = csere;
                    }
                }
            }
            return Tömb;
        }
    }
}
