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







            Console.ReadKey();
        }
    }
}
