using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CBradio
{

    class cbradio
    {
        static void Main()
        {
            // 2. feladat
            List<Bejegyzes> b = new List<Bejegyzes>();
            foreach (var i in File.ReadAllLines("cb.txt").Skip(1))
            {
                b.Add(new Bejegyzes(i));
            }

            // 3. feladat:
            Console.WriteLine($"3. feladat: Bejegyzések száma: {b.Count} db");

            // 4. feladat
            bool VoltNegyesBej = false;
            foreach (var i in b)
            {
                if (i.AdasDb == 4)
                {
                    VoltNegyesBej = true;
                    break;
                }
            }
            Console.WriteLine($"4. feladat: {(VoltNegyesBej ? "Volt" : "Nem volt")} négy adást indító sofőr.");

            // 5. feladat:
            Console.Write("5. feladat: Kérek egy nevet: ");
            string inputNev = Console.ReadLine();
            int adasDb = 0;
            foreach (var i in b)
            {
                if (i.Nev == inputNev) adasDb += i.AdasDb;
            }
            if (adasDb == 0) Console.WriteLine("\tNincs ilyen nevű sofőr!");
            else Console.WriteLine($"\t{inputNev} {adasDb}x használta a CB-rádiót.");

            // 7. feladat
            List<string> ki = new List<string>();
            ki.Add("Kezdes;Nev;AdasDb");
            foreach (var i in b)
            {
                ki.Add($"{i.Kezdes};{i.Nev};{i.AdasDb}");
            }
            File.WriteAllLines("cb2.txt", ki);

            // 8. sofőrök száma:
            HashSet<string> nevek = new HashSet<string>();
            foreach (var i in b)
            {
                nevek.Add(i.Nev);
            }

            Console.WriteLine($"8. feladat: Sofőrök száma: {nevek.Count} fő");

            // 9. Legtöbb adást indító söfőr
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in b)
            {
                if (stat.ContainsKey(i.Nev)) stat[i.Nev] += i.AdasDb;
                else stat.Add(i.Nev, i.AdasDb);
            }
            string maxNev = stat.First().Key;
            int AdasDb = stat.First().Value;
            foreach (var i in stat.Skip(1))
            {
                if (i.Value > AdasDb)
                {
                    AdasDb = i.Value;
                    maxNev = i.Key;
                }
            }
            Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
            Console.WriteLine($"\tNév: {maxNev}");
            Console.WriteLine($"\tAdások száma: {AdasDb} alkalom");

            Console.ReadKey(); 
        }
    }
}
