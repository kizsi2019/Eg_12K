using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace cbradio
{
    class Bejegyzes
    {
        public int KezdOra { get; private set; }
        public int KezdPerc { get; private set; }
        public int AdasDb { get; private set; }
        public string Nev { get; private set; }
        public Bejegyzes(string sor)
        {
            string[] m = sor.Split(';');
            KezdOra = int.Parse(m[0]);
            KezdPerc = int.Parse(m[1]);
            AdasDb = int.Parse(m[2]);
            Nev = m[3];
        }

        // 6. feladat
        private int AtszamolPercre(int ora, int perc) => ora * 60 + perc;

        public int Kezdes => AtszamolPercre(KezdOra, KezdPerc);
    }
    class cbradio
    {
        static void Main()
        {
            // 2. feladat: Beolvasás, tárolás
            List<Bejegyzes> b = new List<Bejegyzes>();
            foreach (var i in File.ReadAllLines("cb.txt").Skip(1))
            {
                b.Add(new Bejegyzes(i));
            }

            // 3. feladat:
            Console.WriteLine($"3. feladat: Bejegyzések száma: {b.Count} db");

            // 4. feladat
            bool volt4esBejegyzes = false;
            foreach (var i in b)
            {
                if (i.AdasDb == 4)
                {
                    volt4esBejegyzes = true;
                    break;
                }
            }
            Console.WriteLine($"4. feladat: {(volt4esBejegyzes ? "Volt" : "Nem volt")} négy adást indító sofőr.");

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

            // 7. feladat: cb2.txt
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
            string maxAdoNev = stat.First().Key;
            int maxAdasDb = stat.First().Value;
            foreach (var i in stat.Skip(1))
            {
                if (i.Value > maxAdasDb)
                {
                    maxAdasDb = i.Value;
                    maxAdoNev = i.Key;
                }
            }
            Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
            Console.WriteLine($"\tNév: {maxAdoNev}");
            Console.WriteLine($"\tAdások száma: {maxAdasDb} alkalom");

            Console.ReadKey();
        }
    }
}

