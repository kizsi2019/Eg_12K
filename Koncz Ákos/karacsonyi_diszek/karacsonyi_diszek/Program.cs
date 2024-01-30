using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyi_diszek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napim = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napim.Add(new NapiMunka(sor));
            }

            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült.\n");


            bool nemkeszult = false;
            foreach (NapiMunka i in napim)
            {
                if (i.HarangKesz == 0 && i.AngyalkaKesz == 0 && i.FenyofaKesz == 0)
                {
                    nemkeszult = true;
                    break;
                }
            }
            if (nemkeszult)
            {
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült.\n");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            //6. feladat

            int nap = 0;

            do
            {
                Console.Write("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            }
            while (nap < 1 || nap > 40);

            int harangok = 0;
            int fenyofak = 0;
            int angyalkak = 0;

            for (int i = 0; i < nap; i++)
            {
                harangok += napim[i].HarangKesz + napim[i].HarangEladott;
                fenyofak += napim[i].FenyofaKesz + napim[i].FenyofaEladott;
                angyalkak += napim[i].AngyalkaKesz + napim[i].AngyalkaEladott;
            }

            Console.WriteLine($"A(z) {nap}. nap végén {harangok} harang, {angyalkak} angyalka és {fenyofak} fenyőfa maradt készleten.");


            //7. feladat

            int max = 0;
            List<int> maxok = new List<int>();

            int harangEladott = 0;
            int angyalkaEladott = 0;
            int fenyofaEladott = 0;

            foreach (var i in napim)
            {
                harangEladott -= i.HarangEladott;
                angyalkaEladott -= i.AngyalkaEladott;
                fenyofaEladott -= i.FenyofaEladott;

                maxok.Add(harangEladott);
                maxok.Add(angyalkaEladott);
                maxok.Add(fenyofaEladott);
            }
            foreach (int i in maxok)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            Console.WriteLine($"7. feladat: Legtöbbet eladott dísz: {max} darab");

            if (harangEladott == max)
            {
                Console.WriteLine("\tHarang");
            }
            if (angyalkaEladott == max)
            {
                Console.WriteLine("\tAngyalka");
            }
            if (fenyofaEladott == max)
            {
                Console.WriteLine("\tFenyőfa");
            }

            //8. feladat

            if (!File.Exists("bevetel.txt"))
            {
                StreamWriter sw = new StreamWriter("bevetel.txt");

                int nagyobbMint10k = 0;
                foreach (NapiMunka i in napim)
                {
                    if (i.NapiBevetel() >= 10000)
                    {
                        sw.WriteLine($"{i.Nap}:{i.NapiBevetel()}");
                        nagyobbMint10k++;
                    }
                }

                sw.WriteLine($"{nagyobbMint10k} napon volt legalább 10000 Ft a bevétel.\n");
                sw.Close();
            }

            Console.ReadKey();
        }
    }
}
