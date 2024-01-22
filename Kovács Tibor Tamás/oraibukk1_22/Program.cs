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
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");


            int noiVersenyzoRovidTavon = 0;
            foreach(var v in versenyzok)
            {
                if(v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }
            Console.WriteLine($"5. feladat: Női versenyzők száma rövid távú versenyen: {noiVersenyzoRovidTavon} fő");

            Console.ReadKey();

            Console.WriteLine("7.feladat: A felnőtt férfi kategória győztese rövid távon:");
            Versenyzo gyoztesferfiRovidTav = null;
            foreach(var v in versenyzok)
            {
                if(v Tav == "Rövid" && v.Kategoria == "ff"){
                    gyoztesferfiRovidTav = v;
                }
                else
                {
                    if(v.ido < gyoztesferfiRovidTav == "ff")
                    {
                        gyoztesferfiRovidTav = v;
                    }
                }
            }
            Console.WriteLine($*\tRajtszám: { gyoztesferfiRovidTav.Rajtszam}*);

            Console.WriteLine("8.feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach(var v in versenyzok)
            {
                if (stat.ContainsKey(v.kategoria))
                {
                    stat[v.kategoria]++;
                }
                else
                {
                    stat.Add(v.kategoria, 1);
                }
            }
            foreach(var s in stat)
            {
                Console.WriteLine($*\t{ s.Key} - { s.Value} fő*);
            }
            Console.ReadKey();
        }
    } }
