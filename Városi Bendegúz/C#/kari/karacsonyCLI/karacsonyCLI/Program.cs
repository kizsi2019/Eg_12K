using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace karacsonyCLI
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //3
            List<NapiMunka> lista = new List<NapiMunka>();
            foreach(string sor in File.ReadAllLines("diszek.txt"))
            {
                lista.Add(new NapiMunka(sor));
            }

            //4
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült el.");

            //5
            bool nemKeszult = false;
            foreach (NapiMunka item in lista)
            {
                if (item.HarangKesz == 0 && item.AngyalkaKesz == 0 && item.FenyofaKesz == 0)
                {
                    nemKeszult = true;
                }
            }
            if(nemKeszult)
            {
                Console.WriteLine("5. feladat: Volt olyan nap amikor egyetlen dísz sem készült.");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap amikor egyetlen dísz sem készült.");
            }

            //6
            Console.WriteLine("6. feladat:");
            int nap;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harang = 0;
            int angyal = 0;
            int fenyo = 0;
            for(int i = 0; i < nap; i++)
            {
                harang += lista[i].HarangKesz + lista[i].HarangEladott;
                angyal += lista[i].AngyalkaKesz + lista[i].AngyalkaEladott;
                fenyo += lista[i].FenyofaEladott + lista[i].FenyofaKesz;
            }
            Console.WriteLine($"\tA(z) {nap} nap végén {harang} harang , {angyal} anygalka és {fenyo} fenyőfa maradt készleten.");

            //7
            Dictionary<string,int> eladva = new Dictionary<string,int>();
            eladva.Add("Harang", 0);
            eladva.Add("Angyalka", 0);
            eladva.Add("Fenyőfa", 0);
            foreach(NapiMunka item in  lista)
            {
                eladva["Harang"] -= item.HarangEladott;
                eladva["Angyalka"] -= item.AngyalkaEladott;
                eladva["Fenyőfa"] -= item.FenyofaEladott;
            }
            int max = eladva.Values.Max(); ;
            Console.WriteLine($"7. feladat: A legtöbbet eladott dísz: {max} darab.");
            foreach(var item in eladva)
            {
                if(item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine();

            //8
            StreamWriter write = new StreamWriter("bevetel.txt");
            int tizezer = 0;
            foreach(NapiMunka item in lista)
            {
                if(item.NapiBevetel() >= 10000)
                {
                    write.WriteLine($"{item.Nap}:{item.NapiBevetel()}");
                    tizezer++;
                }
            }
            write.WriteLine($"{tizezer} napon volt legalább 10.000Ft a bevétel.\n");
            write.Close();

            Console.ReadKey();
        }
    }
}