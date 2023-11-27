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
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}",osszeg);

            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j<randT.Length&&randT[j]<=15)
            {
                j++;
            }
            if (j<randT.Length)
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
                if (randT[i]%2==0)
                {
                    db++;
                }
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van",db);

            int mini = 0;
            int maxi = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]>tomb[maxi])
                {
                    maxi = i;
                }
                if(tomb[i] < tomb[mini])
                {
                    mini = i;
                }
            }
            Console.WriteLine("max:"+tomb[maxi]+" "+maxi);
            Console.WriteLine("min:" + tomb[mini]+" "+mini);

            int c = 0;
            while (c<tomb.Length&&tomb[c]%2==0)
            {
                c++;
            }
            Console.WriteLine(c);


            int d = 0;
            while (d < tomb.Length && tomb[d] % 3 != 0)
            {
                d++;
            }
            if (d<tomb.Length)
            {
                Console.WriteLine("Sorszám: "+d);
            }
            else
            {
                Console.WriteLine("nincs");
            }


            int[] tomb2 = new int[] {10,13,15,20,25,30,33,40,45,70,90,100 };
            int alsohatar = 0;
            int felsohatar = tomb2.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (tomb2[kozep]<90)
                {
                    alsohatar = kozep + 1;
                }
                if (tomb2[kozep] > 90)
                {
                    felsohatar = kozep - 1;
                }
            } while (alsohatar<=felsohatar&&tomb2[kozep]!=90);

            if (tomb2[kozep]==90)
            {
                Console.WriteLine("van:"+kozep);
            }
            else
            {
                Console.WriteLine("nincs");
            }


            int asd = 0;
            int[] dsa = ParatlanSzamok(tomb, out asd);
            foreach (int item in dsa)
            {
                if (item!=0)
                {
                    Console.WriteLine(item);
                }
                
            }


            int[] szamokT = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int[] negyzetszamokT = new int[20];
            int[] oszthatoszamokT = new int[20];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i]>0&&Math.Sqrt(szamokT[i])%1==0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i];negyzet_i++;
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



            Console.ReadKey();
        }

        static int[] ParatlanSzamok(int[] szamokT,out int paratlanindex)
        {
            int[] paratlanok = new int[szamokT.Length];
            paratlanindex = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i]%2!=0)
                {
                    paratlanok[paratlanindex] = szamokT[i];
                    paratlanindex++;
                }

            }
            return paratlanok;
        }
    }
}
