using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulok> nevek = new List<Tanulok>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                nevek.Add(new Tanulok(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3.Feladat: Az iskolába {nevek.Count} tanuló jár");

            int maximum = nevek[0].nevhossz;
            for (int i = 1; i < nevek.Count; i++)
            {
                if (maximum < nevek[i].nevhossz)
                {
                    maximum = nevek[i].nevhossz;
                }
            }

            Console.WriteLine("4. feladat: A leghosszab ({0} karakter) nevű tanuló(k):", maximum);
            foreach (Tanulok t in nevek)
            {
                if (t.nevhossz == maximum)
                {
                    Console.WriteLine("\t{0}", t.Nev);
                }
            }

            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső: {0} - {1}", nevek[0].Nev, nevek[0].Azonosíto);
            Console.WriteLine("\tUtolsó: {0} - {1}", nevek[nevek.Count - 1].Nev, nevek[nevek.Count - 1].Azonosíto);

            Console.Write("6. feladat: Kérek egy azonosítót [pl.: 4dvavkri]: ");
            string azon = Console.ReadLine();
            int asd = 0;
            while (asd < nevek.Count && nevek[asd].Azonosíto != azon)
            {
                asd++;
            }
            if (asd < nevek.Count)
            {
                Console.WriteLine("\t{0} {1} {2}", nevek[asd].Ev, nevek[asd].Osztaly, nevek[asd].Nev);
            }
            else
            {
                Console.WriteLine("\tNincs megfelelő tanuló");
            }

            Random random = new Random();
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(random);
            int index = random.Next(nevek.Count);
            Console.WriteLine("7. feladat: Jelszó generálása");
            Console.WriteLine("\t{0} - {1}", nevek[index].Nev, jelszoGeneralo.Jelszó(8));

            Console.ReadKey();
        }
    }
}
