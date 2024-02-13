using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat: Beolvasás, tárolás
            List<Bejegyzes> beolv = new List<Bejegyzes>();
            foreach (var i in File.ReadAllLines("cb.txt").Skip(1))
            {
                beolv.Add(new Bejegyzes(i));
            }

            // 3. feladat:
            Console.WriteLine($"3. feladat: Bejegyzések száma: {beolv.Count} db");

            // 4. feladat
            bool v4es = false;
            foreach (var i in beolv)
            {
                if (i.AdasDb == 4)
                {
                    v4es = true;
                    break;
                }
            }
            Console.WriteLine($"4. feladat: {(v4es ? "Volt" : "Nem volt")} négy adást indító sofőr.");
            // 5. feladat:
            Console.Write("5. feladat: Kérek egy nevet: ");
            string inputNev = Console.ReadLine();
            int adasDb = 0;
            foreach (var i in beolv)
            {
                if (i.Nev == inputNev) adasDb += i.AdasDb;
            }
            if (adasDb == 0) Console.WriteLine("\tNincs ilyen nevű sofőr!");
            else Console.WriteLine($"\t{inputNev} {adasDb}x használta a CB-rádiót.");

            // 7. feladat: cb2.txt
            List<string> ki = new List<string>();
            ki.Add("Kezdes;Nev;AdasDb");
            foreach (var i in beolv)
            {
                ki.Add($"{i.Kezdes};{i.Nev};{i.AdasDb}");
            }
            File.WriteAllLines("cb2.txt", ki);

            // 8. sofőrök száma:
            HashSet<string> nevek = new HashSet<string>();
            foreach (var i in beolv)
            {
                nevek.Add(i.Nev);
            }
            Console.WriteLine($"8. feladat: Sofőrök száma: {nevek.Count} fő");

            // 9. Legtöbb adást indító söfőr
            Dictionary<string, int> legtobb = new Dictionary<string, int>();
            foreach (var i in beolv)
            {
                if (legtobb.ContainsKey(i.Nev)) legtobb[i.Nev] += i.AdasDb;
                else legtobb.Add(i.Nev, i.AdasDb);
            }
            string max = legtobb.First().Key;
            int maxAdasDb = legtobb.First().Value;
            foreach (var i in legtobb.Skip(1))
            {
                if (i.Value > maxAdasDb)
                {
                    maxAdasDb = i.Value;
                    max = i.Key;
                }
            }
            Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
            Console.WriteLine($"\tNév: {max}");
            Console.WriteLine($"\tAdások száma: {maxAdasDb} alkalom");

            Console.ReadKey();
        }
    }
}
