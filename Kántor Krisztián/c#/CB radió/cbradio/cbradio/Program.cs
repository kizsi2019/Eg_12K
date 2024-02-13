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
            //2
            List<Beolv> lista = new List<Beolv>();
            foreach(var sor in File.ReadAllLines("cb.txt").Skip(1))
            {
                lista.Add(new Beolv(sor));
            }

            //3
            Console.WriteLine($"3. feladat: Bejegyzések száma: {lista.Count}");


            //4
            bool volt=false;
            foreach(Beolv item in lista)
            {
                if ((item.perc/item.db)==0)
                {
                    volt = true;
                }
            }

            if (volt)
            {
                Console.WriteLine("4. feladat: Volt négy adást indító sofőr.");
            }

            else { Console.WriteLine("4. feladat: Ne volt négy adást indító sofőr"); }

            //5
            Console.WriteLine("5. feladat: Kérek egy nevet: ");
            string name = Console.ReadLine();
            int szam = 0;
            foreach(Beolv item in lista)
            {
                if (name==item.nev)
                {
                    szam += item.db;
                }
            }
            if(szam>0)
            {
                Console.WriteLine($"\t{name} {szam}x használta a CB-rádiót");
            }
            else
            {
                Console.WriteLine("\tNincs ilyen nevű sofőr!");
            }

            //7
            List<string> lista2 = new List<string>();
            lista2.Add("Kezdes;Nev;AdasDb");
            foreach (var item in lista)
            {
                lista2.Add($"{item.Kezdes()};{item.nev};{item.db}");
            }
            File.WriteAllLines("cb2.txt", lista2);

            //8
            HashSet<string> nevek = new HashSet<string>();
            foreach (var item in lista)
            {
                nevek.Add(item.nev);
            }
            Console.WriteLine($"8. feladat: Sofőrök száma: {nevek.Count} fő");

            //9
            Dictionary<string, int> lista3 = new Dictionary<string, int>();
            foreach (var item in lista)
            {
                if (lista3.ContainsKey(item.nev)) lista3[item.nev] += item.db;
                else lista3.Add(item.nev, item.db);
            }
            string maxiNev = lista3.First().Key;
            int maxiDb = lista3.First().Value;
            foreach (var item in lista3.Skip(1))
            {
                if (item.Value > maxiDb)
                {
                    maxiDb = item.Value;
                    maxiNev = item.Key;
                }
            }
            Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
            Console.WriteLine($"\tNév: {maxiNev}");
            Console.WriteLine($"\tAdások száma: {maxiDb} alkalom");


            Console.ReadKey();
        }

        
    }
}
