using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iskola
{
    class JelszóGeneráló
    {
        private Random Rnd;

        public JelszóGeneráló(Random r)
        {
            Rnd = r;
        }

        public string Jelszó(int jelszóHossz)
        {
            string jelszó = "";
            while (jelszó.Length < jelszóHossz)
            {
                char c = (char)Rnd.Next(48, 123);
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                {
                    jelszó += c;
                }
            }
            return jelszó;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Import> lista= new List<Import>();
            foreach (var item in File.ReadAllLines("nevek.txt"))
            {
                lista.Add(new Import(item));
            }

            //3
            Console.WriteLine( $"3. feladat: Az iskolába {lista.Count} tanuló jár");
            //4
            int maxi = lista[0].NevHossza;
            for (int i = 1; i < lista.Count; i++)
            {
                if (maxi < lista[i].NevHossza)
                {
                    maxi = lista[i].NevHossza;
                }
            }
            Console.WriteLine($"4. feladat: A leghosszab ({maxi} karakter) nevű tanuló(k):");
            foreach (Import item in lista)
            {
                if (item.NevHossza == maxi)
                {
                    Console.WriteLine("\t{0}", item.nev);
                }
            }

            //5
            Console.WriteLine( "5. feladat: Azonosítók");

            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső: {0} - {1}", lista[0].nev, lista[0].Azonosito);
            Console.WriteLine("\tUtolsó: {0} - {1}", lista[lista.Count - 1].nev, lista[lista.Count - 1].Azonosito);


            //6
            Console.Write("6. feladat: Kérek egy azonosítót [pl.: 4dvavkri]: ");
            string azon = Console.ReadLine();
            int j = 0;
            while (j < lista.Count && lista[j].Azonosito != azon)
            {
                j++;
            }
            if (j < lista.Count)
            {
                Console.WriteLine("\t{0} {1} {2}", lista[j].ev, lista[j].jel, lista[j].nev);
            }
            else
            {
                Console.WriteLine("\tNincs megfelelő tanuló");
            }


            //7
            Random rand = new Random();
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(rand);
            int index = rand.Next(lista.Count);
            Console.WriteLine("7. feladat: Jelszó generálása");
            Console.WriteLine("\t{0} - {1}", lista[index].nev, jelszoGeneralo.Jelszó(8));



            Console.ReadKey();
        }
    }
}
