using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat

            List<Dijazott> dijazottak = new List<Dijazott>();

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            // 3. feladat

            Console.WriteLine($"3. feladat: Díjazottak száma: { dijazottak.Count } fő");

            // 4. feladat

            int utolsoev = dijazottak.First().Év;

            foreach (var i in dijazottak.Skip(1))
            {
                if (i.Év > utolsoev)
                {
                    utolsoev = i.Év;
                }
            }

            Console.WriteLine($"4. feladat: Utolsó év: { utolsoev }");

            //5. feladat

            Console.WriteLine("5. feladat: Kérem adja meg egy ország kódját:");

            string kod = Console.ReadLine();

            int kodmennyiseg = 0;

            foreach (var i in dijazottak)
            {
                if (kod == i.Országkód)
                {
                    kodmennyiseg += 1;
                }
            }
            
            
            foreach (var i in dijazottak)
            {
                if (kodmennyiseg == 0)
                {
                    Console.WriteLine("Nem volt ilyen ország!");
                    break;
                }
                if (kodmennyiseg == 1 && kod == i.Országkód)
                {
                    Console.WriteLine($"\tA megadott ország díjazottja:\n\tNév: {i.Név}\n\tÉv: {i.Év}\n\tSz/h: {i.SzületésHalálozás}");
                    break;
                }
                if (kodmennyiseg > 1)
                {
                    Console.WriteLine($"A megadott országkódból {kodmennyiseg} fő díjazott volt");
                    break;
                }
            }

            Console.WriteLine("6. feladat: Statisztika");

            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            foreach (var i in dijazottak)
            {
                if (dict.ContainsKey(i.Országkód))
                {
                    dict[i.Országkód]++;
                }
                else
                {
                    dict.Add(i.Országkód, 1);
                }
            }

            foreach (var i in dict)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value} fő");
                }
            }


            Console.ReadKey();
        }
    }
}
