using System;
using System.Xml.Linq;

namespace NevezetesAlgoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Összeadás tétele:
            int[] tomb = new int[11] { 32, 12, 10, 9, 45, 91, 13, 8, 1, 42 };
            int summa = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                summa += tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", summa);
            Console.ReadKey();*/


            /*Eldöntés tétele:
            int[] ranT = new int[10];
            Random r = new Random();
            for(int i = 0; i < ranT.Length; i++)
            {
                ranT[i] = r.Next(0, 21);
            }
            int j = 0;
            while(j < ranT.Length && ranT[i] <= 15)
            {
                j++;
            }
            if(j < ranT.Length &&)
            {
                Console.WriteLine("Van");
                else
                {
                    Console.WriteLine("Nincs");
                }
            }*/


            /*Megszámlálás tétele:
            int[] randT = new int[10];
            Random r = new Random();
            for(int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int db = 0;
            for(int i = 0; i< randT.Length; i++)
            {
                if (randT[i] % 2 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van.", db);*/


            /*Maximum/minimum kiválasztás tétele:
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                if(tomb[i] > tomb[legnagyobb_index])
                {
                    legnagyobb_index = i;
                }
                if(tomb[i] < tomb[legkisebb_index])
                {
                    legkisebb_index = i;
                }
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, tomb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}" , legkisebb_index, tomb[legkisebb_index]);*/


            /*Kiválasztás tétele:
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while(i < tomb.Length && tomb[i] % 2 != 1)
            {
                i++;
            }
            Console.WriteLine("A feltételnek megfelelő elem sorszáma {0}.", i);*/


            /*Keresés tétele:
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < tomb.Length && tomb[i] % 2 != 1)
            {
                i++;
            }
            if(i<tomb.Length)
            {
                Console.WriteLine("A feltételnek megfelelő elem sorszáma {0}", i);
            }
            else
            {
                Console.WriteLine("Nincs ilyen feltételnek megfelelő elem);
            }*/

            /*Logaritmus keresés tétel:
            int[] rendezettTomb = new int[] { 10, 15, 18, 25, 31, 49, 68, 72, 80, 83 };
            int alsohatar = 0;
            int felsohatar = rendezettTomb.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (rendezettTomb[kozep] < 31)
                {
                    alsohatar = kozep + 1;
                }
                if (rendezettTomb[kozep] > 31)
                {
                    felsohatar = kozep - 1;
                }
            } while (alsohatar <= felsohatar && rendezettTomb[kozep] != 31);
            if (rendezettTomb[kozep] == 31)
            {
                Console.WriteLine("Van, indexe: " + kozep);
            }
            else
            {
                Console.WriteLine("Nincs");
            }*/


            /*Kiválogatás tétele
            int[] szamokT = new int[] {32, 12, 10, 9, 45, 90, 13, 8, 3, 42};
            static int[] ParatlanSzamok(int[] szamokT, out int paratlanindex)
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
            }*/


            /*Szétválogatás tétele
            StreamReader sr = new StreamReader("szamok.txt");
            int[] szamokT = new int[20];
            int j = 0;
            while(!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
            }
            int[] negyzetszamokT = new int[20];
            int[] oszthato3szamokT = new int[20];
            int negyzet_i  = 0;
            int oszt3_i = 0;
            for(int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i];
                    negyzet_i++;
                }
                if (szamokT[i] % 3 == 0)
                {
                    oszthato3szamokT[oszt3_i] = szamokT[i];
                    oszt3_i++;
                }
            }*/



            /*Szétválogatás tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 3, 1, 42 };
            int[] szamokT = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot", i+1);
                szamokT[i] = int.Parse(Console.ReadLine());
            }
            int e = 0;
            int u = szamokT.Length-1;
            while(e <= u)
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
            }
            foreach (int i in szamokT)
            {
                Console.WriteLine(i);
            }*/


            /*Buborékos elemzés tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 3, 1, 42 };
            for (int i = Tomb.Length - 1; i > 1; i--){
                for(int j = 0; j<1; j++)
                {
                    if (Tomb[j] > Tomb[j + 1])
                    {
                        int csere = Tomb[j];
                        Tomb[j] = Tomb[j + 1];
                        Tomb[j+1] = csere;
                    }
                }
            }
            foreach (int i in Tomb)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}