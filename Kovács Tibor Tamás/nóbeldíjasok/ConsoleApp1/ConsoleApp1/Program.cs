using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            //3
            Console.WriteLine($"3.feladat: Díjazottak száma : {dijazottak.Count} fő");

            //4
            int utolsóÉv = dijazottak.First().Év;
            foreach(var i in dijazottak.Skip(1))
            {
                if(i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utolsóÉv}");

            //5
            Console.Write("5. feladat: Kérem adja meg egy ország kódját: ");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> orszagDijazott = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == orszagkod) orszagDijazott.Add(i);
            }

            if (orszagDijazott.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");
            }
            if (orszagDijazott.Count == 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév: {orszagDijazott.First().Név}");
                Console.WriteLine($"\tÉv: {orszagDijazott.First().Év}");
                Console.WriteLine($"\tSz/H: {orszagDijazott.First().SzületésHalálozás}");
            }
            if(orszagDijazott.Count > 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja : {orszagDijazott}");
            }

            //6
            Console.WriteLine("6. feladat : Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach(var i in dijazottak)
            {
                if (stat.ContainsKey(i.Országkód))
                {
                    stat[i.Országkód]++;
                }
                else
                {
                    stat.Add(i.Országkód, 1);
                }
            }
            foreach(var i in stat)
            {
                if (i.Value > 0)
                {
                    Console.WriteLine($"\t {i.Key} - {i.Value} fő");
                }
            }

            //7
            int osszElet = 0;
            int ismertHossz = 0;
            foreach(var i in dijazottak)
            {
                Elethossz aktDíjazottÉletkora = new Elethossz(i.SzületésHalálozás);
                if (aktDíjazottÉletkora.IsmertAzElethossz)
                {
                    osszElet += aktDíjazottÉletkora.ElethosszEvekben;
                    ismertHossz++;
                }
            }
            Console.WriteLine($"7. feladat: A keresett átlag: {(double)osszElet / ismertHossz:f1} év");

            Console.ReadKey();
        }
    }
}