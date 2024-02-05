using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orvosiNobelDijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List<Dijazott> díjazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                díjazottak.Add(new Dijazott(i));
            }

            // 3. feladat
            Console.WriteLine($"3. feladat: Díjazottak száma: {díjazottak.Count} fő");

            // 4. feladat
            int utolsóÉv = díjazottak.First().Év;
            foreach (var i in díjazottak.Skip(1))
            {
                if (i.Év > utolsóÉv) utolsóÉv = i.Év;
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utolsóÉv}");

            // 5. feladat

            Console.Write("5. feladat: Kérem adja meg egy ország kódját: ");
            string inputOK = Console.ReadLine().ToUpper();
            List<Dijazott> inputOD = new List<Dijazott>();
            foreach (var i in díjazottak)
            {
                if (i.Országkód == inputOK) inputOD.Add(i);
            }

            if (inputOD.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");
            }
            if (inputOD.Count == 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév: {inputOD.First().Név}");
                Console.WriteLine($"\tÉv: {inputOD.First().Év}");
                Console.WriteLine($"\tSz/H: {inputOD.First().SzületésHalálozás}");
            }
            if (inputOD.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOD.Count} fő díjazott volt!");
            }

            // 6. feladat

            Console.WriteLine("6. Statisztika");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var i in díjazottak)
            {
                if (dic.ContainsKey(i.Országkód)) dic[i.Országkód]++;
                else dic.Add(i.Országkód, 1);
            }
            foreach (var i in dic)
            {
                if (i.Value > 5) Console.WriteLine($"\t{i.Key} - {i.Value} fő");
            }

            // 7. feladat
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in díjazottak)
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
