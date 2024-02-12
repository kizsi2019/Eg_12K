using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> lista = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while(!sr.EndOfStream)
            {
                lista.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            // 3. feladat
            Console.WriteLine($"3. feladat: Az iskolába {lista.Count()} tanuló jár.");

            // 4. feladat
            int max = lista[0].NevHossza;
            for(int i = 1; i < lista.Count; i++)
            {
                if(max < lista[i].NevHossza)
                {
                    max = lista[i].NevHossza;
                }
            }

            Console.WriteLine("4. feladat: A leghosszabb ({0} karakter) nevű tanuló(k):", max);

            foreach (Tanulo t in lista)
            {
                if(t.NevHossza == max)
                {
                    Console.WriteLine("\t{0}", t.Nev);
                }
            }

            // 5. feladat
            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső: {0} - {1}", lista[0].Nev, lista[0].Azonosito);
            Console.WriteLine("\tUtolsó: {0} - {1}", lista[lista.Count - 1].Nev, lista[lista.Count - 1].Azonosito);


            // 6. feladat
            Console.Write("6. feladat: Kérek egy azonosítót [pl.: 4dvavkri]: ");
            string azon = Console.ReadLine();
            int j = 0;
            while (j < lista.Count && lista[j].Azonosito != azon)
            {
                j++;
            }
            if (j < lista.Count)
            {
                Console.WriteLine("\t{0} {1} {2}", lista[j].Ev, lista[j].Osztaly, lista[j].Nev);
            }
            else
            {
                Console.WriteLine("\tNincs megfelelő tanuló");
            }

            Random rand = new Random();
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(rand);
            int index = rand.Next(lista.Count);
            Console.WriteLine("7. feladat: Jelszó generálása");
            Console.WriteLine("\t{0} - {1}", lista[index].Nev, jelszoGeneralo.Jelszó(8));

            Console.ReadKey();
        }
    }
}
