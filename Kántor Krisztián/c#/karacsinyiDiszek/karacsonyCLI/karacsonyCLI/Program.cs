using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            List<NapiMunka> lista = new List<NapiMunka>();
            foreach (var sor in File.ReadAllLines("diszek.txt"))
            {
                lista.Add(new NapiMunka(sor));
            }
            //4
            Console.WriteLine($"4. feladat: összesen: {NapiMunka.KeszultDb} darab dísz készülqnt\n");

            //5
            bool nemKeszultDisz=false;
            foreach (NapiMunka item in lista)
            {
                if (item.HarangKesz==0&& item.AngyalkaKesz==0&& item.FenyofaKesz==0)
                {
                    nemKeszultDisz=true;
                    break;
                }
            }

            if (nemKeszultDisz)
            {
                Console.WriteLine("5. feladat Volt olyan nap, amikor egyetlen dísz sem készült.");
            }
            else
            {
                Console.WriteLine("5. feladat Nem volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            //6
            Console.WriteLine("6. feladat");
            int nap;

            do
            {
                Console.WriteLine("Adja meg a keresett napot [1....40]");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += lista[i].HarangKesz + lista[i].HarangEladott;
                angyalok += lista[i].AngyalkaKesz + lista[i].AngyalkaEladott;
                fenyofak += lista[i].FenyofaKesz + lista[i].FenyofaEladott;
            }
            Console.WriteLine( $"\tA(z) {nap}. nap végén {harangok} harang, {angyalok} angyalka és, {fenyofak} maradt készleten.\n");

            //7
            Console.WriteLine("7.feladat: Legtöbbet eladott dísz: ");

            Dictionary<string,int> legtobb = new Dictionary<string,int>();

            legtobb.Add("Harang", 0);
            legtobb.Add("Angyalka", 0);
            legtobb.Add("Fenyőfa", 0);

            foreach (NapiMunka item in lista )
            {
                legtobb["Harang"] -= item.HarangEladott;
                legtobb["Angyalka"] -= item.AngyalkaEladott;
                legtobb["Fenyőfa"] -= item.FenyofaEladott;
            }
            int max =legtobb.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in legtobb )
            {
                if (item.Value==max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            //8
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka item in lista )
            {
                if (item.NapiBevetel()>=10000)
                {
                    sw.WriteLine($"{item.Nap}:{item.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.Close();

            Console.ReadKey();
        }
    }
}
