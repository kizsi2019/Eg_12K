using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int paratlan = 0;
            int[] szamokT = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            ParatlanSzamok(szamokT, out paratlan);
            foreach (int item in szamokT)
            {
                if (item != 0) // Exclude the unused elements in the array
                {
                    Console.WriteLine(item);
                }
            }*/
            

            
            int[] tomb = new int[] {1, 2, 4, 6, 8 ,7 , 9 , 12, 32, 47, 52, 64, 77, 27, 18, 19, 99, 87, 58, 36 };
            int[] negyzetszamok = new int[20];
            int[] oszthato3szamok = new int[20];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if(tomb[i] > 0 && Math.Sqrt(tomb[i]) % 1 == 0)
                {
                    negyzetszamok[negyzet_i] = tomb[i]; negyzet_i++;
                }
                if(tomb[i] % 3 == 0)
                {
                    oszthato3szamok[osz3_i] = tomb[i]; osz3_i++;
                }
            }

            /*foreach(int item in negyzetszamok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();*/

            foreach(int item in oszthato3szamok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    




        /*static int[] ParatlanSzamok(int[] szamokT, out int paratlanindex)
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
