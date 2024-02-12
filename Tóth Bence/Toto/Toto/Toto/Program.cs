using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            List<FogadasiFordulo> lista = new List<FogadasiFordulo>();
            foreach (var i in File.ReadAllLines("toto.txt").Skip(1)) 
            {
                lista.Add(new FogadasiFordulo(i));
            }

            //3.feladat
            Console.WriteLine(lista.Count());


            // 4. feladat:
            int sz13p1Db = 0;
            foreach (var i in lista)
            {
                sz13p1Db += i.T13p1;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {sz13p1Db} db");

            // 5. feladat:
            double nyOsszeg = 0;
            int teliT = 0;
            foreach (var i in lista)
            {
                checked
                {
                    nyOsszeg += i.NyereményÖsszeg;
                    teliT++;
                }
            }
            Console.WriteLine($"5. feladat: Átlag: {Math.Round(nyOsszeg / teliT)} Ft");

            Console.WriteLine("6. feladat:");
            int max = -1;
            int min = -1;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].T13p1 > 0)
                {
                    if (max == -1) max = i;
                    if (min == -1) min = i;
                    if (lista[i].Ny13p1 > lista[max].Ny13p1)
                    {
                        max = i;
                    }
                    if (lista[i].Ny13p1 < lista[min].Ny13p1)
                    {
                        min = i;
                    }
                }
            }

            Console.WriteLine("\tLegnagyobb:");
            lista[max].EredménytKiír();
            Console.WriteLine("\n\tLegkisebb:");
            lista[min].EredménytKiír();

            // 8. feladat:
            bool nincsDont = false;
            foreach (var i in lista)
            {
                EredmenyElemzo a = new EredmenyElemzo(i.Eredmenyek);
                if (a.NemvoltDontetlenMerkozes)
                {
                    nincsDont = true;
                    break;
                }
            }
            Console.WriteLine($"8. feladat: {(nincsDont ? "Volt" : "Nem volt")} döntetlen nélküli forduló!");


            Console.ReadKey();
        }
    }
}
