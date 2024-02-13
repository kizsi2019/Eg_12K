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
            Console.WriteLine($"4. feladat: Az utolsó év: {utolsoEv}");

            Console.ReadKey();
        }
    }
}