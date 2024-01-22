using bukkmaraton2019;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BukkMaraton2019
{
    internal class BukkMaraton2019
    {
        static void Main(string[] args)
        {
            // 3. feladat:
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }


            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            // 5. feladat
            int noiVersenyzokRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid") noiVersenyzokRovidTavon++;
            }
            Console.WriteLine($"5. feladat: Női versenyzők száma a rövid távú versenyen: {noiVersenyzokRovidTavon}fő");

            // 6. feladat:
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }
            Console.WriteLine($"6. feladat: {(tobbMintHat ? "Volt" : "Nem volt")} ilyen versenyző");

            // 7. feladat
            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategóra győztese rövid távon");
            Versenyzo gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (v.Tav == "Rövid" && v.Kategoria == "ff")
                {
                    if (gyoztesFerfiRovidTav == null) gyoztesFerfiRovidTav = v;
                    else
                    {
                        if (v.Ido < gyoztesFerfiRovidTav.Ido) gyoztesFerfiRovidTav = v;
                    }
                }


            }
            Console.WriteLine($"\tRajtszám: {gyoztesFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztesFerfiRovidTav.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztesFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztesFerfiRovidTav.Ido}");


            Console.WriteLine("8. feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var v in versenyzok)
            {
                if (!v.NoiVersenyzo)
                {
                    if (stat.ContainsKey(v.Kategoria)) stat[v.Kategoria]++;
                    else stat.Add(v.Kategoria, 1);
                }
            }
            foreach (var s in stat) Console.WriteLine($"\t{s.Key} - {s.Value}fő");

            Console.ReadKey();
        }
    }
}
