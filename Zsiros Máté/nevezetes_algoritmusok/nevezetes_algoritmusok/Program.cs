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
            int[] tomb = new int[] { 23, 23, 23, 2, 32, 3, 2, 32, 3, 2, 32, 3, 23, 2 };
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


        }
    }
}
