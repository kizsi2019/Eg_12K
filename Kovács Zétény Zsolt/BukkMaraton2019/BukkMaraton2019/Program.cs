using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BukkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Feladat
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            //4.feladat
            Console.WriteLine($"4. Feladat: Versenytávot nem teljesítők:{(1 - versenyzok.Count / 691.0) * 100}%");

            // 5.  Feladat
            int noiVersenyzoRovidTavon = 0;
            foreach (var item in versenyzok)
            {
                if (item.NoiVersenyzo && item.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }

            }
            Console.WriteLine($"5. Feladat: Mői versenyzők száma rövid távú versenyen:{noiVersenyzoRovidTavon}");
            bool tobbMintHat = false;
            foreach (var item in versenyzok)
            {
                if (item.TobbMintHat)
                {
                    tobbMintHat |= true;
                    break;
                }
            }
            Console.WriteLine($"6. Feladat: {(tobbMintHat ? "Volt" : "Nem volt")} ilyen versenyző");


            Console.WriteLine($"7. Feladat: A felnőtt kazegória győztese rövid távon: ");
            Versenyzo gyoztesFerfiRovidTav = null;
            foreach (var item in versenyzok)
            {
                if (item.Tav == "Rövid" && item.Kategoria == "ff")
                {
                    if (gyoztesFerfiRovidTav == null)
                    {
                        gyoztesFerfiRovidTav = item;
                    }
                    else
                    {
                        if (item.Ido < gyoztesFerfiRovidTav.Ido)
                        {
                            gyoztesFerfiRovidTav = item;
                        }
                    }
                }

            }
            Console.WriteLine($"\t Rajtszám: {gyoztesFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\t Név: {gyoztesFerfiRovidTav.Nev}");
            Console.WriteLine($"\t Egyesület: {gyoztesFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\t Idő: {gyoztesFerfiRovidTav.Ido}");


            // 8. Feladat
            Console.WriteLine("8. Feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var v in versenyzok)
            {
                if (!v.NoiVersenyzo)
                {
                    if (stat.ContainsKey(v.Kategoria))
                    {
                        stat[v.Kategoria]++;
                    }
                    else
                    {
                        stat.Add(v.Kategoria, 1);
                    }

                }
            }

            foreach (var v in stat)
            {
                Console.WriteLine($"\t{v.Key} - {v.Value}fő");
            }


            Console.ReadKey();
        }
    }
}




