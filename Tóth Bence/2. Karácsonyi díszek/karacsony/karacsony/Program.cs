using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkaLista = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }

            //4.feladat 
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült.\n");

            
            //5. feladat
            bool nemKeszultDisz = false;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült.\n");
            else
                Console.WriteLine("5.feladat: Nem volt olyan amikor ne csinált volna díszt");

 

            //6.feladat
            Console.WriteLine("6.feladat");
            int nap;
            do
            {
                Console.Write("Adja meg a napot amelyiket keresi [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);

            int harang = 0, angyal = 0, fenyofa = 0;

            for (int i = 0; i < nap; i++)
            {
                harang += napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyal += napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofa += napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}. nap végén {harang} harang, {angyal} angyalka és {fenyofa} fenyőfa maradt készleten.\n");


            //7. legtöbb eladott
            Console.Write("7.feladat: Legtöbbet eladott dísz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach (NapiMunka disz in napiMunkaLista)
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


            //8. legalább 10000 bevétel
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka disz in napiMunkaLista)
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
