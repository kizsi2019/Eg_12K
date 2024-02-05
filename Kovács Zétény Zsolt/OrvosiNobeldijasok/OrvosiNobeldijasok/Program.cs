using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            //3. Feladat
            Console.WriteLine($"3. Feladat: Díjazottak száma: {dijazottak.Count} fő");

            //4. Feladat
            int utolsoEv = dijazottak.First().Ev;
            foreach (var i in dijazottak.Skip(1))
            {
                if (i.Ev > utolsoEv)
                {
                    utolsoEv = i.Ev;
                }
            }

            Console.WriteLine($"4. Feladat: Utolsó év: {utolsoEv}");

            //5.Feladat

            Console.WriteLine("Adja meg az ország kódját!");
            string orszak_kod = Console.ReadLine().ToUpper();

            List<Dijazott> OrszagDijazottai = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (orszak_kod == i.Orszagkod)
                {
                    OrszagDijazottai.Add(i);
                }
            }
            if (OrszagDijazottai.Count == 0)
            {
                Console.WriteLine("Az országnak nem voltak díjazottai!");
            }
            if (OrszagDijazottai.Count == 1)
            {
                Console.WriteLine("\t A megadott ország díjazottai: ");
                Console.WriteLine($"\t Név: {OrszagDijazottai.First().Nev} ");
                Console.WriteLine($"\t Év: {OrszagDijazottai.First().Ev} ");
                Console.WriteLine($"\t Sz/H: {OrszagDijazottai.First().SzuletesHalalozas} ");
            }

            //6. Feladat
            Console.WriteLine("6 Feladat: Statisztika:");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (dic.ContainsKey(i.Orszagkod))
                {
                    dic[i.Orszagkod]++;
                }
                else
                {
                    dic.Add(i.Orszagkod, 1);
                }

            }
            foreach (var j in dic)
            {
                if (j.Value > 5)
                {
                    Console.WriteLine($"\t {j.Key} - {j.Value} fő");
                }
            }

            // 7. feladat
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktDíjazottÉletkora = new Elethossz(i.SzuletesHalalozas);
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
