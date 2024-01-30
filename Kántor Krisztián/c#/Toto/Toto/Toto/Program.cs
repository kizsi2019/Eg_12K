using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            List<EredmenyElemzo> lista = new List<EredmenyElemzo>();
            foreach (var sor in File.ReadAllLines("toto.txt").Skip(1))
            {
                lista.Add(new EredmenyElemzo(sor));
            }

            //3
            Console.WriteLine($"3. feladat: Fordulók száma: {lista.Count}");


            //4
            int count = 0;
            foreach (EredmenyElemzo item in lista)
            {
                if (item.t13p1>0)
                {
                    count+=item.t13p1;
                }
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {count} db");

            //5
            double avg = 0;
            Int64 nyeremenyOsszeg = 0;
            int db = 0;
            foreach(EredmenyElemzo item in lista)
            {
                if (item.t13p1>0)
                {
                    nyeremenyOsszeg += item.t13p1 * item.ny13p1;
                    
                    
                }
            }
            avg = Math.Round( Convert.ToDouble(nyeremenyOsszeg)/ Convert.ToDouble(lista.Count));
            Console.WriteLine($"5. feladat: Átlag: {avg} Ft");

            //6
            int maxi = -1;
            int mini = -1;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].t13p1 > 0)
                {
                    if (maxi == -1) maxi = i;
                    if (mini == -1) mini = i;
                    if (lista[i].ny13p1 > lista[maxi].ny13p1)
                    {
                        maxi = i;
                    }
                    if (lista[i].ny13p1 < lista[mini].ny13p1)
                    {
                        mini = i;
                    }
                }
            }
            Console.WriteLine("\tLegnagyobb:");
            Console.WriteLine($"\tÉv: {lista[maxi].ev}");
            Console.WriteLine($"\tHét: {lista[maxi].het}.");
            Console.WriteLine($"\tForduló: {lista[maxi].fordulo}.");
            Console.WriteLine($"\tTelitalálat: {lista[maxi].t13p1} db");
            Console.WriteLine($"\tNyeremény: {lista[maxi].ny13p1} Ft");
            Console.WriteLine($"\tEredmények: {lista[maxi].eredmeny}");


            Console.WriteLine("\n\tLegkisebb:");
            Console.WriteLine($"\tÉv: {lista[mini].ev}");
            Console.WriteLine($"\tHét: {lista[mini].het}.");
            Console.WriteLine($"\tForduló: {lista[mini].fordulo}.");
            Console.WriteLine($"\tTelitalálat: {lista[mini].t13p1} db");
            Console.WriteLine($"\tNyeremény: {lista[mini].ny13p1} Ft");
            Console.WriteLine($"\tEredmények: {lista[mini].eredmeny}");


            //8
            /*
            bool dontetlen = false;
            foreach (var i in lista)
            {
                EredmenyElemzo ell = new EredmenyElemzo(i.eredmeny);
                if (ell.NemvoltDontetlenMerkozes)
                {
                    dontetlen = true;
                    break;
                }
            }
            Console.WriteLine($"8. feladat: {(dontetlen ? "Volt" : "Nem volt")} döntetlen nélküli forduló!");
            */

            Console.ReadKey();
        }
    }
}
