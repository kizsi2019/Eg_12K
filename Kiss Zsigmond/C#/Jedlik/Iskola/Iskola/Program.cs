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
            // 2. feladat: adatok beolvasása és tárolása
            List<Tanuló> tanulók = new List<Tanuló>();
            foreach (var i in File.ReadAllLines("nevek.txt"))
            {
                tanulók.Add(new Tanuló(i));
            }

            Console.WriteLine($"3. feladat: Az iskolába {tanulók.Count} tanuló jár.");

            // 4. feladat
            int maxHossz = tanulók.First().NévHossza;
            foreach (var i in tanulók.Skip(1))
            {
                if (i.NévHossza > maxHossz) maxHossz = i.NévHossza;
            }
            Console.WriteLine($"4. feladat: A leghosszabb ({maxHossz} karakter) nevű tanuló(k):");
            foreach (var i in tanulók)
            {
                if (i.NévHossza == maxHossz) Console.WriteLine($"\t{i.Név}");
            }

            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine($"\tElső: {tanulók.First().Név} - {tanulók.First().Azonosító}");
            Console.WriteLine($"\tUtolsó: {tanulók.Last().Név} - {tanulók.Last().Azonosító}");

            Console.Write("6. feladat: Kérek egy azonosítót [pl.: 4dvavkri]: ");
            string inputAzon = Console.ReadLine();
            bool vanIlyenDiák = false;
            foreach (var i in tanulók)
            {
                if (i.Azonosító == inputAzon)
                {
                    vanIlyenDiák = true;
                    Console.WriteLine($"\t{i.KezdésOsztály} {i.Név}");
                }
            }
            if (!vanIlyenDiák) Console.WriteLine("\tNincs megfelelő tanuló.");

            Console.WriteLine("7. feladat: Jelszó generálása");
            Random r = new Random();
            Tanuló randomTanuló = tanulók[r.Next(0, tanulók.Count)];
            JelszóGeneráló jg = new JelszóGeneráló(r);
            Console.WriteLine($"\t {randomTanuló.Név} - {jg.Jelszó(8)}");

            Console.ReadKey();
        }
    }
}
