using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevezetes_algoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] tomb = new int[] { 23, 23, 23, 2, 32, 3, 2, 32, 3, 2, 32, 3, 23, 2 };
            int osszeg = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("A számok összege: ", osszeg);


            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }

            int j = 0;
            while(j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("nincs");


            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[legnagyobb_index]) legnagyobb_index = i;
                if (tomb[i] < tomb[legkisebb_index]) legkisebb_index = i;
            }

            Console.WriteLine("legnagyobb és legkisebb szám");

            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            Console.WriteLine(i);

            */

            /*for (int i = 0; i < tomb.Length; i++)
            {

            }
        }*/

            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int[] Ftomb = new int[tomb.Length];
            int paratlan = 0;
            foreach (int item in tomb)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
            }

            ParatlanSzamok(tomb, out paratlan);

            int[] szamokT = new int[] {123, 12, 321, 3, 123, 12, 321, 3, 12, 321, 3, 213, 12, 321, 3, 213 , 2435, 435, 65, 7};
            //szétválogatás
            int[] negyzetszamokT = new int[20];
            int[] oszhato3szamokT = new int[20];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                //négyzetszám vizsgálat
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                { negyzetszamokT[negyzet_i] = szamokT[i]; negyzet_i++; }
                //oszthatóság vizsgálat
                if (szamokT[i] % 3 == 0)
                { oszhato3szamokT[osz3_i] = szamokT[i]; osz3_i++; }
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
