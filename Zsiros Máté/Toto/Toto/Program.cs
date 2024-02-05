using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<FogadasiFordulo> lista = new List<FogadasiFordulo>();
            foreach(var i in File.ReadAllLines("toto.txt").Skip(1))
            {
                lista.Add(new FogadasiFordulo(i));
            }

            // 3. feladat
            Console.WriteLine("3. feladat: Fordulók száma: ", lista.Count);

            // 4. feladat

            int asd = 0;
            foreach(var item in lista) {
                asd += item.T13p1;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {asd} db");

            // 5. feladat

            double nyOssz = 0;
            int ttFdb = 0;
            foreach (var i in lista)
            {
                checked
                {
                    nyOssz += i.NyereményÖsszeg;
                    ttFdb++;
                }
            }
            Console.WriteLine($"5. feladat: Átlag: {Math.Round(nyOssz / ttFdb)} Ft");

            Console.WriteLine("6. feladat:");
            int maxi = -1;
            int mini = -1;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].T13p1 > 0)
                {
                    if (maxi == -1) maxi = i;
                    if (mini == -1) mini = i;
                    if (lista[i].Ny13p1 > lista[maxi].Ny13p1)
                    {
                        maxi = i;
                    }
                    if (lista[i].Ny13p1 < lista[mini].Ny13p1)
                    {
                        mini = i;
                    }
                }
            }
            Console.WriteLine("\tLegnagyobb:");
            lista[maxi].EredménytKiír();
            Console.WriteLine("\n\tLegkisebb:");
            lista[mini].EredménytKiír();


            // 8. feladat:
            bool xNelkul = false;
            foreach (var i in lista)
            {
                EredmenyElemzo inas = new EredmenyElemzo(i.Eredmenyek);
                if (inas.NemvoltDontetlenMerkozes)
                {
                    xNelkul = true;
                    break;
                }
            }
            Console.WriteLine($"8. feladat: {(xNelkul ? "Volt" : "Nem volt")} döntetlen nélküli forduló!");

            Console.ReadKey();
        }
    }
}