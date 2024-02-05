using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Feladat
            List<Tanulok> Tanulok_Lista = new List<Tanulok>();
            foreach (var i in File.ReadAllLines("nevek.txt"))
            {
                Tanulok_Lista.Add(new Tanulok(i));
            }

            Console.WriteLine($"3.Feladat: Az iskolába {Tanulok_Lista.Count} tanuló jár." );

            //4. Feladat
            int max = Tanulok_Lista[0].NevHossza;
            for (int i = 1; i < Tanulok_Lista.Count; i++)
            {
                if (max < Tanulok_Lista[i].NevHossza)
                {
                    max = Tanulok_Lista[i].NevHossza;
                }
            }
            

            Console.WriteLine("4. feladat: A leghosszab ({0} karakter) nevű tanuló(k):", max);
            foreach (Tanulok t in Tanulok_Lista)
            {
                if (t.NevHossza == max)
                {
                    Console.WriteLine("\t{0}", t.Nev);
                }
            }
            //5.Feladat
            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\t első : {0} - {1}", Tanulok_Lista[0].Nev, Tanulok_Lista[0].Azonosito);

            Console.WriteLine("\t utolsó : {0} - {1}", Tanulok_Lista[Tanulok_Lista.Count - 1].Nev, Tanulok_Lista[Tanulok_Lista.Count - 1].Azonosito);

            //6.Feladat
            Console.Write("6. feladat: Kérek egy azonosítót [pl.: 4dvavkri]: ");
            string azon = Console.ReadLine();
            int j = 0;
            while (j < Tanulok_Lista.Count && Tanulok_Lista[j].Azonosito != azon)
            {
                j++;
            }
            if (j < Tanulok_Lista.Count)
            {
                Console.WriteLine("\t{0} {1} {2}", Tanulok_Lista[j].Ev, Tanulok_Lista[j].Osztaly, Tanulok_Lista[j].Nev);
            }
            else
            {
                Console.WriteLine("\t Nincs megfelelő tanuló");
            }
            //7.Feladat
            Random rand = new Random();
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(rand);

            int ind = rand.Next(Tanulok_Lista.Count);
            Console.WriteLine("7. feladat: Jelszó generálása");
            Console.WriteLine("\t{0} - {1}", Tanulok_Lista[ind].Nev, jelszoGeneralo.Jelszó(8));

            Console.ReadKey();

        }
    }
}
