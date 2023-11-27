using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", osszeg);

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
            if (j < randT.Length)
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }

            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);

            int mini = 0;
            int maxi = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[maxi])
                {
                    maxi = i;
                }
                if (tomb[i] < tomb[mini])
                {
                    mini = i;
                }
            }
            Console.WriteLine("max:" + tomb[maxi] + " " + maxi);
            Console.WriteLine("min:" + tomb[mini] + " " + mini);

            int c = 0;
            while (c < tomb.Length && tomb[c] % 2 == 0)
            {
                c++;
            }
            Console.WriteLine(c);


            int d = 0;
            while (d < tomb.Length && tomb[d] % 3 != 0)
            {
                d++;
            }
            if (d < tomb.Length)
            {
                Console.WriteLine("Sorszám: " + d);
            }
            else
            {
                Console.WriteLine("nincs");
            }


            int[] tomb2 = new int[] { 10, 13, 15, 20, 25, 30, 33, 40, 45, 70, 90, 100 };
            int alsohatar = 0;
            int felsohatar = tomb2.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (tomb2[kozep] < 90)
                {
                    alsohatar = kozep + 1;
                }
                if (tomb2[kozep] > 90)
                {
                    felsohatar = kozep - 1;
                }
            } while (alsohatar <= felsohatar && tomb2[kozep] != 90);

            if (tomb2[kozep] == 90)
            {
                Console.WriteLine("van:" + kozep);
            }
            else
            {
                Console.WriteLine("nincs");
            }


            int asd = 0;
            int[] dsa = ParatlanSzamok(tomb, out asd);
            foreach (int item in dsa)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }

            }


            StreamReader sr = new StreamReader ("szamok.txt" );

            int[] szamokT = new int[20];
            int k = 0;
            while (!sr.EndOfStream)
            {
                szamokT[k] = int.Parse(sr.ReadLine());
                k++;
            }

            int[] negyzetszamokT = new int[20];
            int[] oszthatoszamokT = new int[20];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i]; negyzet_i++;
                }

                if (szamokT[i] % 3 == 0)
                {
                    oszthatoszamokT[osz3_i] = szamokT[i]; osz3_i++;
                }
            }

            Console.WriteLine("Négyzetszámok:");
            foreach (int item in negyzetszamokT)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Hárommal osztható:");

            foreach (int item in oszthatoszamokT)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
            }

            /*

            int[] szamokT2= new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("adja meg a {0} számot",i+1 );
                szamokT2[i]=int.Parse(Console.ReadLine());
            }

            int e = 0;
            int u =szamokT2.Length-1;
            while (e<=u)
            {
                int csere = 0;
                if (szamokT2[e]%2 ==0)
                {
                    e++;
                }
                else
                {
                    csere = szamokT2[e];
                    szamokT2[e]=szamokT2[u];
                    szamokT2[u] = csere;
                    u--;
                }
            }

            Console.WriteLine( "számok");
            foreach (int item in szamokT2)
            {
                Console.WriteLine( item);
            }*/


            int[] tombbb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

            for (int i = tombbb.Length-1; i >1; i--)
            {
                for (int h = 0; h < i; h++)
                {
                    if (tombbb[h] > tombbb[h+1])
                    {
                        int csere = tombbb[h];
                        tombbb[h] = tombbb[h+1];
                        tombbb[h + 1] = csere;
                    }
                }
            }
            Console.WriteLine(  "rák");
            foreach (int item in tombbb)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
            
        }

        static int[] ParatlanSzamok(int[] szamokT, out int paratlanindex)
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
        }
    }
}
