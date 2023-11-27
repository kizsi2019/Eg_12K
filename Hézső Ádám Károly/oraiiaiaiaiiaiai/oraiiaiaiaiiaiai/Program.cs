using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oraiiaiaiaiiaiai
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] szamokT = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            /*StreamReader sr = new StreamReader("számok.txt");
            int[] szamokT = new int[100];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
            }
            int[] negyzetszamokT = new int[100];
            int[] oszathato3zamoT = new int[100];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i]; negyzet_i++;
                }
                if (szamokT[i] % 3 == 0)
                {
                    oszathato3zamoT[osz3_i] = szamokT[i];
                    osz3_i++;
                }
            }
            Console.WriteLine(negyzetszamokT);
            Console.WriteLine(oszathato3zamoT);*/
            /*int[] szamokT = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("adja meg a {0}. szamot: ", i + 1);
                szamokT[i] = int.Parse(Console.ReadLine());

            }
            int e = 0;
            int u = szamokT.Length - 1;
            while (e<= u)
            {
                int csere = 0;
                if (szamokT[e] % 2 == 0)
                {
                    e++;
                }
                else
                {
                    csere = szamokT[e];
                    szamokT[e] = szamokT[u];
                    szamokT[u] = csere;
                    u--;
                }
            }*/
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            for (int i = tomb.Length-1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j+1])
                    {
                        int csere = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = csere;
                    }
                }
            }

            Console.ReadKey();

        }
        /*static int[] paratlanszamok(int[] szamokT, out int paratlanindex)
        {
            int[] paratlanok = new int[szamokT.Length];
            paratlanindex = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] % 2 != 0)
                {
                    paratlanok[paratlanindex] = szamokT[i];
                    paratlanindex++;
                }
            }
            return paratlanok;
        }*/
    }
}
