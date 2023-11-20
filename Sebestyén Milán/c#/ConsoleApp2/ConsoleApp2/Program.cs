using System;
namespace NevezetesAlgoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] tomb = new int[]{ 32, 12, 10, 9, 45, 91, 13, 8, 1, 42 };
            int ossz = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                ossz += tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: "+ ossz);
            Console.ReadKey();
            */

            /*
            int[] ranT = new int[10];
            Random r = new Random();
            for(int i = 0; i < ranT.Length; i++)
            {
                ranT[i] = r.Next(0, 21);
            }
            int j = 0;
            while(j < ranT.Length && ranT[j] <= 15)
            {
                j++;
            }
            if(j < ranT.Length)
            {
                Console.WriteLine("Van");
                else
                {
                    Console.WriteLine("Nincs");
                }
            }
            */

            /*
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
            Console.WriteLine("A generált tömbben {0}db páros szám van.", db);
            */

            /*
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int nagyob_index = 0;
            int kiseb_index = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                if(tomb[i] > tomb[nagyob_index])
                {
                    nagyob_index = i;
                }
                if(tomb[i] < tomb[kiseb_index])
                {
                    kiseb_index = i;
                }
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", nagyob_index, tomb[nagyob_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}" , kiseb_index, tomb[kiseb_index]);
            */

            /*
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while(i < tomb.Length && tomb[i] % 2 != 1)
            {
                i++;
            }
            Console.WriteLine("A feltételnek megfelelő elem sorszáma "+ i);
            */

            /*
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < tomb.Length && tomb[i] % 2 != 1)
            {
                i++;
            }
            if(i<tomb.Length)
            {
                Console.WriteLine("A feltételnek megfelelő elem sorszáma "+ i);
            }
            */

            /*
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int also = 0;
            int felso = tomb.Length - 1;
            */


        }
    }
}