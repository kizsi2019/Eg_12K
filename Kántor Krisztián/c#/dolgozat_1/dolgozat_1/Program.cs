using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Kérek egy nevet:");
            string nev = Console.ReadLine().ToUpper();



            bool igaz = true;

            List<int> lista = new List<int>();
            do
            {
                Console.WriteLine("Jegyek ,-vel elválasztva:");
                string[] jegyek = Console.ReadLine().Split(',');
                int asd = 0;
                foreach (string item in jegyek)
                {
                    if (Convert.ToInt32(item)<1 || Convert.ToInt32(item) > 5)
                    {
                        asd = 1;
                        
                    }
                }
                if (asd!=1)
                {
                    igaz = false;
                }
                if (asd!=1)
                {
                    foreach (string item2 in jegyek)
                    {
                        lista.Add(Convert.ToInt32(item2));
                    }
                }
            } while (igaz==true);


            int sum = 0;
            foreach (int item in lista)
            {
                sum+= item;
            }
            double avg = Math.Round(Convert.ToDouble(sum) / lista.Count(),2);
            Console.WriteLine(nev+" átlaga: "+avg);

            int maxi = lista[0];
            foreach (int item in lista)
            {
                if (item>maxi)
                {
                    maxi = item;
                }
            }

            Console.WriteLine(nev+" legjobb jegye: "+maxi);

            int mini = lista[0];
            foreach (int item in lista)
            {
                if (item < mini)
                {
                    mini = item;
                }
            }
            Console.WriteLine(nev + " legrosszabb jegye: " + mini);

            //2.
            Console.WriteLine("Kérek egy szöveget:");
            string szoveg = Console.ReadLine();
            Stack<char> verem = new Stack<char>();
            List<char> lista2 = new List<char>();
            foreach (char item in szoveg)
            {
                if (item!=' ')
                {
                    verem.Push(item);
                    lista2.Add(item);
                }
            }

            bool palindrom = true;
            for (int i = 0; i < verem.Count; i++)
            {
                char a = verem.Pop();
                char b = lista2[i];
                if (a!=b)
                {
                    palindrom = false;
                }
            }

            if (palindrom)
            {
                Console.WriteLine("A szöveg PALINDROM");
            }
            else
            {
                Console.WriteLine("A szöveg nem PALINDROM");
            }
            Console.ReadKey();
        }
    }
}
