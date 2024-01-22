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
            // 3. feladat
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach(var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }

            // 4. feladat
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1-versenyzok.Count/ 691.0)* 100}%");

            //5. feladat
            int noiVersenyzoRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }
            Console.WriteLine($"5. feladat: Női versenyzők száma rövid távú versenyen: {noiVersenyzoRovidTavon} fő");

            //6.feladat
            bool TobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    TobbMintHat = true;
                    break;
                }
            }
            Console.WriteLine($"6. feladat: {(TobbMintHat ? "Volt":"Nem volt")} ilyen versenyző");

            //7. feladat
            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon:");
            Versenyzo gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (v.Tav == "Rövid" && v.Kategoria == "ff")
                {
                    if(gyoztesFerfiRovidTav == null)
                    {
                        gyoztesFerfiRovidTav = v;
                    }
                    else
                    {
                        if (v.Ido < gyoztesFerfiRovidTav.Ido)
                        {
                            gyoztesFerfiRovidTav = v;
                        }
                    }
                
                }
            }
            Console.WriteLine($"\tRajtszám: {gyoztesFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztesFerfiRovidTav.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztesFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztesFerfiRovidTav.Ido}");

            //7. feladat
            Console.WriteLine("8. feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var v in versenyzok)
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
            foreach (var s in stat)
            {
                Console.WriteLine($"\t{s.Key} - {s.Value} fő");
            }
            Console.ReadKey();
        }
    }
}
