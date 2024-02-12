using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace cbradio
{
    class Adat
    {
        public int ora { get; set; }
        public int perc { get; set; }
        public int darab { get; set; }
        public string nev { get; set; }
        public Adat(string sor)
        {
            string[] tomb = sor.Split(";");
            ora = int.Parse(tomb[0]);
            perc = int.Parse(tomb[1]);
            darab = int.Parse(tomb[2]);
            nev = tomb[3];
        }

        //6
        private int AtszamolPercre(int ora, int perc) => ora * 60 + perc;
        public int kezd => AtszamolPercre(ora, perc);
    }
     class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Adat> lista = new List<Adat>();
            foreach(var item in File.ReadAllLines("cb.txt").Skip(1))
            {
                lista.Add(new Adat(item));
            }

            //3
            Console.WriteLine($"3. feladat: Bejegyzések száma: {lista.Count} db.");

            //4
            bool volt = false;
            foreach(var item in lista)
            {
                if(item.darab == 4)
                {
                    volt = true;
                }
            }
            Console.WriteLine($"4. feladat: {(volt? "Volt" : "Nem volt")} négy adást indító sofőr.");

            //5
            Console.WriteLine("5. feladat: Kérek egy nevet: ");
            string line = Console.ReadLine();
            int db = 0;
            foreach(var item in lista)
            {
                if(item.nev == line)
                {
                    db += item.darab;
                }
            }
            if(db == 0)
            {
                Console.WriteLine("\t Nincs ilyen nevű sofőr!");
            }
            else
            {
                Console.WriteLine($"\t {line} {db}x használta a CB-rádiót");
            }

            //7
            List<string> ujLista = new List<string>();
            ujLista.Add("kezdes;nev;adasdb");
            foreach(var item in lista)
            {
                ujLista.Add($"{item.kezd};{item.nev};{item.darab}");
            }
            File.WriteAllLines("cb2.txt", ujLista);

            //8
            HashSet<string> set = new HashSet<string>();
            foreach(var item in lista)
            {
                set.Add(item.nev);
            }
            Console.WriteLine($"8. feladat: Sofőrök száma: {set.Count} fő.");

            //9
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(var item in lista)
            {
                if (dict.ContainsKey(item.nev))
                {
                    dict[item.nev] += item.darab;
                }
                else
                {
                    dict.Add(item.nev, item.darab);
                }
                string maxNev = dict.First().Key;
                int maxDb = dict.First().Value;
                foreach(var item2 in dict.Skip(1))
                {
                    if(item2.Value > maxDb)
                    {
                        maxDb = item2.Value;
                        maxNev = item2.Key;
                    }
                }
                Console.WriteLine("9. feladat: Legtöbb adást indító sofőr: ");
                Console.WriteLine($"\t Név: {maxNev}");
                Console.WriteLine($"\t Adások száma: {maxDb} alkalom.");
            }

            Console.ReadKey();
        }

        
        
    }
}