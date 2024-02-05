using System;
using System.Runtime.CompilerServices;

namespace OrvosiNobeldijasok
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> dijazottak = new List<string>();
            foreach(var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i)); 
            }

            //Feladat_3
            Console.WriteLine($"3.feladat: Díjazottak száma: {dijazottak.Count} fő");

            //Feladat_4
            int utolsoEv = dijazottak.First().Ev;
            foreach(var i in dijazottak.Skip(1))
            {
                if (i.Ev > utolsoEv)
                {
                    utolsoEv = i.Ev;
                }
            }
            //Feladat_5
            Console.WriteLine($"4. feladat: Az utolsó év: {utolsoEv}");
            Console.WriteLine("5. feladat: Kérem adja meg egy ország kódját: ");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> orszagdijazott = new List<Dijazott>();
            foreach (var item in dijazottak)
            {
                if (item.Országkód == orszagkod)
                {
                    orszagdijazott.Add(item);
                }
            }
            if (orszagdijazott.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");
            }
            if(orszagdijazott.Count == 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja: ");
                Console.WriteLine($"\tNév: {orszagdijazott.First().Nev}");
                Console.WriteLine($"\ttÉv: {orszagdijazott.First().Ev}");
                Console.WriteLine($"\ttSz/H: {orszagdijazott.First().SzuletesHalalozas}");
            }
            if (orszagdijazott.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {orszagdijazott.Count} fő díjazott volt");
            }
            Console.WriteLine("6.feladat: statisztika");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (dict.ContainsKey(i.Országkód)
                {
                    dict[i.Országkód]++
                }
                else
                {
                    dict.Add(i.Országkód, 1);
                }
            }
            foreach (var item in dict)
            {
                if (item.Value > 5)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value} fő");
                }
            }
         




            Console.ReadKey();
        }
    }
}