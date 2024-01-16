using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BukkMaraton2019
{

    // 2. feladat:
    class Versenytav
    {
        private string Rajtszam; 
        public string Tav
        {
            get
            {
                switch (Rajtszam[0])
                {
                    case 'M': return "Mini";
                    case 'R': return "Rövid";
                    case 'K': return "Közép";
                    case 'H': return "Hosszú";
                    case 'E': return "Pedelec";
                }
                return "Hibás rajtszám";
            }
        }
        public Versenytav(string rajtszam)
        {
            Rajtszam = rajtszam;
        }
    }
    class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Kategoria { get; private set; }
        public string Nev { get; private set; }
        public string Egyesulet { get; private set; }
        public TimeSpan Ido { get; private set; }

        public string Tav { get; private set; }

        public bool NoiVersenyzo => Kategoria.Last() == 'n';

        public bool TobbMintHat => Ido > new TimeSpan(6, 0, 0);

        public Versenyzo(string sor)
        {
            string[] m = sor.Split(';');
            Rajtszam = m[0];
            Kategoria = m[1];
            Nev = m[2];
            Egyesulet = m[3];
            int ora = int.Parse(m[4].Split(':')[0]);
            int perc = int.Parse(m[4].Split(':')[1]);
            int mp = int.Parse(m[4].Split(':')[2]);
            Ido = new TimeSpan(ora, perc, mp);
            Tav = new Versenytav(Rajtszam).Tav;
        }
    }
    class BukkMaraton2019
    {
        static void Main()
        {
            // 3. feladat:
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }

            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0)*100}%");

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
            Console.WriteLine($"6. feladat: {(tobbMintHat ? "Volt": "Nem volt")} ilyen versenyző");

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

            Console.ReadKey(); // Nem a megoldás része
        }
    }
}
