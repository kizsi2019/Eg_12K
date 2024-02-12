using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nobeldijjas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            Console.WriteLine($"3. Feladat: Dijízottak száma: {dijazottak.Count} fő");

            Console.ReadKey();

            int utolsóÉv = dijazottak.First().Ev;
            foreach (var i in dijazottak.Skip(1))
            {
                if (i.Ev > utolsóÉv)
                {
                    utolsóÉv = i.Ev;
                }
            }
            Console.WriteLine($"4. Feladat: Utolsó év: {utolsóÉv}");

            Console.ReadKey();

            Console.Write("5. feladat: Kérem adja meg egy ország kódját: ");
            string kód = Console.ReadLine().ToUpper();
            List<Dijazott> inputOrszágDíjazottjai = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == kód) inputOrszágDíjazottjai.Add(i);
            }

            if (inputOrszágDíjazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");
            }
            if (inputOrszágDíjazottjai.Count == 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév: {inputOrszágDíjazottjai.First().Név}");
                Console.WriteLine($"\tÉv: {inputOrszágDíjazottjai.First().Ev}");
                Console.WriteLine($"\tSz/H: {inputOrszágDíjazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszágDíjazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszágDíjazottjai.Count} fő díjazott volt!");
            }

            Console.ReadKey();

            Console.WriteLine("6. Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Országkód)) stat[i.Országkód]++;
                else stat.Add(i.Országkód, 1);
            }
            foreach (var i in stat)
            {
                if (i.Value > 5) Console.WriteLine($"\t{i.Key} - {i.Value} fő");

            }

            // 7. feladat
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktDíjazottÉletkora = new Elethossz(i.SzületésHalálozás);
                if (aktDíjazottÉletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktDíjazottÉletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.WriteLine($"7. feladat: A keresett átlag: {(double)élethosszÖsszeg / ismertÉlethosszFő:f1} év");

            Console.ReadKey();


        }
    }
}
