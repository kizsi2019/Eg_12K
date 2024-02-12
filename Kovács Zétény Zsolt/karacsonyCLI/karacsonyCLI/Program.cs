using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> NapiMunka_lista = new List<NapiMunka>();
            foreach(string sor in File.ReadAllLines("diszek.txt"))
            {
                NapiMunka_lista.Add(new NapiMunka(sor));
            }

            //4.Feldat
            Console.WriteLine($"Összesen {NapiMunka.KeszultDb} darab dísz készült el");

            //5. Feladat
            bool nemKeszukt = false;
            foreach(NapiMunka disz in NapiMunka_lista)
            {
                if(disz.HarangKesz == 0 && disz.FenyofaKesz == 0 && disz.AngyalkaKesz == 0) 
                {
                    nemKeszukt = true;
                    break;
                }
                else
                {
                    nemKeszukt = false;
                }
            }
            if(nemKeszukt )
            {
                Console.WriteLine("5.Feladat: Volt olyan nap mikor nem készült dísz!");
            }
            else { Console.WriteLine("5.Feladat: Nem volt olyan nap mikor nem készült volna dísz"); }


            //6.Feladat
            int nap;
            do
            {
                Console.WriteLine("Adja meg a keresett napot[1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            }while(nap < 1 || nap > 40);
            int harangok = 0, angyalok = 0, fenyofadisz = 0;

            for(int i = 0; i < nap; i++)
            {
                harangok += NapiMunka_lista[i].HarangKesz + NapiMunka_lista[i].HarangEladott;
                angyalok += NapiMunka_lista[i].AngyalkaKesz + NapiMunka_lista[i].AngyalkaEladott;
                fenyofadisz += NapiMunka_lista[i].FenyofaKesz + NapiMunka_lista[i].FenyofaEladott;
            }
            Console.WriteLine($"\t A(az) {nap}. nap végén {harangok} harang, {angyalok} angyalka és {fenyofadisz} fenyőfa maradt készleten.\n");

            //7. legtöbb eladott
            Console.Write("7.feladat: Legtöbbet eladott dísz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach (NapiMunka disz in NapiMunka_lista)
            {
                eladottak["Harang"] -= disz.HarangEladott;
                eladottak["Angyalka"] -= disz.AngyalkaEladott;
                eladottak["Fenyőfa"] -= disz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                    Console.WriteLine($"\t{item.Key}");
            }

            Console.WriteLine();

            //8. legalább 10000 bevétel
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka disz in NapiMunka_lista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap}:{disz.NapiBevetel()}");
                    legalabb10000++;
                }

            }
            sw.WriteLine($"{legalabb10000} napon volt legalább 10000 Ft a bevétel.\n");
            sw.Close();

            Console.ReadKey();
        }
    }
}
